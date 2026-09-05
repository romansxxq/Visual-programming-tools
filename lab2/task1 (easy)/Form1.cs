namespace task1__easy_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxWeight.Text, out double weight) || weight <= 0)
            {
                MessageBox.Show("Введіть коректні дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(textBoxHeight.Text, out double heightCm) || heightCm <= 0)
            {
                MessageBox.Show("Введіть коректні дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double heightMeters = heightCm / 100.0;
            double bmi = weight / (heightMeters * heightMeters);
            string status;
            Color color;
            if (bmi < 18.5)
            {
                status = "Недостатня вага";
                color = Color.Blue;
            }
            else if (bmi < 25)
            {
                status = "Норма";
                color = Color.Green;
            }
            else if (bmi < 30)
            {
                status = "Надмірна вага";
                color = Color.Goldenrod;
            }
            else
            {
                status = "Ожиріння";
                color = Color.Red;
            }
            labelValue.Text = $"ІМТ: {bmi:F1} ({status})";
            labelValue.ForeColor = color;
        }
    }
}
