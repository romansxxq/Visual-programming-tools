using System.Globalization;
using System.Text;

namespace lab9
{
    public partial class Form1 : Form
    {
        private record Tariff(string Name, decimal Fee, decimal Gb, decimal Minutes, decimal Sms,
                              decimal PricePerGb, decimal PricePerMinute, decimal PricePerSms);

        private record Offer(Tariff Tariff, decimal Overage, decimal Total);

        private const decimal Unlimited = decimal.MaxValue;

        // Абонплата, пакет (ГБ / хв / SMS) і ціна кожної одиниці понад пакет, грн
        private static readonly Tariff[] Tariffs =
        {
            new("Лайт",     150m,  5m,  100m,  50m, 30m, 1.5m, 1.0m),
            new("Смарт",    250m, 20m,  400m, 100m, 25m, 1.2m, 1.0m),
            new("Макс",     350m, 50m, 1000m, 300m, 20m, 1.0m, 0.8m),
            new("Безліміт", 500m, Unlimited, Unlimited, Unlimited, 0m, 0m, 0m),
        };

        private static readonly CultureInfo Uk = CultureInfo.GetCultureInfo("uk-UA");

        private readonly bool _initialized;
        private readonly Font _boldFont;

        public Form1()
        {
            InitializeComponent();
            _boldFont = new Font(listViewTariffs.Font, FontStyle.Bold);
            _initialized = true;
            Calculate();
        }

        private void btnCalculate_Click(object? sender, EventArgs e) => Calculate();

        private void Input_Changed(object? sender, EventArgs e) => Calculate();

        private void btnReset_Click(object? sender, EventArgs e)
        {
            numInternet.Value = 0;
            numMinutes.Value = 0;
            numSms.Value = 0;
            Calculate();
        }

        private void Calculate()
        {
            // Події ValueChanged спрацьовують ще всередині InitializeComponent
            if (!_initialized)
                return;

            decimal gb = numInternet.Value;
            decimal minutes = numMinutes.Value;
            decimal sms = numSms.Value;

            var offers = new List<Offer>();
            foreach (var tariff in Tariffs)
                offers.Add(Price(tariff, gb, minutes, sms));

            // При однаковій сумі лишається тариф з меншою абонплатою (він раніше у списку)
            Offer best = offers[0];
            foreach (var offer in offers)
            {
                if (offer.Total < best.Total)
                    best = offer;
            }

            Offer? runnerUp = null;
            foreach (var offer in offers)
            {
                if (ReferenceEquals(offer, best))
                    continue;
                if (runnerUp is null || offer.Total < runnerUp.Total)
                    runnerUp = offer;
            }

            lblBestName.Text = best.Tariff.Name;
            lblCost.Text = Money(best.Total);
            lblYear.Text = Money(best.Total * 12m);
            lblOverage.Text = best.Overage > 0 ? Money(best.Overage) : "немає";
            lblSaving.Text = runnerUp is null ? "—" : Money(runnerUp.Total - best.Total);

            listViewTariffs.BeginUpdate();
            listViewTariffs.Items.Clear();
            foreach (var offer in offers)
            {
                var t = offer.Tariff;
                var row = new ListViewItem(t.Name);
                row.SubItems.Add($"{Amount(t.Gb)} ГБ · {Amount(t.Minutes)} хв · {Amount(t.Sms)} SMS");
                row.SubItems.Add(Money(t.Fee));
                row.SubItems.Add(offer.Overage > 0 ? Money(offer.Overage) : "—");
                row.SubItems.Add(Money(offer.Total));
                if (ReferenceEquals(offer, best))
                {
                    row.Font = _boldFont;
                    row.ForeColor = Color.ForestGreen;
                    row.BackColor = Color.Honeydew;
                }
                listViewTariffs.Items.Add(row);
            }
            listViewTariffs.EndUpdate();

            txtSummary.Text = BuildSummary(best, runnerUp, gb, minutes, sms);
        }

        private static Offer Price(Tariff t, decimal gb, decimal minutes, decimal sms)
        {
            decimal overage = 0m;
            if (gb > t.Gb)
                overage += (gb - t.Gb) * t.PricePerGb;
            if (minutes > t.Minutes)
                overage += (minutes - t.Minutes) * t.PricePerMinute;
            if (sms > t.Sms)
                overage += (sms - t.Sms) * t.PricePerSms;
            return new Offer(t, overage, t.Fee + overage);
        }

        private static string BuildSummary(Offer best, Offer? runnerUp, decimal gb, decimal minutes, decimal sms)
        {
            var sb = new StringBuilder();
            sb.AppendLine(Profile(gb, minutes, sms));
            sb.AppendLine();

            var t = best.Tariff;
            if (best.Overage == 0)
            {
                sb.AppendLine($"Пакет тарифу «{t.Name}» повністю покриває ваше споживання.");
            }
            else
            {
                sb.AppendLine($"«{t.Name}» вигідніший навіть з доплатою за перевищення пакета:");
                if (gb > t.Gb)
                    sb.AppendLine($"  • інтернет: +{Amount(gb - t.Gb)} ГБ × {Money(t.PricePerGb)} = {Money((gb - t.Gb) * t.PricePerGb)}");
                if (minutes > t.Minutes)
                    sb.AppendLine($"  • дзвінки: +{Amount(minutes - t.Minutes)} хв × {Money(t.PricePerMinute)} = {Money((minutes - t.Minutes) * t.PricePerMinute)}");
                if (sms > t.Sms)
                    sb.AppendLine($"  • SMS: +{Amount(sms - t.Sms)} × {Money(t.PricePerSms)} = {Money((sms - t.Sms) * t.PricePerSms)}");
            }

            if (runnerUp is not null)
            {
                if (runnerUp.Total == best.Total)
                    sb.AppendLine($"«{runnerUp.Tariff.Name}» коштує стільки ж — обирайте за зручністю.");
                else
                    sb.AppendLine($"Найближча альтернатива — «{runnerUp.Tariff.Name}» за {Money(runnerUp.Total)} на місяць.");
            }

            return sb.ToString();
        }

        private static string Profile(decimal gb, decimal minutes, decimal sms)
        {
            if (gb == 0 && minutes == 0 && sms == 0)
                return "Ви майже не користуєтесь зв'язком — вистачить мінімального пакета.";
            else if (gb >= 30 && minutes >= 500)
                return "Профіль: активний користувач — багато і інтернету, і дзвінків.";
            else if (gb >= 30)
                return "Профіль: інтернет-користувач — основні витрати на мобільний трафік.";
            else if (minutes >= 500)
                return "Профіль: любитель поговорити — основні витрати на дзвінки.";
            else if (sms >= 200)
                return "Профіль: активно надсилаєте SMS.";
            else
                return "Профіль: помірне споживання.";
        }

        private static string Amount(decimal value) =>
            value == Unlimited ? "∞" : value.ToString("0.#", Uk);

        private static string Money(decimal value) =>
            value.ToString(value % 1 == 0 ? "N0" : "N2", Uk) + " ₴";
    }
}
