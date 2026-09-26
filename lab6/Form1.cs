using System.Globalization;
using System.Text;

namespace lab6
{
    public partial class Form1 : Form
    {
        private record Item(string Name, decimal Price);

        // Орієнтовні ціни популярних речей, грн
        private static readonly Item[] Items =
        {
            new("Навушники AirPods", 7_000m),
            new("Велосипед", 15_000m),
            new("PlayStation 5", 22_000m),
            new("Ноутбук", 35_000m),
            new("Відпустка в Єгипті (7 днів)", 45_000m),
            new("iPhone 17", 55_000m),
            new("Відпустка в Європі (10 днів)", 80_000m),
            new("Вживане авто", 300_000m),
        };

        private static readonly CultureInfo Uk = CultureInfo.GetCultureInfo("uk-UA");

        public Form1()
        {
            InitializeComponent();
            Calculate();
        }

        private void btnCalculate_Click(object? sender, EventArgs e) => Calculate();

        private void btnReset_Click(object? sender, EventArgs e)
        {
            numCoffee.Value = 0;
            numCigarettes.Value = 0;
            numTaxi.Value = 0;
            numOther.Value = 0;
            numDaysPerWeek.Value = 7;
            Calculate();
        }

        private void Calculate()
        {
            decimal perDay = numCoffee.Value + numCigarettes.Value + numTaxi.Value + numOther.Value;
            decimal activeDaysPerYear = 365m * numDaysPerWeek.Value / 7m;

            decimal perYear = perDay * activeDaysPerYear;
            decimal perMonth = perYear / 12m;
            decimal per5Years = perYear * 5m;

            lblDay.Text = Money(perDay);
            lblMonth.Text = Money(perMonth);
            lblYear.Text = Money(perYear);
            lbl5Years.Text = Money(per5Years);

            listViewItems.BeginUpdate();
            listViewItems.Items.Clear();
            foreach (var item in Items)
            {
                var row = new ListViewItem(item.Name);
                row.SubItems.Add(item.Price.ToString("N0", Uk));
                row.SubItems.Add(Count(perMonth, item.Price));
                row.SubItems.Add(Count(perYear, item.Price));
                row.SubItems.Add(Count(per5Years, item.Price));
                if (per5Years < item.Price)
                    row.ForeColor = Color.Gray;
                listViewItems.Items.Add(row);
            }
            listViewItems.EndUpdate();

            txtSummary.Text = BuildSummary(perDay, perMonth, perYear, per5Years);
        }

        private static string BuildSummary(decimal perDay, decimal perMonth, decimal perYear, decimal per5Years)
        {
            if (perDay == 0)
                return "Введіть щоденні витрати та натисніть «Порахувати».";

            var sb = new StringBuilder();
            sb.AppendLine($"Витрачаючи {Money(perDay)} на день, за 5 років ви віддасте {Money(per5Years)}.");
            sb.AppendLine();
            sb.AppendLine("За ці гроші можна купити:");
            AppendPeriod(sb, "за місяць", perMonth);
            AppendPeriod(sb, "за рік", perYear);
            AppendPeriod(sb, "за 5 років", per5Years);
            return sb.ToString();
        }

        // Найдорожча річ, яку можна дозволити собі за період, і скільки таких
        private static void AppendPeriod(StringBuilder sb, string period, decimal amount)
        {
            var best = Items.Where(i => i.Price <= amount).MaxBy(i => i.Price);
            if (best is null)
            {
                var cheapest = Items.MinBy(i => i.Price)!;
                decimal percent = amount / cheapest.Price * 100m;
                sb.AppendLine($"  • {period}: поки нічого — це {percent:F0}% від ціни «{cheapest.Name}».");
                return;
            }

            int count = (int)(amount / best.Price);
            decimal rest = amount - count * best.Price;
            string times = count > 1 ? $"{count} × " : "";
            sb.AppendLine($"  • {period}: {times}{best.Name} (і ще залишиться {Money(rest)}).");
        }

        private static string Count(decimal amount, decimal price)
        {
            decimal n = amount / price;
            return n >= 1 ? Math.Floor(n).ToString("N0", Uk) : n.ToString("0.00", Uk);
        }

        private static string Money(decimal value) => value.ToString("N2", Uk) + " грн";
    }
}
