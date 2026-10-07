namespace lab12;

public partial class Form1 : Form
{
    private sealed record SleepCategory(string Name, double Minimum, double Maximum);

    private static readonly SleepCategory[] Categories =
    {
        new("Дитина 0–3 роки", 14, 17),
        new("Дошкільнята 4–5 років", 10, 13),
        new("Школярі 6–12 років", 9, 12),
        new("Підлітки 13–17 років", 8, 10),
        new("Дорослі 18–64 роки", 7, 9),
        new("Старші 65 років", 7, 8),
    };

    public Form1()
    {
        InitializeComponent();
        cmbAge.Items.AddRange(Categories.Select(category => category.Name).ToArray());
        cmbAge.SelectedIndex = 4;
        dtpSleep.Value = DateTime.Today.AddHours(23);
        dtpWake.Value = DateTime.Today.AddHours(7);
        CalculateSleep();
    }

    private void InputChanged(object? sender, EventArgs e) => CalculateSleep();

    private void CalculateSleep()
    {
        if (cmbAge.SelectedIndex < 0)
            return;

        var sleepTime = dtpSleep.Value;
        var wakeTime = dtpWake.Value;
        if (wakeTime <= sleepTime)
            wakeTime = wakeTime.AddDays(1);

        var duration = wakeTime - sleepTime;
        var category = Categories[cmbAge.SelectedIndex];
        var hours = duration.TotalHours;

        lblDuration.Text = $"{(int)duration.TotalHours} год {duration.Minutes:00} хв";
        lblRange.Text = $"Рекомендовано: {FormatHours(category.Minimum)}–{FormatHours(category.Maximum)}";

        if (hours < category.Minimum)
        {
            lblStatus.Text = "Недосип";
            lblStatus.ForeColor = Color.FromArgb(234, 88, 12);
            lblAdvice.Text = $"Вам варто додати приблизно {FormatHours(category.Minimum - hours)} сну.";
        }
        else if (hours > category.Maximum)
        {
            lblStatus.Text = "Пересип";
            lblStatus.ForeColor = Color.FromArgb(124, 58, 237);
            lblAdvice.Text = $"Спробуйте скоротити сон приблизно на {FormatHours(hours - category.Maximum)}.";
        }
        else
        {
            lblStatus.Text = "Норма";
            lblStatus.ForeColor = Color.FromArgb(22, 163, 74);
            lblAdvice.Text = "Чудово! Тривалість вашого сну відповідає віковій нормі.";
        }
    }

    private static string FormatHours(double hours)
    {
        var wholeHours = (int)hours;
        var minutes = (int)Math.Round((hours - wholeHours) * 60);
        if (minutes == 60)
        {
            wholeHours++;
            minutes = 0;
        }

        return minutes == 0 ? $"{wholeHours} год" : $"{wholeHours} год {minutes} хв";
    }
}
