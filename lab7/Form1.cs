using System.Globalization;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace lab7
{
    public partial class Form1 : Form
    {
        private static readonly string[] IncomeCategories =
        {
            "Зарплата", "Стипендія", "Фріланс", "Подарунки", "Відсотки за вкладом", "Інше"
        };

        private static readonly string[] ExpenseCategories =
        {
            "Продукти", "Транспорт", "Комунальні послуги", "Зв'язок та інтернет",
            "Розваги", "Одяг", "Здоров'я", "Навчання", "Інше"
        };

        // Перші пункти фільтра — за типом, далі — за категоріями
        private const string FilterAll = "Усі операції";
        private const string FilterIncome = "Лише доходи";
        private const string FilterExpense = "Лише витрати";

        private static readonly CultureInfo Uk = CultureInfo.GetCultureInfo("uk-UA");

        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            Converters = { new JsonStringEnumConverter() }
        };

        private static readonly string DefaultFile = Path.Combine(AppContext.BaseDirectory, "transactions.json");

        private List<Transaction> transactions = new();
        private string currentFile = DefaultFile;

        public Form1()
        {
            InitializeComponent();

            cmbType.SelectedIndex = 0;

            cmbFilter.Items.Add(FilterAll);
            cmbFilter.Items.Add(FilterIncome);
            cmbFilter.Items.Add(FilterExpense);
            foreach (var category in IncomeCategories.Concat(ExpenseCategories).Distinct())
                cmbFilter.Items.Add(category);
            cmbFilter.SelectedIndex = 0;

            if (File.Exists(DefaultFile))
                LoadFromFile(DefaultFile, showErrors: false);

            RefreshView();
        }

        private OperationType SelectedType =>
            cmbType.SelectedIndex == 0 ? OperationType.Income : OperationType.Expense;

        private void cmbType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(SelectedType == OperationType.Income ? IncomeCategories : ExpenseCategories);
            cmbCategory.SelectedIndex = 0;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Вкажіть суму більшу за нуль.", "Помилка введення",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numAmount.Focus();
                return;
            }

            transactions.Add(new Transaction
            {
                Date = dtpDate.Value.Date,
                Type = SelectedType,
                Category = (string)cmbCategory.SelectedItem!,
                Amount = numAmount.Value,
                Description = txtDescription.Text.Trim()
            });

            numAmount.Value = 0;
            txtDescription.Clear();
            RefreshView();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvOperations.CurrentRow?.DataBoundItem is not Transaction selected)
            {
                MessageBox.Show("Виберіть операцію у таблиці.", "Видалення",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var answer = MessageBox.Show(
                $"Видалити операцію «{selected.Category}» на суму {selected.Amount.ToString("N2", Uk)} грн?",
                "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes)
                return;

            transactions.Remove(selected);
            RefreshView();
        }

        private void cmbFilter_SelectedIndexChanged(object? sender, EventArgs e) => RefreshView();

        private IEnumerable<Transaction> ApplyFilter(IEnumerable<Transaction> source)
        {
            return (cmbFilter.SelectedItem as string) switch
            {
                null or FilterAll => source,
                FilterIncome => source.Where(t => t.Type == OperationType.Income),
                FilterExpense => source.Where(t => t.Type == OperationType.Expense),
                var category => source.Where(t => t.Category == category)
            };
        }

        private void RefreshView()
        {
            var visible = ApplyFilter(transactions)
                .OrderByDescending(t => t.Date)
                .ToList();

            dgvOperations.DataSource = visible;

            decimal income = visible.Where(t => t.Type == OperationType.Income).Sum(t => t.Amount);
            decimal expense = visible.Where(t => t.Type == OperationType.Expense).Sum(t => t.Amount);
            decimal balance = income - expense;

            lblIncome.Text = FormatMoney(income);
            lblExpense.Text = FormatMoney(expense);
            lblBalance.Text = FormatMoney(balance);
            lblBalance.ForeColor = balance >= 0 ? Color.ForestGreen : Color.Firebrick;

            decimal totalBalance = transactions.Sum(t => t.Type == OperationType.Income ? t.Amount : -t.Amount);
            lblStatus.Text = $"Показано операцій: {visible.Count} з {transactions.Count}   |   " +
                             $"Загальний баланс: {FormatMoney(totalBalance)}   |   Файл: {Path.GetFileName(currentFile)}";
        }

        private static string FormatMoney(decimal value) => value.ToString("N2", Uk) + " грн";

        private void dgvOperations_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvOperations.Rows[e.RowIndex].DataBoundItem is not Transaction t)
                return;

            if (e.ColumnIndex == colAmount.Index || e.ColumnIndex == colType.Index)
            {
                e.CellStyle!.ForeColor = t.Type == OperationType.Income ? Color.ForestGreen : Color.Firebrick;
            }
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                Filter = "JSON файли (*.json)|*.json|Усі файли (*.*)|*.*",
                FileName = Path.GetFileName(currentFile),
                InitialDirectory = Path.GetDirectoryName(currentFile)
            };
            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            if (SaveToFile(dialog.FileName))
            {
                currentFile = dialog.FileName;
                RefreshView();
                MessageBox.Show("Дані збережено.", "Збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoad_Click(object? sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "JSON файли (*.json)|*.json|Усі файли (*.*)|*.*",
                InitialDirectory = Path.GetDirectoryName(currentFile)
            };
            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            if (LoadFromFile(dialog.FileName, showErrors: true))
            {
                cmbFilter.SelectedIndex = 0;
                RefreshView();
            }
        }

        private bool SaveToFile(string path)
        {
            try
            {
                File.WriteAllText(path, JsonSerializer.Serialize(transactions, JsonOptions));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося зберегти файл:\n{ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool LoadFromFile(string path, bool showErrors)
        {
            try
            {
                transactions = JsonSerializer.Deserialize<List<Transaction>>(File.ReadAllText(path), JsonOptions) ?? new();
                currentFile = path;
                return true;
            }
            catch (Exception ex)
            {
                if (showErrors)
                    MessageBox.Show($"Не вдалося відкрити файл:\n{ex.Message}", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Автозбереження у поточний файл при закритті програми
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!SaveToFile(currentFile))
            {
                var answer = MessageBox.Show("Дані не збережено. Все одно закрити програму?", "Вихід",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                e.Cancel = answer != DialogResult.Yes;
            }
        }
    }
}
