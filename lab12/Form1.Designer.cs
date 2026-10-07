namespace lab12;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Label lblSubtitle;
    private GroupBox groupInputs;
    private Label lblAge;
    private ComboBox cmbAge;
    private Label lblSleep;
    private DateTimePicker dtpSleep;
    private Label lblWake;
    private DateTimePicker dtpWake;
    private GroupBox groupResult;
    private Label lblDurationCaption;
    private Label lblDuration;
    private Label lblStatus;
    private Label lblRange;
    private Label lblAdvice;
    private Label lblTip;

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
        groupInputs = new GroupBox();
        lblAge = new Label();
        cmbAge = new ComboBox();
        lblSleep = new Label();
        dtpSleep = new DateTimePicker();
        lblWake = new Label();
        dtpWake = new DateTimePicker();
        groupResult = new GroupBox();
        lblDurationCaption = new Label();
        lblDuration = new Label();
        lblStatus = new Label();
        lblRange = new Label();
        lblAdvice = new Label();
        lblTip = new Label();
        groupInputs.SuspendLayout();
        groupResult.SuspendLayout();
        SuspendLayout();
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(640, 535);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Калькулятор сну";

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
        lblTitle.Location = new Point(36, 28);
        lblTitle.Text = "Калькулятор сну";

        lblSubtitle.AutoSize = true;
        lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
        lblSubtitle.Location = new Point(39, 69);
        lblSubtitle.Text = "Перевірте, чи достатньо часу ви відпочиваєте";

        groupInputs.BackColor = Color.White;
        groupInputs.Controls.Add(lblAge);
        groupInputs.Controls.Add(cmbAge);
        groupInputs.Controls.Add(lblSleep);
        groupInputs.Controls.Add(dtpSleep);
        groupInputs.Controls.Add(lblWake);
        groupInputs.Controls.Add(dtpWake);
        groupInputs.Location = new Point(36, 113);
        groupInputs.Size = new Size(568, 178);
        groupInputs.Text = "Ваш режим сну";

        lblAge.AutoSize = true;
        lblAge.Location = new Point(22, 36);
        lblAge.Text = "Вікова категорія:";

        cmbAge.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbAge.FormattingEnabled = true;
        cmbAge.Location = new Point(220, 32);
        cmbAge.Size = new Size(310, 28);
        cmbAge.SelectedIndexChanged += InputChanged;

        lblSleep.AutoSize = true;
        lblSleep.Location = new Point(22, 78);
        lblSleep.Text = "Час засинання:";

        dtpSleep.Format = DateTimePickerFormat.Custom;
        dtpSleep.CustomFormat = "HH:mm";
        dtpSleep.ShowUpDown = true;
        dtpSleep.Location = new Point(220, 74);
        dtpSleep.Size = new Size(120, 27);
        dtpSleep.ValueChanged += InputChanged;

        lblWake.AutoSize = true;
        lblWake.Location = new Point(22, 120);
        lblWake.Text = "Час пробудження:";

        dtpWake.Format = DateTimePickerFormat.Custom;
        dtpWake.CustomFormat = "HH:mm";
        dtpWake.ShowUpDown = true;
        dtpWake.Location = new Point(220, 116);
        dtpWake.Size = new Size(120, 27);
        dtpWake.ValueChanged += InputChanged;

        groupResult.BackColor = Color.White;
        groupResult.Controls.Add(lblDurationCaption);
        groupResult.Controls.Add(lblDuration);
        groupResult.Controls.Add(lblStatus);
        groupResult.Controls.Add(lblRange);
        groupResult.Controls.Add(lblAdvice);
        groupResult.Location = new Point(36, 311);
        groupResult.Size = new Size(568, 150);
        groupResult.Text = "Результат";

        lblDurationCaption.AutoSize = true;
        lblDurationCaption.ForeColor = Color.FromArgb(107, 114, 128);
        lblDurationCaption.Location = new Point(22, 37);
        lblDurationCaption.Text = "Тривалість сну";

        lblDuration.AutoSize = true;
        lblDuration.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
        lblDuration.ForeColor = Color.FromArgb(31, 41, 55);
        lblDuration.Location = new Point(20, 59);
        lblDuration.Text = "8 год 00 хв";

        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
        lblStatus.Location = new Point(350, 38);
        lblStatus.Text = "Норма";

        lblRange.AutoSize = true;
        lblRange.ForeColor = Color.FromArgb(107, 114, 128);
        lblRange.Location = new Point(350, 68);
        lblRange.Text = "Рекомендовано: 7–9 год";

        lblAdvice.AutoSize = true;
        lblAdvice.ForeColor = Color.FromArgb(75, 85, 99);
        lblAdvice.Location = new Point(22, 113);
        lblAdvice.Text = "Чудово! Тривалість вашого сну відповідає віковій нормі.";

        lblTip.AutoSize = true;
        lblTip.ForeColor = Color.FromArgb(107, 114, 128);
        lblTip.Location = new Point(39, 488);
        lblTip.Text = "Порада: стабільний час сну допомагає прокидатися бадьорішими.";

        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(groupInputs);
        Controls.Add(groupResult);
        Controls.Add(lblTip);
        groupInputs.ResumeLayout(false);
        groupInputs.PerformLayout();
        groupResult.ResumeLayout(false);
        groupResult.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
