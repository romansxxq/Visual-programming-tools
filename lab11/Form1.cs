using System.Security.Cryptography;

namespace lab11;

public partial class Form1 : Form
{
    private const string Lowercase = "abcdefghijkmnopqrstuvwxyz";
    private const string Uppercase = "ABCDEFGHJKLMNPQRSTUVWXYZ";
    private const string Digits = "23456789";
    private const string Special = "!@#$%&*+-=?";

    public Form1()
    {
        InitializeComponent();
        GeneratePassword();
    }

    private void btnGenerate_Click(object? sender, EventArgs e) => GeneratePassword();

    private void GeneratePassword()
    {
        var characterSets = new List<string> { Lowercase };
        if (chkUppercase.Checked)
            characterSets.Add(Uppercase);
        if (chkDigits.Checked)
            characterSets.Add(Digits);
        if (chkSpecial.Checked)
            characterSets.Add(Special);

        if (numLength.Value < characterSets.Count)
        {
            MessageBox.Show(
                $"Для вибраних категорій потрібна довжина не менше {characterSets.Count}.",
                "Збільште довжину",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        var allCharacters = string.Concat(characterSets);
        var password = new List<char>();

        foreach (var characterSet in characterSets)
            password.Add(characterSet[RandomNumberGenerator.GetInt32(characterSet.Length)]);

        while (password.Count < (int)numLength.Value)
            password.Add(allCharacters[RandomNumberGenerator.GetInt32(allCharacters.Length)]);

        Shuffle(password);
        txtPassword.Text = new string(password.ToArray());
        lblStrength.Text = GetStrengthLabel(characterSets.Count, (int)numLength.Value);
        lblStrength.ForeColor = GetStrengthColor(characterSets.Count, (int)numLength.Value);
    }

    private static void Shuffle(List<char> characters)
    {
        for (var i = characters.Count - 1; i > 0; i--)
        {
            var j = RandomNumberGenerator.GetInt32(i + 1);
            (characters[i], characters[j]) = (characters[j], characters[i]);
        }
    }

    private string GetStrengthLabel(int categories, int length) =>
        length >= 16 && categories >= 4 ? "● Дуже надійний" :
        length >= 12 && categories >= 3 ? "● Надійний" :
        length >= 8 && categories >= 2 ? "● Середній" :
        "● Слабкий";

    private static Color GetStrengthColor(int categories, int length) =>
        length >= 16 && categories >= 4 ? Color.FromArgb(34, 197, 94) :
        length >= 12 && categories >= 3 ? Color.FromArgb(59, 130, 246) :
        length >= 8 && categories >= 2 ? Color.FromArgb(245, 158, 11) :
        Color.FromArgb(239, 68, 68);

    private void btnCopy_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtPassword.Text))
            return;

        Clipboard.SetText(txtPassword.Text);
        lblCopied.Text = "✓ Скопійовано";
        lblCopied.Visible = true;
        copyTimer.Start();
    }

    private void copyTimer_Tick(object? sender, EventArgs e)
    {
        copyTimer.Stop();
        lblCopied.Visible = false;
    }
}
