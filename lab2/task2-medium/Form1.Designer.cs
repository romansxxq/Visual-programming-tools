namespace task2_medium
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel mainLayout;
        private Label titleLabel;
        private GroupBox inputGroup;
        private TableLayoutPanel inputLayout;
        private Label waterLabel;
        private Label electricityLabel;
        private Label gasLabel;
        private Label waterTariffLabel;
        private Label electricityTariffLabel;
        private Label gasTariffLabel;
        private TextBox waterTextBox;
        private TextBox electricityTextBox;
        private TextBox gasTextBox;
        private TextBox waterTariffTextBox;
        private TextBox electricityTariffTextBox;
        private TextBox gasTariffTextBox;
        private Button calculateButton;
        private DataGridView resultGrid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            titleLabel = new Label();
            inputGroup = new GroupBox();
            inputLayout = new TableLayoutPanel();
            waterLabel = new Label();
            electricityLabel = new Label();
            gasLabel = new Label();
            waterTariffLabel = new Label();
            electricityTariffLabel = new Label();
            gasTariffLabel = new Label();
            waterTextBox = new TextBox();
            electricityTextBox = new TextBox();
            gasTextBox = new TextBox();
            waterTariffTextBox = new TextBox();
            electricityTariffTextBox = new TextBox();
            gasTariffTextBox = new TextBox();
            calculateButton = new Button();
            resultGrid = new DataGridView();
            mainLayout.SuspendLayout();
            inputGroup.SuspendLayout();
            inputLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultGrid).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(titleLabel, 0, 0);
            mainLayout.Controls.Add(inputGroup, 0, 1);
            mainLayout.Controls.Add(calculateButton, 0, 2);
            mainLayout.Controls.Add(resultGrid, 0, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(10, 9);
            mainLayout.Margin = new Padding(3, 2, 3, 2);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 158F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(844, 478);
            mainLayout.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.Location = new Point(3, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(838, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Розрахунок комунальних платежів";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputGroup
            // 
            inputGroup.Controls.Add(inputLayout);
            inputGroup.Dock = DockStyle.Fill;
            inputGroup.Location = new Point(3, 34);
            inputGroup.Margin = new Padding(3, 2, 3, 2);
            inputGroup.Name = "inputGroup";
            inputGroup.Padding = new Padding(3, 2, 3, 2);
            inputGroup.Size = new Size(838, 154);
            inputGroup.TabIndex = 1;
            inputGroup.TabStop = false;
            inputGroup.Text = "Введення показників та тарифів";
            // 
            // inputLayout
            // 
            inputLayout.ColumnCount = 3;
            inputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            inputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
            inputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
            inputLayout.Controls.Add(waterLabel, 0, 0);
            inputLayout.Controls.Add(electricityLabel, 0, 1);
            inputLayout.Controls.Add(gasLabel, 0, 2);
            inputLayout.Controls.Add(waterTariffLabel, 0, 3);
            inputLayout.Controls.Add(electricityTariffLabel, 0, 4);
            inputLayout.Controls.Add(gasTariffLabel, 0, 5);
            inputLayout.Controls.Add(waterTextBox, 1, 0);
            inputLayout.Controls.Add(electricityTextBox, 1, 1);
            inputLayout.Controls.Add(gasTextBox, 1, 2);
            inputLayout.Controls.Add(waterTariffTextBox, 1, 3);
            inputLayout.Controls.Add(electricityTariffTextBox, 1, 4);
            inputLayout.Controls.Add(gasTariffTextBox, 1, 5);
            inputLayout.Dock = DockStyle.Fill;
            inputLayout.Location = new Point(3, 18);
            inputLayout.Margin = new Padding(3, 2, 3, 2);
            inputLayout.Name = "inputLayout";
            inputLayout.RowCount = 6;
            inputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            inputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            inputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            inputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            inputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            inputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            inputLayout.Size = new Size(832, 134);
            inputLayout.TabIndex = 0;
            // 
            // waterLabel
            // 
            waterLabel.Dock = DockStyle.Fill;
            waterLabel.Location = new Point(3, 0);
            waterLabel.Name = "waterLabel";
            waterLabel.Size = new Size(285, 22);
            waterLabel.TabIndex = 0;
            waterLabel.Text = "Вода, м³";
            waterLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // electricityLabel
            // 
            electricityLabel.Dock = DockStyle.Fill;
            electricityLabel.Location = new Point(3, 22);
            electricityLabel.Name = "electricityLabel";
            electricityLabel.Size = new Size(285, 22);
            electricityLabel.TabIndex = 1;
            electricityLabel.Text = "Світло, кВт-год";
            electricityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gasLabel
            // 
            gasLabel.Dock = DockStyle.Fill;
            gasLabel.Location = new Point(3, 44);
            gasLabel.Name = "gasLabel";
            gasLabel.Size = new Size(285, 22);
            gasLabel.TabIndex = 2;
            gasLabel.Text = "Газ, м³";
            gasLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // waterTariffLabel
            // 
            waterTariffLabel.Dock = DockStyle.Fill;
            waterTariffLabel.Location = new Point(3, 66);
            waterTariffLabel.Name = "waterTariffLabel";
            waterTariffLabel.Size = new Size(285, 22);
            waterTariffLabel.TabIndex = 3;
            waterTariffLabel.Text = "Тариф на воду";
            waterTariffLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // electricityTariffLabel
            // 
            electricityTariffLabel.Dock = DockStyle.Fill;
            electricityTariffLabel.Location = new Point(3, 88);
            electricityTariffLabel.Name = "electricityTariffLabel";
            electricityTariffLabel.Size = new Size(285, 22);
            electricityTariffLabel.TabIndex = 4;
            electricityTariffLabel.Text = "Тариф на світло";
            electricityTariffLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gasTariffLabel
            // 
            gasTariffLabel.Dock = DockStyle.Fill;
            gasTariffLabel.Location = new Point(3, 110);
            gasTariffLabel.Name = "gasTariffLabel";
            gasTariffLabel.Size = new Size(285, 24);
            gasTariffLabel.TabIndex = 5;
            gasTariffLabel.Text = "Тариф на газ";
            gasTariffLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // waterTextBox
            // 
            waterTextBox.Dock = DockStyle.Fill;
            waterTextBox.Location = new Point(294, 2);
            waterTextBox.Margin = new Padding(3, 2, 3, 2);
            waterTextBox.Name = "waterTextBox";
            waterTextBox.PlaceholderText = "0";
            waterTextBox.Size = new Size(264, 23);
            waterTextBox.TabIndex = 6;
            // 
            // electricityTextBox
            // 
            electricityTextBox.Dock = DockStyle.Fill;
            electricityTextBox.Location = new Point(294, 24);
            electricityTextBox.Margin = new Padding(3, 2, 3, 2);
            electricityTextBox.Name = "electricityTextBox";
            electricityTextBox.PlaceholderText = "0";
            electricityTextBox.Size = new Size(264, 23);
            electricityTextBox.TabIndex = 7;
            // 
            // gasTextBox
            // 
            gasTextBox.Dock = DockStyle.Fill;
            gasTextBox.Location = new Point(294, 46);
            gasTextBox.Margin = new Padding(3, 2, 3, 2);
            gasTextBox.Name = "gasTextBox";
            gasTextBox.PlaceholderText = "0";
            gasTextBox.Size = new Size(264, 23);
            gasTextBox.TabIndex = 8;
            // 
            // waterTariffTextBox
            // 
            waterTariffTextBox.Dock = DockStyle.Fill;
            waterTariffTextBox.Location = new Point(294, 68);
            waterTariffTextBox.Margin = new Padding(3, 2, 3, 2);
            waterTariffTextBox.Name = "waterTariffTextBox";
            waterTariffTextBox.PlaceholderText = "0";
            waterTariffTextBox.Size = new Size(264, 23);
            waterTariffTextBox.TabIndex = 9;
            // 
            // electricityTariffTextBox
            // 
            electricityTariffTextBox.Dock = DockStyle.Fill;
            electricityTariffTextBox.Location = new Point(294, 90);
            electricityTariffTextBox.Margin = new Padding(3, 2, 3, 2);
            electricityTariffTextBox.Name = "electricityTariffTextBox";
            electricityTariffTextBox.PlaceholderText = "0";
            electricityTariffTextBox.Size = new Size(264, 23);
            electricityTariffTextBox.TabIndex = 10;
            // 
            // gasTariffTextBox
            // 
            gasTariffTextBox.Dock = DockStyle.Fill;
            gasTariffTextBox.Location = new Point(294, 112);
            gasTariffTextBox.Margin = new Padding(3, 2, 3, 2);
            gasTariffTextBox.Name = "gasTariffTextBox";
            gasTariffTextBox.PlaceholderText = "0";
            gasTariffTextBox.Size = new Size(264, 23);
            gasTariffTextBox.TabIndex = 11;
            // 
            // calculateButton
            // 
            calculateButton.Anchor = AnchorStyles.Left;
            calculateButton.Location = new Point(3, 195);
            calculateButton.Margin = new Padding(3, 2, 3, 2);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(158, 26);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Обчислити";
            calculateButton.UseVisualStyleBackColor = true;
            // 
            // resultGrid
            // 
            resultGrid.AllowUserToAddRows = false;
            resultGrid.AllowUserToDeleteRows = false;
            resultGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultGrid.Dock = DockStyle.Fill;
            resultGrid.Location = new Point(3, 228);
            resultGrid.Margin = new Padding(3, 2, 3, 2);
            resultGrid.Name = "resultGrid";
            resultGrid.ReadOnly = true;
            resultGrid.RowHeadersVisible = false;
            resultGrid.RowTemplate.Height = 29;
            resultGrid.Size = new Size(838, 248);
            resultGrid.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 496);
            Controls.Add(mainLayout);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(737, 400);
            Name = "Form1";
            Padding = new Padding(10, 9, 10, 9);
            Text = "Комунальні платежі";
            mainLayout.ResumeLayout(false);
            inputGroup.ResumeLayout(false);
            inputLayout.ResumeLayout(false);
            inputLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultGrid).EndInit();
            ResumeLayout(false);
        }
    }
}
