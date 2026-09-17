using System.Globalization;

namespace Test
{
    public partial class Form1 : Form
    {
        private const decimal BaseFare = 50m;
        private const decimal ChildSeatFee = 40m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTariff.Items.Clear();
            cboTariff.Items.AddRange(["Економ", "Стандарт", "Комфорт"]);
            cboTariff.SelectedIndex = -1;
            lblResultValue.Text = "—";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDistance.Text))
            {
                MessageBox.Show("Введіть відстань поїздки.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TryParseDistance(txtDistance.Text, out double distance) || distance < 0)
            {
                MessageBox.Show("Відстань має бути коректним невід'ємним числом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboTariff.SelectedItem is not string tariff)
            {
                MessageBox.Show("Оберіть тариф.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal pricePerKm = tariff switch
            {
                "Економ" => 12m,
                "Стандарт" => 18m,
                "Комфорт" => 25m,
                _ => 0m
            };

            decimal total = BaseFare + (decimal)distance * pricePerKm;

            if (chkNightTariff.Checked)
            {
                total *= 1.2m;
            }

            if (chkChildSeat.Checked)
            {
                total += ChildSeatFee;
            }

            if (string.Equals(txtPromoCode.Text.Trim(), "STUDENT", StringComparison.OrdinalIgnoreCase))
            {
                total *= 0.9m;
            }

            lblResultValue.Text = $"Вартість поїздки: {total:0.00} грн";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDistance.Clear();
            cboTariff.SelectedIndex = -1;
            chkNightTariff.Checked = false;
            chkChildSeat.Checked = false;
            txtPromoCode.Clear();
            lblResultValue.Text = "—";
            txtDistance.Focus();
        }

        private static bool TryParseDistance(string input, out double distance)
        {
            return double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out distance)
                || double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out distance);
        }
    }
}
