using System.Text.Json;

namespace lab3
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MajorsComboBox.Items.Count > 0)
            {
                MajorsComboBox.SelectedIndex = 0;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentName_Click_1(object sender, EventArgs e)
        {
            // handle click if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void StudentSignUpButton_Click(object sender, EventArgs e)
        {
            if (!TryValidateStudent(out var validationMessage))
            {
                MessageBox.Show(validationMessage, "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var students = LoadStudentList();
            students.Add(new StudentInfo
            {
                Name = studentNameBox.Text.Trim(),
                Surname = studentSurnameBox.Text.Trim(),
                MiddleName = studentMiddleNameBox.Text.Trim(),
                Birthday = StudentDateBitrhdayPicker.Value.Date,
                Gender = ManRadioButton.Checked ? "Чоловіча" : "Жіноча",
                Major = MajorsComboBox.SelectedItem?.ToString() ?? string.Empty
            });

            SaveStudents(students);

            var message = string.Join(Environment.NewLine + Environment.NewLine,
                students.Select((student, index) => $"{index + 1}. {student}"));

            MessageBox.Show(message, "Список студентів", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool TryValidateStudent(out string message)
        {
            if (string.IsNullOrWhiteSpace(studentNameBox.Text))
            {
                message = "Введіть ім'я.";
                studentNameBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(studentSurnameBox.Text))
            {
                message = "Введіть прізвище.";
                studentSurnameBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(studentMiddleNameBox.Text))
            {
                message = "Введіть по батькові.";
                studentMiddleNameBox.Focus();
                return false;
            }

            if (!ManRadioButton.Checked && !FemaleRadioButton.Checked)
            {
                message = "Оберіть стать.";
                ManRadioButton.Focus();
                return false;
            }

            if (MajorsComboBox.SelectedIndex < 0)
            {
                message = "Оберіть спеціальність.";
                MajorsComboBox.Focus();
                return false;
            }

            message = string.Empty;
            return true;
        }

        private List<StudentInfo> LoadStudentList()
        {
            var filePath = Path.Combine(AppContext.BaseDirectory, "students.json");

            if (!File.Exists(filePath))
            {
                return new List<StudentInfo>();
            }

            var json = File.ReadAllText(filePath);
            var data = JsonSerializer.Deserialize<AppData>(json);

            if (data?.Students is null || data.Students.Count == 0)
            {
                return new List<StudentInfo>();
            }

            return data.Students;
        }

        private static void SaveStudents(List<StudentInfo> students)
        {
            var filePath = Path.Combine(AppContext.BaseDirectory, "students.json");
            var data = new AppData { Students = students };
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
