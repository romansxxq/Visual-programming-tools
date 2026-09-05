using System.Globalization;

namespace task2_medium
{
    public partial class Form1 : Form
    {
        private sealed record UtilityItem(string Name, TextBox MeterBox, TextBox TariffBox);

        public Form1()
        {
            InitializeComponent();
            ConfigureGrid();
            calculateButton.Click += CalculateButton_Click;
        }

        private void ConfigureGrid()
        {
            resultGrid.Columns.Clear();
            resultGrid.Columns.Add("Resource", "Ресурс");
            resultGrid.Columns.Add("Reading", "Показники");
            resultGrid.Columns.Add("Tariff", "Тариф");
            resultGrid.Columns.Add("Amount", "Сума");
        }

        private void CalculateButton_Click(object? sender, EventArgs e)
        {
            var items = new[]
            {
                new UtilityItem("Вода", waterTextBox, waterTariffTextBox),
                new UtilityItem("Світло", electricityTextBox, electricityTariffTextBox),
                new UtilityItem("Газ", gasTextBox, gasTariffTextBox)
            };

            resultGrid.Rows.Clear();

            decimal total = 0;
            foreach (var item in items)
            {
                if (!TryReadNonNegativeDecimal(item.MeterBox, $"показники для {item.Name}", out var reading))
                {
                    return;
                }

                if (!TryReadNonNegativeDecimal(item.TariffBox, $"тариф для {item.Name}", out var tariff))
                {
                    return;
                }

                var amount = reading * tariff;
                total += amount;
                resultGrid.Rows.Add(item.Name, reading.ToString("0.##", CultureInfo.CurrentCulture), tariff.ToString("0.##", CultureInfo.CurrentCulture), amount.ToString("0.##", CultureInfo.CurrentCulture));
            }

            resultGrid.Rows.Add("Разом", string.Empty, string.Empty, total.ToString("0.##", CultureInfo.CurrentCulture));
        }

        private static bool TryReadNonNegativeDecimal(TextBox textBox, string fieldName, out decimal value)
        {
            var text = textBox.Text.Trim();
            if (decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out value) ||
                decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out value))
            {
                if (value >= 0)
                {
                    return true;
                }
            }

            MessageBox.Show($"Введіть коректне невід'ємне число для {fieldName}.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox.Focus();
            textBox.SelectAll();
            value = 0;
            return false;
        }
    }
}
