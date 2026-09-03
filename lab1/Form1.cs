namespace lab1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void CalculateButton_Click(object? sender, EventArgs e)
    {
        if (!double.TryParse(firstNumberTextBox.Text, out var firstNumber) ||
            !double.TryParse(secondNumberTextBox.Text, out var secondNumber) ||
            !double.TryParse(thirdNumberTextBox.Text, out var thirdNumber))
        {
            MessageBox.Show(
                "Enter three valid numbers.",
                "Input error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var sum = firstNumber + secondNumber + thirdNumber;
        var product = firstNumber * secondNumber * thirdNumber;
        var average = sum / 3;
        resultLabel.Text = $"Sum: {sum:G}\nProduct: {product:G}\nAverage: {average:G}";
    }
}
