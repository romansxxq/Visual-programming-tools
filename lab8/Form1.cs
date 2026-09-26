using System.Globalization;
using System.Text;

namespace lab8
{
    public partial class Form1 : Form
    {
        private record Fuel(string Name, decimal KgPerKm);
        private record Device(string Name, decimal Kw, NumericUpDown Hours);
        private record Source(string Name, decimal KgPerYear);

        // Приблизні викиди CO₂ легкового авто, кг на 1 км
        private static readonly Fuel[] Fuels =
        {
            new("Бензин", 0.19m),
            new("Дизель", 0.17m),
            new("Газ (LPG)", 0.15m),
            new("Гібрид", 0.11m),
            new("Електромобіль", 0.07m), // ≈0,18 кВт·год/км × коефіцієнт мережі
        };

        private const decimal GridKgPerKwh = 0.37m;     // викиди енергосистеми, кг CO₂ на 1 кВт·год
        private const decimal TreeKgPerYear = 22m;      // одне доросле дерево поглинає за рік
        private const decimal AveragePersonKg = 4_000m; // середній українець, усі джерела, кг/рік
        private const decimal DaysPerYear = 365m;
        private const decimal WeeksPerYear = DaysPerYear / 7m;

        private static readonly CultureInfo Uk = CultureInfo.GetCultureInfo("uk-UA");

        private readonly Device[] _devices;

        public Form1()
        {
            InitializeComponent();

            _devices = new Device[]
            {
                new("Комп'ютер", 0.15m, numComputer),
                new("Телевізор", 0.10m, numTv),
                new("Кондиціонер", 1.50m, numHeater),
                new("Електрочайник", 2.00m, numKettle),
                new("Пральна машина", 0.80m, numWasher),
                new("Освітлення", 0.10m, numLighting),
            };

            cmbFuel.Items.AddRange(Fuels.Select(f => (object)f.Name).ToArray());
            cmbFuel.SelectedIndex = 0;
            Calculate();
        }

        private void btnCalculate_Click(object? sender, EventArgs e) => Calculate();

        private void Input_Changed(object? sender, EventArgs e) => Calculate();

        private void btnReset_Click(object? sender, EventArgs e)
        {
            numTrips.Value = 0;
            numDistance.Value = 10;
            cmbFuel.SelectedIndex = 0;
            foreach (var device in _devices)
                device.Hours.Value = 0;
            Calculate();
        }

        private void Calculate()
        {
            // Події ValueChanged можуть спрацювати ще до завершення конструктора
            if (_devices is null || cmbFuel.SelectedIndex < 0)
                return;

            var fuel = Fuels[cmbFuel.SelectedIndex];
            decimal kmPerYear = numTrips.Value * numDistance.Value * WeeksPerYear;

            var sources = new List<Source> { new($"Авто ({fuel.Name.ToLower(Uk)})", kmPerYear * fuel.KgPerKm) };
            foreach (var device in _devices)
            {
                decimal kwhPerYear = device.Kw * device.Hours.Value * DaysPerYear;
                sources.Add(new(device.Name, kwhPerYear * GridKgPerKwh));
            }

            decimal perYear = sources.Sum(s => s.KgPerYear);

            lblWeek.Text = Mass(perYear / WeeksPerYear);
            lblMonth.Text = Mass(perYear / 12m);
            lblYear.Text = Mass(perYear);
            lblTrees.Text = Math.Ceiling(perYear / TreeKgPerYear).ToString("N0", Uk);

            listViewSources.BeginUpdate();
            listViewSources.Items.Clear();
            foreach (var source in sources.OrderByDescending(s => s.KgPerYear))
            {
                var row = new ListViewItem(source.Name);
                row.SubItems.Add(source.KgPerYear.ToString("N1", Uk));
                row.SubItems.Add(perYear > 0 ? (source.KgPerYear / perYear).ToString("P0", Uk) : "—");
                if (source.KgPerYear == 0)
                    row.ForeColor = Color.Gray;
                listViewSources.Items.Add(row);
            }
            listViewSources.EndUpdate();

            txtSummary.Text = BuildSummary(sources, perYear, kmPerYear, fuel);
        }

        private static string BuildSummary(List<Source> sources, decimal perYear, decimal kmPerYear, Fuel fuel)
        {
            if (perYear == 0)
                return "Введіть кількість поїздок та години роботи приладів.";

            var sb = new StringBuilder();
            var biggest = sources.MaxBy(s => s.KgPerYear)!;
            sb.AppendLine($"Найбільше викидів дає «{biggest.Name}» — {(biggest.KgPerYear / perYear).ToString("P0", Uk)} від загальної суми.");

            decimal share = perYear / AveragePersonKg;
            sb.AppendLine($"Це {share.ToString("P0", Uk)} від середнього річного сліду українця (~{Mass(AveragePersonKg)}).");

            var electric = Fuels[^1];
            if (fuel != electric && kmPerYear > 0)
            {
                decimal saved = kmPerYear * (fuel.KgPerKm - electric.KgPerKm);
                sb.AppendLine($"На електромобілі ви б скоротили викиди на {Mass(saved)} на рік.");
            }

            return sb.ToString();
        }

        private static string Mass(decimal kg) =>
            kg >= 1000m ? (kg / 1000m).ToString("N2", Uk) + " т" : kg.ToString("N1", Uk) + " кг";
    }
}
