namespace lab13;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Label lblSubtitle;
    private GroupBox groupHall;
    private Label lblScreen;
    private TableLayoutPanel seatsTable;
    private GroupBox groupSummary;
    private Label lblSelected;
    private Label lblTotalCaption;
    private Label lblTotal;
    private Button btnClear;
    private Panel pnlFree;
    private Panel pnlChosen;
    private Label lblFree;
    private Label lblChosen;
    private Label lblPrice;

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
        groupHall = new GroupBox();
        lblScreen = new Label();
        seatsTable = new TableLayoutPanel();
        groupSummary = new GroupBox();
        lblSelected = new Label();
        lblTotalCaption = new Label();
        lblTotal = new Label();
        btnClear = new Button();
        pnlFree = new Panel();
        pnlChosen = new Panel();
        lblFree = new Label();
        lblChosen = new Label();
        lblPrice = new Label();
        groupHall.SuspendLayout();
        groupSummary.SuspendLayout();
        SuspendLayout();
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(710, 650);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Схема залу";

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
        lblTitle.Location = new Point(38, 27);
        lblTitle.Text = "Оберіть місця";

        lblSubtitle.AutoSize = true;
        lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
        lblSubtitle.Location = new Point(41, 68);
        lblSubtitle.Text = "Натисніть на місце, щоб додати його до замовлення";

        groupHall.BackColor = Color.White;
        groupHall.Controls.Add(lblScreen);
        groupHall.Controls.Add(seatsTable);
        groupHall.Location = new Point(38, 106);
        groupHall.Size = new Size(634, 365);
        groupHall.Text = "Зала 1  •  Прем'єрний показ";

        lblScreen.BackColor = Color.FromArgb(229, 231, 235);
        lblScreen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblScreen.ForeColor = Color.FromArgb(75, 85, 99);
        lblScreen.Location = new Point(93, 31);
        lblScreen.Size = new Size(448, 27);
        lblScreen.Text = "ЕКРАН";
        lblScreen.TextAlign = ContentAlignment.MiddleCenter;

        seatsTable.ColumnCount = 8;
        seatsTable.RowCount = 6;
        seatsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        seatsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
        for (var i = 0; i < 6; i++)
            seatsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        seatsTable.Location = new Point(63, 72);
        seatsTable.Size = new Size(508, 270);
        seatsTable.TabIndex = 0;

        groupSummary.BackColor = Color.White;
        groupSummary.Controls.Add(lblSelected);
        groupSummary.Controls.Add(lblTotalCaption);
        groupSummary.Controls.Add(lblTotal);
        groupSummary.Controls.Add(btnClear);
        groupSummary.Controls.Add(pnlFree);
        groupSummary.Controls.Add(pnlChosen);
        groupSummary.Controls.Add(lblFree);
        groupSummary.Controls.Add(lblChosen);
        groupSummary.Controls.Add(lblPrice);
        groupSummary.Location = new Point(38, 489);
        groupSummary.Size = new Size(634, 128);
        groupSummary.Text = "Ваше замовлення";

        lblSelected.AutoSize = true;
        lblSelected.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        lblSelected.ForeColor = Color.FromArgb(31, 41, 55);
        lblSelected.Location = new Point(20, 31);
        lblSelected.Text = "Місця не обрано";

        lblTotalCaption.AutoSize = true;
        lblTotalCaption.ForeColor = Color.FromArgb(107, 114, 128);
        lblTotalCaption.Location = new Point(20, 65);
        lblTotalCaption.Text = "До сплати:";

        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
        lblTotal.ForeColor = Color.FromArgb(37, 99, 235);
        lblTotal.Location = new Point(105, 59);
        lblTotal.Text = "0 грн";

        btnClear.BackColor = Color.FromArgb(249, 250, 251);
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.ForeColor = Color.FromArgb(75, 85, 99);
        btnClear.Location = new Point(459, 30);
        btnClear.Size = new Size(145, 34);
        btnClear.Text = "Очистити вибір";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;

        pnlFree.BackColor = Color.FromArgb(220, 252, 231);
        pnlFree.Location = new Point(255, 70);
        pnlFree.Size = new Size(14, 14);
        pnlChosen.BackColor = Color.FromArgb(37, 99, 235);
        pnlChosen.Location = new Point(363, 70);
        pnlChosen.Size = new Size(14, 14);
        lblFree.AutoSize = true;
        lblFree.ForeColor = Color.FromArgb(75, 85, 99);
        lblFree.Location = new Point(275, 67);
        lblFree.Text = "Вільне";
        lblChosen.AutoSize = true;
        lblChosen.ForeColor = Color.FromArgb(75, 85, 99);
        lblChosen.Location = new Point(383, 67);
        lblChosen.Text = "Обране";
        lblPrice.AutoSize = true;
        lblPrice.ForeColor = Color.FromArgb(107, 114, 128);
        lblPrice.Location = new Point(255, 94);
        lblPrice.Text = "Вартість одного місця: 180 грн";

        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(groupHall);
        Controls.Add(groupSummary);
        groupHall.ResumeLayout(false);
        groupSummary.ResumeLayout(false);
        groupSummary.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
