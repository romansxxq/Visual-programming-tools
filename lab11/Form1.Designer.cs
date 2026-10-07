namespace lab11;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Label lblSubtitle;
    private GroupBox groupOptions;
    private Label lblLength;
    private NumericUpDown numLength;
    private CheckBox chkUppercase;
    private CheckBox chkDigits;
    private CheckBox chkSpecial;
    private Label lblHint;
    private GroupBox groupResult;
    private TextBox txtPassword;
    private Button btnCopy;
    private Button btnGenerate;
    private Label lblStrength;
    private Label lblCopied;
    private System.Windows.Forms.Timer copyTimer;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblTitle = new Label();
        lblSubtitle = new Label();
        groupOptions = new GroupBox();
        lblLength = new Label();
        numLength = new NumericUpDown();
        chkUppercase = new CheckBox();
        chkDigits = new CheckBox();
        chkSpecial = new CheckBox();
        lblHint = new Label();
        groupResult = new GroupBox();
        txtPassword = new TextBox();
        btnCopy = new Button();
        btnGenerate = new Button();
        lblStrength = new Label();
        lblCopied = new Label();
        copyTimer = new System.Windows.Forms.Timer(components);
        groupOptions.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numLength).BeginInit();
        groupResult.SuspendLayout();
        SuspendLayout();
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(640, 520);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Генератор надійних паролів";

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
        lblTitle.Location = new Point(36, 28);
        lblTitle.Text = "Генератор паролів";

        lblSubtitle.AutoSize = true;
        lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
        lblSubtitle.Location = new Point(39, 69);
        lblSubtitle.Text = "Створіть унікальний пароль за кілька секунд";

        groupOptions.BackColor = Color.White;
        groupOptions.Controls.Add(lblLength);
        groupOptions.Controls.Add(numLength);
        groupOptions.Controls.Add(chkUppercase);
        groupOptions.Controls.Add(chkDigits);
        groupOptions.Controls.Add(chkSpecial);
        groupOptions.Controls.Add(lblHint);
        groupOptions.Location = new Point(36, 113);
        groupOptions.Size = new Size(568, 180);
        groupOptions.Text = "Налаштування";

        lblLength.AutoSize = true;
        lblLength.Location = new Point(22, 36);
        lblLength.Text = "Довжина пароля:";

        numLength.Location = new Point(180, 32);
        numLength.Maximum = 64;
        numLength.Minimum = 4;
        numLength.Size = new Size(80, 27);
        numLength.Value = 14;

        chkUppercase.AutoSize = true;
        chkUppercase.Checked = true;
        chkUppercase.Location = new Point(22, 78);
        chkUppercase.Text = "Великі літери (A-Z)";
        chkUppercase.UseVisualStyleBackColor = true;

        chkDigits.AutoSize = true;
        chkDigits.Checked = true;
        chkDigits.Location = new Point(220, 78);
        chkDigits.Text = "Цифри (0-9)";
        chkDigits.UseVisualStyleBackColor = true;

        chkSpecial.AutoSize = true;
        chkSpecial.Location = new Point(350, 78);
        chkSpecial.Text = "Спецсимволи";
        chkSpecial.UseVisualStyleBackColor = true;

        lblHint.AutoSize = true;
        lblHint.ForeColor = Color.FromArgb(107, 114, 128);
        lblHint.Location = new Point(22, 125);
        lblHint.Text = "Малі літери додаються автоматично для кращої читабельності";

        groupResult.BackColor = Color.White;
        groupResult.Controls.Add(txtPassword);
        groupResult.Controls.Add(btnCopy);
        groupResult.Controls.Add(lblStrength);
        groupResult.Controls.Add(lblCopied);
        groupResult.Location = new Point(36, 313);
        groupResult.Size = new Size(568, 115);
        groupResult.Text = "Ваш пароль";

        txtPassword.BackColor = Color.FromArgb(249, 250, 251);
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Font = new Font("Consolas", 16F, FontStyle.Bold);
        txtPassword.Location = new Point(22, 38);
        txtPassword.ReadOnly = true;
        txtPassword.Size = new Size(365, 32);
        txtPassword.TabStop = false;

        btnCopy.BackColor = Color.FromArgb(239, 246, 255);
        btnCopy.FlatStyle = FlatStyle.Flat;
        btnCopy.ForeColor = Color.FromArgb(37, 99, 235);
        btnCopy.Location = new Point(402, 37);
        btnCopy.Size = new Size(135, 35);
        btnCopy.Text = "Копіювати";
        btnCopy.UseVisualStyleBackColor = false;
        btnCopy.Click += btnCopy_Click;

        lblStrength.AutoSize = true;
        lblStrength.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblStrength.Location = new Point(22, 80);
        lblCopied.AutoSize = true;
        lblCopied.ForeColor = Color.FromArgb(34, 197, 94);
        lblCopied.Location = new Point(402, 83);
        lblCopied.Text = "✓ Скопійовано";
        lblCopied.Visible = false;

        btnGenerate.BackColor = Color.FromArgb(37, 99, 235);
        btnGenerate.FlatStyle = FlatStyle.Flat;
        btnGenerate.FlatAppearance.BorderSize = 0;
        btnGenerate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        btnGenerate.ForeColor = Color.White;
        btnGenerate.Location = new Point(36, 452);
        btnGenerate.Size = new Size(568, 44);
        btnGenerate.Text = "Згенерувати новий пароль";
        btnGenerate.UseVisualStyleBackColor = false;
        btnGenerate.Click += btnGenerate_Click;

        copyTimer.Interval = 1800;
        copyTimer.Tick += copyTimer_Tick;

        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(groupOptions);
        Controls.Add(groupResult);
        Controls.Add(btnGenerate);
        groupOptions.ResumeLayout(false);
        groupOptions.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numLength).EndInit();
        groupResult.ResumeLayout(false);
        groupResult.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
