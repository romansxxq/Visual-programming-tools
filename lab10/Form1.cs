using System.Globalization;

namespace lab10
{
    public partial class Form1 : Form
    {
        private record Payment(int Month, decimal Amount, decimal Principal, decimal Interest, decimal Balance);

        private static readonly CultureInfo Uk = CultureInfo.GetCultureInfo("uk-UA");

        private readonly bool _initialized;
        private readonly Font _boldFont;

        public Form1()
        {
            InitializeComponent();
            _boldFont = new Font(dataGridSchedule.Font, FontStyle.Bold);
            ConfigureGrid();
            _initialized = true;
            Calculate();
        }

        private void btnCalculate_Click(object? sender, EventArgs e) => Calculate();

        private void Input_Changed(object? sender, EventArgs e) => Calculate();

        private void btnReset_Click(object? sender, EventArgs e)
        {
            numAmount.Value = 100000;
            numRate.Value = 18;
            numTerm.Value = 12;
            Calculate();
        }

        private void ConfigureGrid()
        {
            colMonth.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (var column in new[] { colPayment, colPrincipal, colInterest, colBalance })
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                column.DefaultCellStyle.Format = "N2";
                column.DefaultCellStyle.FormatProvider = Uk;
            }
            dataGridSchedule.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridSchedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 252);
        }

        private void Calculate()
        {
            // Події ValueChanged спрацьовують ще всередині InitializeComponent
            if (!_initialized)
                return;

            decimal amount = numAmount.Value;
            decimal annualRate = numRate.Value;
            int months = (int)numTerm.Value;

            var schedule = BuildSchedule(amount, annualRate, months);

            decimal totalPaid = schedule.Sum(p => p.Amount);
            decimal totalInterest = schedule.Sum(p => p.Interest);

            FillGrid(schedule, totalPaid, amount, totalInterest);

            lblPayment.Text = Money(schedule[0].Amount);
            lblTotal.Text = Money(totalPaid);
            lblOverpay.Text = Money(totalInterest);
            lblOverpayPercent.Text = (totalInterest / amount * 100).ToString("N2", Uk) + " %";
        }

        // Ануїтет: A = S · i / (1 − (1 + i)^−n), де i — місячна ставка.
        // Платіж округлюється до копійок, а останній платіж коригується так,
        // щоб залишок боргу став рівно нульовим.
        private static List<Payment> BuildSchedule(decimal amount, decimal annualRate, int months)
        {
            decimal monthlyRate = annualRate / 12m / 100m;

            decimal annuity;
            if (monthlyRate == 0)
            {
                annuity = amount / months;
            }
            else
            {
                decimal growth = 1m;
                for (int i = 0; i < months; i++)
                    growth *= 1m + monthlyRate;
                annuity = amount * monthlyRate * growth / (growth - 1m);
            }
            annuity = Round(annuity);

            var schedule = new List<Payment>(months);
            decimal balance = amount;
            for (int month = 1; month <= months; month++)
            {
                decimal interest = Round(balance * monthlyRate);
                decimal principal = month == months ? balance : annuity - interest;
                balance -= principal;
                schedule.Add(new Payment(month, principal + interest, principal, interest, balance));
            }
            return schedule;
        }

        private void FillGrid(List<Payment> schedule, decimal totalPaid, decimal totalPrincipal, decimal totalInterest)
        {
            dataGridSchedule.SuspendLayout();
            dataGridSchedule.Rows.Clear();

            foreach (var p in schedule)
                dataGridSchedule.Rows.Add(p.Month, p.Amount, p.Principal, p.Interest, p.Balance);

            int totalIndex = dataGridSchedule.Rows.Add("Разом", totalPaid, totalPrincipal, totalInterest, "");
            var totalRow = dataGridSchedule.Rows[totalIndex];
            totalRow.DefaultCellStyle.Font = _boldFont;
            totalRow.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205);
            totalRow.Cells[colInterest.Index].Style.ForeColor = Color.Firebrick;

            dataGridSchedule.ResumeLayout();
        }

        private static decimal Round(decimal value) => Math.Round(value, 2, MidpointRounding.AwayFromZero);

        private static string Money(decimal value) => value.ToString("N2", Uk) + " грн";
    }
}
