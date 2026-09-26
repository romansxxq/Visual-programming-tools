using System.Globalization;

namespace lab5
{
    public partial class Form1 : Form
    {
        private readonly List<(string Name, decimal Price)> subscriptions = new();

        public Form1()
        {
            InitializeComponent();
            UpdateSummary();
        }

        // Accepts both "199.99" and "199,99"
        private static bool TryParseAmount(string text, out decimal value)
        {
            return decimal.TryParse(text.Trim().Replace(',', '.'), NumberStyles.Number,
                CultureInfo.InvariantCulture, out value) && value >= 0;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (name.Length == 0)
            {
                MessageBox.Show("Введіть назву підписки.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (!TryParseAmount(txtPrice.Text, out decimal price) || price == 0)
            {
                MessageBox.Show("Введіть коректну ціну (додатне число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            subscriptions.Add((name, price));
            lstSubscriptions.Items.Add($"{name} — {price:N2} грн");

            txtName.Clear();
            txtPrice.Clear();
            txtName.Focus();
            UpdateSummary();
        }

        private void btnRemove_Click(object? sender, EventArgs e)
        {
            int index = lstSubscriptions.SelectedIndex;
            if (index < 0)
                return;

            subscriptions.RemoveAt(index);
            lstSubscriptions.Items.RemoveAt(index);
            UpdateSummary();
        }

        private void txtSalary_TextChanged(object? sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void UpdateSummary()
        {
            decimal total = subscriptions.Sum(s => s.Price);
            lblTotal.Text = $"Витрати на місяць: {total:N2} грн";

            if (!TryParseAmount(txtSalary.Text, out decimal salary))
            {
                lblRemaining.Text = "Залишиться: введіть зарплату";
                lblRemaining.ForeColor = SystemColors.ControlText;
                return;
            }

            decimal remaining = salary - total;
            lblRemaining.Text = $"Залишиться: {remaining:N2} грн";
            lblRemaining.ForeColor = remaining < 0 ? Color.Firebrick : Color.ForestGreen;
        }
    }
}
