namespace lab1;

partial class Form1
{
    private Label firstNumberLabel;
    private Label secondNumberLabel;
    private Label thirdNumberLabel;
    private TextBox firstNumberTextBox;
    private TextBox secondNumberTextBox;
    private TextBox thirdNumberTextBox;
    private Button calculateButton;
    private Label resultLabel;
    private Label resultText;

    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        firstNumberLabel = new Label();
        secondNumberLabel = new Label();
        thirdNumberLabel = new Label();
        firstNumberTextBox = new TextBox();
        secondNumberTextBox = new TextBox();
        thirdNumberTextBox = new TextBox();
        calculateButton = new Button();
        resultText = new Label();
        resultLabel = new Label();
        SuspendLayout();

        firstNumberLabel.AutoSize = true;
        firstNumberLabel.Location = new Point(35, 35);
        firstNumberLabel.Text = "First number:";

        secondNumberLabel.AutoSize = true;
        secondNumberLabel.Location = new Point(35, 85);
        secondNumberLabel.Text = "Second number:";

        thirdNumberLabel.AutoSize = true;
        thirdNumberLabel.Location = new Point(35, 135);
        thirdNumberLabel.Text = "Third number:";

        firstNumberTextBox.Location = new Point(170, 32);
        firstNumberTextBox.Size = new Size(180, 23);

        secondNumberTextBox.Location = new Point(170, 82);
        secondNumberTextBox.Size = new Size(180, 23);

        thirdNumberTextBox.Location = new Point(170, 132);
        thirdNumberTextBox.Size = new Size(180, 23);

        calculateButton.Location = new Point(35, 185);
        calculateButton.Size = new Size(315, 35);
        calculateButton.Text = "Perform three operations";
        calculateButton.UseVisualStyleBackColor = true;
        calculateButton.Click += CalculateButton_Click;

        resultLabel.AutoSize = true;
        resultLabel.Location = new Point(35, 250);
        resultText.AutoSize = true;
        resultText.Location = new Point(35, 220);
        resultText.Text = "Results:";
        resultLabel.Text = "";

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(420, 340);
        Controls.Add(firstNumberLabel);
        Controls.Add(secondNumberLabel);
        Controls.Add(thirdNumberLabel);
        Controls.Add(firstNumberTextBox);
        Controls.Add(secondNumberTextBox);
        Controls.Add(thirdNumberTextBox);
        Controls.Add(calculateButton);
        Controls.Add(resultText);
        Controls.Add(resultLabel);
        Text = "Lab1: Calculator";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
