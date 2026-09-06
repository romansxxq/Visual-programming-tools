namespace lab3
{
    public partial class Form2 : Form
    {
        public Form2(IEnumerable<StudentInfo> students)
        {
            InitializeComponent();
            listBox1.DataSource = students.ToList();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
