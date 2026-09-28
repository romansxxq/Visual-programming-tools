namespace lab10
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
            groupBoxInput = new GroupBox();
            lblAmount = new Label();
            numAmount = new NumericUpDown();
            lblRate = new Label();
            numRate = new NumericUpDown();
            lblTerm = new Label();
            numTerm = new NumericUpDown();
            btnCalculate = new Button();
            btnReset = new Button();
            groupBoxSummary = new GroupBox();
            lblPaymentCaption = new Label();
            lblPayment = new Label();
            lblTotalCaption = new Label();
            lblTotal = new Label();
            lblOverpayCaption = new Label();
            lblOverpay = new Label();
            lblOverpayPercentCaption = new Label();
            lblOverpayPercent = new Label();
            dataGridSchedule = new DataGridView();
            colMonth = new DataGridViewTextBoxColumn();
            colPayment = new DataGridViewTextBoxColumn();
            colPrincipal = new DataGridViewTextBoxColumn();
            colInterest = new DataGridViewTextBoxColumn();
            colBalance = new DataGridViewTextBoxColumn();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTerm).BeginInit();
            groupBoxSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridSchedule).BeginInit();
            SuspendLayout();
            //
            // groupBoxInput
            //
            groupBoxInput.Controls.Add(lblAmount);
            groupBoxInput.Controls.Add(numAmount);
            groupBoxInput.Controls.Add(lblRate);
            groupBoxInput.Controls.Add(numRate);
            groupBoxInput.Controls.Add(lblTerm);
            groupBoxInput.Controls.Add(numTerm);
            groupBoxInput.Controls.Add(btnCalculate);
            groupBoxInput.Controls.Add(btnReset);
            groupBoxInput.Location = new Point(12, 12);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(400, 190);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Параметри кредиту";
            //
            // lblAmount
            //
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(15, 35);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(142, 20);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Сума кредиту, грн:";
            //
            // numAmount
            //
            numAmount.DecimalPlaces = 2;
            numAmount.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numAmount.Location = new Point(220, 33);
            numAmount.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(160, 27);
            numAmount.TabIndex = 1;
            numAmount.TextAlign = HorizontalAlignment.Right;
            numAmount.ThousandsSeparator = true;
            numAmount.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            numAmount.ValueChanged += Input_Changed;
            //
            // lblRate
            //
            lblRate.AutoSize = true;
            lblRate.Location = new Point(15, 70);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(128, 20);
            lblRate.TabIndex = 2;
            lblRate.Text = "Річна ставка, %:";
            //
            // numRate
            //
            numRate.DecimalPlaces = 2;
            numRate.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numRate.Location = new Point(220, 68);
            numRate.Name = "numRate";
            numRate.Size = new Size(160, 27);
            numRate.TabIndex = 3;
            numRate.TextAlign = HorizontalAlignment.Right;
            numRate.Value = new decimal(new int[] { 18, 0, 0, 0 });
            numRate.ValueChanged += Input_Changed;
            //
            // lblTerm
            //
            lblTerm.AutoSize = true;
            lblTerm.Location = new Point(15, 105);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(129, 20);
            lblTerm.TabIndex = 4;
            lblTerm.Text = "Термін, місяців:";
            //
            // numTerm
            //
            numTerm.Location = new Point(220, 103);
            numTerm.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numTerm.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTerm.Name = "numTerm";
            numTerm.Size = new Size(160, 27);
            numTerm.TabIndex = 5;
            numTerm.TextAlign = HorizontalAlignment.Right;
            numTerm.Value = new decimal(new int[] { 12, 0, 0, 0 });
            numTerm.ValueChanged += Input_Changed;
            //
            // btnCalculate
            //
            btnCalculate.Location = new Point(15, 143);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(170, 34);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Розрахувати";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            //
            // btnReset
            //
            btnReset.Location = new Point(210, 143);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(170, 34);
            btnReset.TabIndex = 7;
            btnReset.Text = "Скинути";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            //
            // groupBoxSummary
            //
            groupBoxSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSummary.Controls.Add(lblPaymentCaption);
            groupBoxSummary.Controls.Add(lblPayment);
            groupBoxSummary.Controls.Add(lblTotalCaption);
            groupBoxSummary.Controls.Add(lblTotal);
            groupBoxSummary.Controls.Add(lblOverpayCaption);
            groupBoxSummary.Controls.Add(lblOverpay);
            groupBoxSummary.Controls.Add(lblOverpayPercentCaption);
            groupBoxSummary.Controls.Add(lblOverpayPercent);
            groupBoxSummary.Location = new Point(424, 12);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Size = new Size(482, 190);
            groupBoxSummary.TabIndex = 1;
            groupBoxSummary.TabStop = false;
            groupBoxSummary.Text = "Підсумок";
            //
            // lblPaymentCaption
            //
            lblPaymentCaption.AutoSize = true;
            lblPaymentCaption.Location = new Point(15, 35);
            lblPaymentCaption.Name = "lblPaymentCaption";
            lblPaymentCaption.Size = new Size(158, 20);
            lblPaymentCaption.TabIndex = 0;
            lblPaymentCaption.Text = "Щомісячний платіж:";
            //
            // lblPayment
            //
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPayment.Location = new Point(260, 33);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(20, 23);
            lblPayment.TabIndex = 1;
            lblPayment.Text = "—";
            //
            // lblTotalCaption
            //
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Location = new Point(15, 70);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(178, 20);
            lblTotalCaption.TabIndex = 2;
            lblTotalCaption.Text = "Загальна сума виплат:";
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(260, 68);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(20, 23);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "—";
            //
            // lblOverpayCaption
            //
            lblOverpayCaption.AutoSize = true;
            lblOverpayCaption.Location = new Point(15, 108);
            lblOverpayCaption.Name = "lblOverpayCaption";
            lblOverpayCaption.Size = new Size(173, 20);
            lblOverpayCaption.TabIndex = 4;
            lblOverpayCaption.Text = "Переплата (відсотки):";
            //
            // lblOverpay
            //
            lblOverpay.AutoSize = true;
            lblOverpay.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOverpay.ForeColor = Color.Firebrick;
            lblOverpay.Location = new Point(258, 101);
            lblOverpay.Name = "lblOverpay";
            lblOverpay.Size = new Size(28, 32);
            lblOverpay.TabIndex = 5;
            lblOverpay.Text = "—";
            //
            // lblOverpayPercentCaption
            //
            lblOverpayPercentCaption.AutoSize = true;
            lblOverpayPercentCaption.Location = new Point(15, 148);
            lblOverpayPercentCaption.Name = "lblOverpayPercentCaption";
            lblOverpayPercentCaption.Size = new Size(229, 20);
            lblOverpayPercentCaption.TabIndex = 6;
            lblOverpayPercentCaption.Text = "Переплата від суми кредиту:";
            //
            // lblOverpayPercent
            //
            lblOverpayPercent.AutoSize = true;
            lblOverpayPercent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOverpayPercent.Location = new Point(260, 146);
            lblOverpayPercent.Name = "lblOverpayPercent";
            lblOverpayPercent.Size = new Size(20, 23);
            lblOverpayPercent.TabIndex = 7;
            lblOverpayPercent.Text = "—";
            //
            // dataGridSchedule
            //
            dataGridSchedule.AllowUserToAddRows = false;
            dataGridSchedule.AllowUserToDeleteRows = false;
            dataGridSchedule.AllowUserToResizeRows = false;
            dataGridSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridSchedule.BackgroundColor = SystemColors.Window;
            dataGridSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSchedule.Columns.AddRange(new DataGridViewColumn[] { colMonth, colPayment, colPrincipal, colInterest, colBalance });
            dataGridSchedule.Location = new Point(12, 215);
            dataGridSchedule.MultiSelect = false;
            dataGridSchedule.Name = "dataGridSchedule";
            dataGridSchedule.ReadOnly = true;
            dataGridSchedule.RowHeadersVisible = false;
            dataGridSchedule.RowHeadersWidth = 51;
            dataGridSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSchedule.Size = new Size(894, 423);
            dataGridSchedule.TabIndex = 2;
            //
            // colMonth
            //
            colMonth.FillWeight = 50F;
            colMonth.HeaderText = "Місяць";
            colMonth.MinimumWidth = 6;
            colMonth.Name = "colMonth";
            colMonth.ReadOnly = true;
            colMonth.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // colPayment
            //
            colPayment.HeaderText = "Платіж, грн";
            colPayment.MinimumWidth = 6;
            colPayment.Name = "colPayment";
            colPayment.ReadOnly = true;
            colPayment.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // colPrincipal
            //
            colPrincipal.HeaderText = "Тіло кредиту, грн";
            colPrincipal.MinimumWidth = 6;
            colPrincipal.Name = "colPrincipal";
            colPrincipal.ReadOnly = true;
            colPrincipal.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // colInterest
            //
            colInterest.HeaderText = "Відсотки, грн";
            colInterest.MinimumWidth = 6;
            colInterest.Name = "colInterest";
            colInterest.ReadOnly = true;
            colInterest.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // colBalance
            //
            colBalance.HeaderText = "Залишок боргу, грн";
            colBalance.MinimumWidth = 6;
            colBalance.Name = "colBalance";
            colBalance.ReadOnly = true;
            colBalance.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // Form1
            //
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 650);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxSummary);
            Controls.Add(dataGridSchedule);
            MinimumSize = new Size(936, 450);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Кредитний калькулятор — ануїтетні платежі";
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTerm).EndInit();
            groupBoxSummary.ResumeLayout(false);
            groupBoxSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInput;
        private Label lblAmount;
        private NumericUpDown numAmount;
        private Label lblRate;
        private NumericUpDown numRate;
        private Label lblTerm;
        private NumericUpDown numTerm;
        private Button btnCalculate;
        private Button btnReset;
        private GroupBox groupBoxSummary;
        private Label lblPaymentCaption;
        private Label lblPayment;
        private Label lblTotalCaption;
        private Label lblTotal;
        private Label lblOverpayCaption;
        private Label lblOverpay;
        private Label lblOverpayPercentCaption;
        private Label lblOverpayPercent;
        private DataGridView dataGridSchedule;
        private DataGridViewTextBoxColumn colMonth;
        private DataGridViewTextBoxColumn colPayment;
        private DataGridViewTextBoxColumn colPrincipal;
        private DataGridViewTextBoxColumn colInterest;
        private DataGridViewTextBoxColumn colBalance;
    }
}
