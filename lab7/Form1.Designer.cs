namespace lab7
{
    partial class Form1
    {
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
            DataGridViewCellStyle amountCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dateCellStyle = new DataGridViewCellStyle();
            groupBoxInput = new GroupBox();
            lblType = new Label();
            cmbType = new ComboBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblAmount = new Label();
            numAmount = new NumericUpDown();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            groupBoxSummary = new GroupBox();
            lblIncomeCaption = new Label();
            lblIncome = new Label();
            lblExpenseCaption = new Label();
            lblExpense = new Label();
            lblBalanceCaption = new Label();
            lblBalance = new Label();
            btnSave = new Button();
            btnLoad = new Button();
            lblFilter = new Label();
            cmbFilter = new ComboBox();
            dgvOperations = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            lblStatus = new Label();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            groupBoxSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOperations).BeginInit();
            SuspendLayout();
            //
            // groupBoxInput
            //
            groupBoxInput.Controls.Add(lblType);
            groupBoxInput.Controls.Add(cmbType);
            groupBoxInput.Controls.Add(lblCategory);
            groupBoxInput.Controls.Add(cmbCategory);
            groupBoxInput.Controls.Add(lblAmount);
            groupBoxInput.Controls.Add(numAmount);
            groupBoxInput.Controls.Add(lblDate);
            groupBoxInput.Controls.Add(dtpDate);
            groupBoxInput.Controls.Add(lblDescription);
            groupBoxInput.Controls.Add(txtDescription);
            groupBoxInput.Controls.Add(btnAdd);
            groupBoxInput.Controls.Add(btnDelete);
            groupBoxInput.Location = new Point(12, 12);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(300, 300);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Нова операція";
            //
            // lblType
            //
            lblType.AutoSize = true;
            lblType.Location = new Point(15, 32);
            lblType.Name = "lblType";
            lblType.Text = "Тип:";
            //
            // cmbType
            //
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Items.AddRange(new object[] { "Дохід", "Витрата" });
            cmbType.Location = new Point(110, 28);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(175, 23);
            cmbType.TabIndex = 0;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            //
            // lblCategory
            //
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 67);
            lblCategory.Name = "lblCategory";
            lblCategory.Text = "Категорія:";
            //
            // cmbCategory
            //
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(110, 63);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(175, 23);
            cmbCategory.TabIndex = 1;
            //
            // lblAmount
            //
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(15, 102);
            lblAmount.Name = "lblAmount";
            lblAmount.Text = "Сума, грн:";
            //
            // numAmount
            //
            numAmount.DecimalPlaces = 2;
            numAmount.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numAmount.Location = new Point(110, 98);
            numAmount.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(175, 23);
            numAmount.TabIndex = 2;
            numAmount.ThousandsSeparator = true;
            //
            // lblDate
            //
            lblDate.AutoSize = true;
            lblDate.Location = new Point(15, 137);
            lblDate.Name = "lblDate";
            lblDate.Text = "Дата:";
            //
            // dtpDate
            //
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(110, 133);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(175, 23);
            dtpDate.TabIndex = 3;
            //
            // lblDescription
            //
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(15, 172);
            lblDescription.Name = "lblDescription";
            lblDescription.Text = "Опис:";
            //
            // txtDescription
            //
            txtDescription.Location = new Point(110, 168);
            txtDescription.MaxLength = 200;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(175, 23);
            txtDescription.TabIndex = 4;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(15, 210);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(270, 32);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Додати операцію";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(15, 250);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(270, 32);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Видалити вибрану";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            //
            // groupBoxSummary
            //
            groupBoxSummary.Controls.Add(lblIncomeCaption);
            groupBoxSummary.Controls.Add(lblIncome);
            groupBoxSummary.Controls.Add(lblExpenseCaption);
            groupBoxSummary.Controls.Add(lblExpense);
            groupBoxSummary.Controls.Add(lblBalanceCaption);
            groupBoxSummary.Controls.Add(lblBalance);
            groupBoxSummary.Location = new Point(12, 322);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Size = new Size(300, 130);
            groupBoxSummary.TabIndex = 1;
            groupBoxSummary.TabStop = false;
            groupBoxSummary.Text = "Підсумок";
            //
            // lblIncomeCaption
            //
            lblIncomeCaption.AutoSize = true;
            lblIncomeCaption.Location = new Point(15, 30);
            lblIncomeCaption.Name = "lblIncomeCaption";
            lblIncomeCaption.Text = "Доходи:";
            //
            // lblIncome
            //
            lblIncome.ForeColor = Color.ForestGreen;
            lblIncome.Location = new Point(110, 30);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(175, 20);
            lblIncome.Text = "0,00 грн";
            lblIncome.TextAlign = ContentAlignment.TopRight;
            //
            // lblExpenseCaption
            //
            lblExpenseCaption.AutoSize = true;
            lblExpenseCaption.Location = new Point(15, 60);
            lblExpenseCaption.Name = "lblExpenseCaption";
            lblExpenseCaption.Text = "Витрати:";
            //
            // lblExpense
            //
            lblExpense.ForeColor = Color.Firebrick;
            lblExpense.Location = new Point(110, 60);
            lblExpense.Name = "lblExpense";
            lblExpense.Size = new Size(175, 20);
            lblExpense.Text = "0,00 грн";
            lblExpense.TextAlign = ContentAlignment.TopRight;
            //
            // lblBalanceCaption
            //
            lblBalanceCaption.AutoSize = true;
            lblBalanceCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBalanceCaption.Location = new Point(15, 92);
            lblBalanceCaption.Name = "lblBalanceCaption";
            lblBalanceCaption.Text = "Баланс:";
            //
            // lblBalance
            //
            lblBalance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBalance.Location = new Point(110, 92);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(175, 22);
            lblBalance.Text = "0,00 грн";
            lblBalance.TextAlign = ContentAlignment.TopRight;
            //
            // btnSave
            //
            btnSave.Location = new Point(12, 462);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 32);
            btnSave.TabIndex = 2;
            btnSave.Text = "Зберегти у файл…";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            //
            // btnLoad
            //
            btnLoad.Location = new Point(167, 462);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(145, 32);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Відкрити файл…";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            //
            // lblFilter
            //
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(330, 16);
            lblFilter.Name = "lblFilter";
            lblFilter.Text = "Фільтр:";
            //
            // cmbFilter
            //
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Location = new Point(385, 12);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(220, 23);
            cmbFilter.TabIndex = 4;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            //
            // dgvOperations
            //
            dgvOperations.AllowUserToAddRows = false;
            dgvOperations.AllowUserToDeleteRows = false;
            dgvOperations.AllowUserToResizeRows = false;
            dgvOperations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOperations.AutoGenerateColumns = false;
            dgvOperations.BackgroundColor = SystemColors.Window;
            dgvOperations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOperations.Columns.AddRange(new DataGridViewColumn[] { colDate, colType, colCategory, colAmount, colDescription });
            dgvOperations.Location = new Point(330, 45);
            dgvOperations.MultiSelect = false;
            dgvOperations.Name = "dgvOperations";
            dgvOperations.ReadOnly = true;
            dgvOperations.RowHeadersVisible = false;
            dgvOperations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOperations.Size = new Size(558, 420);
            dgvOperations.TabIndex = 5;
            dgvOperations.CellFormatting += dgvOperations_CellFormatting;
            //
            // colDate
            //
            colDate.DataPropertyName = "Date";
            dateCellStyle.Format = "d";
            colDate.DefaultCellStyle = dateCellStyle;
            colDate.HeaderText = "Дата";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 85;
            //
            // colType
            //
            colType.DataPropertyName = "TypeName";
            colType.HeaderText = "Тип";
            colType.Name = "colType";
            colType.ReadOnly = true;
            colType.Width = 75;
            //
            // colCategory
            //
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Категорія";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.Width = 130;
            //
            // colAmount
            //
            colAmount.DataPropertyName = "Amount";
            amountCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            amountCellStyle.Format = "N2";
            colAmount.DefaultCellStyle = amountCellStyle;
            colAmount.HeaderText = "Сума, грн";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.Width = 105;
            //
            // colDescription
            //
            colDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescription.DataPropertyName = "Description";
            colDescription.HeaderText = "Опис";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            //
            // lblStatus
            //
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.Location = new Point(330, 472);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(558, 20);
            lblStatus.Text = "Операцій: 0";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 506);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxSummary);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(lblFilter);
            Controls.Add(cmbFilter);
            Controls.Add(dgvOperations);
            Controls.Add(lblStatus);
            MinimumSize = new Size(916, 545);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Облік доходів і витрат";
            FormClosing += Form1_FormClosing;
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            groupBoxSummary.ResumeLayout(false);
            groupBoxSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOperations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxInput;
        private Label lblType;
        private ComboBox cmbType;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblAmount;
        private NumericUpDown numAmount;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnDelete;
        private GroupBox groupBoxSummary;
        private Label lblIncomeCaption;
        private Label lblIncome;
        private Label lblExpenseCaption;
        private Label lblExpense;
        private Label lblBalanceCaption;
        private Label lblBalance;
        private Button btnSave;
        private Button btnLoad;
        private Label lblFilter;
        private ComboBox cmbFilter;
        private DataGridView dgvOperations;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colDescription;
        private Label lblStatus;
    }
}
