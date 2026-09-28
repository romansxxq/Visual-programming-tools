namespace lab9
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
            groupBoxUsage = new GroupBox();
            lblInternet = new Label();
            numInternet = new NumericUpDown();
            lblMinutes = new Label();
            numMinutes = new NumericUpDown();
            lblSms = new Label();
            numSms = new NumericUpDown();
            btnCalculate = new Button();
            btnReset = new Button();
            groupBoxBest = new GroupBox();
            lblBestCaption = new Label();
            lblBestName = new Label();
            lblCostCaption = new Label();
            lblCost = new Label();
            lblYearCaption = new Label();
            lblYear = new Label();
            lblOverageCaption = new Label();
            lblOverage = new Label();
            lblSavingCaption = new Label();
            lblSaving = new Label();
            groupBoxTariffs = new GroupBox();
            listViewTariffs = new ListView();
            colName = new ColumnHeader();
            colPackage = new ColumnHeader();
            colFee = new ColumnHeader();
            colOverage = new ColumnHeader();
            colTotal = new ColumnHeader();
            txtSummary = new TextBox();
            groupBoxUsage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numInternet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSms).BeginInit();
            groupBoxBest.SuspendLayout();
            groupBoxTariffs.SuspendLayout();
            SuspendLayout();
            //
            // groupBoxUsage
            //
            groupBoxUsage.Controls.Add(lblInternet);
            groupBoxUsage.Controls.Add(numInternet);
            groupBoxUsage.Controls.Add(lblMinutes);
            groupBoxUsage.Controls.Add(numMinutes);
            groupBoxUsage.Controls.Add(lblSms);
            groupBoxUsage.Controls.Add(numSms);
            groupBoxUsage.Location = new Point(12, 12);
            groupBoxUsage.Name = "groupBoxUsage";
            groupBoxUsage.Size = new Size(360, 145);
            groupBoxUsage.TabIndex = 0;
            groupBoxUsage.TabStop = false;
            groupBoxUsage.Text = "Ваше споживання на місяць";
            //
            // lblInternet
            //
            lblInternet.AutoSize = true;
            lblInternet.Location = new Point(15, 32);
            lblInternet.Name = "lblInternet";
            lblInternet.Size = new Size(106, 20);
            lblInternet.TabIndex = 0;
            lblInternet.Text = "Інтернет, ГБ:";
            //
            // numInternet
            //
            numInternet.DecimalPlaces = 1;
            numInternet.Location = new Point(220, 30);
            numInternet.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numInternet.Name = "numInternet";
            numInternet.Size = new Size(125, 27);
            numInternet.TabIndex = 1;
            numInternet.Value = new decimal(new int[] { 8, 0, 0, 0 });
            numInternet.ValueChanged += Input_Changed;
            //
            // lblMinutes
            //
            lblMinutes.AutoSize = true;
            lblMinutes.Location = new Point(15, 67);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(144, 20);
            lblMinutes.TabIndex = 2;
            lblMinutes.Text = "Хвилин дзвінків:";
            //
            // numMinutes
            //
            numMinutes.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numMinutes.Location = new Point(220, 65);
            numMinutes.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numMinutes.Name = "numMinutes";
            numMinutes.Size = new Size(125, 27);
            numMinutes.TabIndex = 3;
            numMinutes.Value = new decimal(new int[] { 250, 0, 0, 0 });
            numMinutes.ValueChanged += Input_Changed;
            //
            // lblSms
            //
            lblSms.AutoSize = true;
            lblSms.Location = new Point(15, 102);
            lblSms.Name = "lblSms";
            lblSms.Size = new Size(88, 20);
            lblSms.TabIndex = 4;
            lblSms.Text = "SMS, шт.:";
            //
            // numSms
            //
            numSms.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numSms.Location = new Point(220, 100);
            numSms.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numSms.Name = "numSms";
            numSms.Size = new Size(125, 27);
            numSms.TabIndex = 5;
            numSms.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numSms.ValueChanged += Input_Changed;
            //
            // btnCalculate
            //
            btnCalculate.Location = new Point(12, 165);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(215, 36);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Підібрати тариф";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            //
            // btnReset
            //
            btnReset.Location = new Point(237, 165);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(135, 36);
            btnReset.TabIndex = 2;
            btnReset.Text = "Скинути";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            //
            // groupBoxBest
            //
            groupBoxBest.Controls.Add(lblBestCaption);
            groupBoxBest.Controls.Add(lblBestName);
            groupBoxBest.Controls.Add(lblCostCaption);
            groupBoxBest.Controls.Add(lblCost);
            groupBoxBest.Controls.Add(lblYearCaption);
            groupBoxBest.Controls.Add(lblYear);
            groupBoxBest.Controls.Add(lblOverageCaption);
            groupBoxBest.Controls.Add(lblOverage);
            groupBoxBest.Controls.Add(lblSavingCaption);
            groupBoxBest.Controls.Add(lblSaving);
            groupBoxBest.Location = new Point(12, 210);
            groupBoxBest.Name = "groupBoxBest";
            groupBoxBest.Size = new Size(360, 251);
            groupBoxBest.TabIndex = 3;
            groupBoxBest.TabStop = false;
            groupBoxBest.Text = "Рекомендація";
            //
            // lblBestCaption
            //
            lblBestCaption.AutoSize = true;
            lblBestCaption.Location = new Point(15, 30);
            lblBestCaption.Name = "lblBestCaption";
            lblBestCaption.Size = new Size(185, 20);
            lblBestCaption.TabIndex = 0;
            lblBestCaption.Text = "Найвигідніший тариф:";
            //
            // lblBestName
            //
            lblBestName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBestName.ForeColor = Color.ForestGreen;
            lblBestName.Location = new Point(15, 52);
            lblBestName.Name = "lblBestName";
            lblBestName.Size = new Size(330, 45);
            lblBestName.TabIndex = 1;
            lblBestName.Text = "—";
            lblBestName.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblCostCaption
            //
            lblCostCaption.AutoSize = true;
            lblCostCaption.Location = new Point(15, 110);
            lblCostCaption.Name = "lblCostCaption";
            lblCostCaption.Size = new Size(88, 20);
            lblCostCaption.TabIndex = 2;
            lblCostCaption.Text = "На місяць:";
            //
            // lblCost
            //
            lblCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCost.Location = new Point(200, 108);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(145, 25);
            lblCost.TabIndex = 3;
            lblCost.Text = "—";
            lblCost.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblYearCaption
            //
            lblYearCaption.AutoSize = true;
            lblYearCaption.Location = new Point(15, 145);
            lblYearCaption.Name = "lblYearCaption";
            lblYearCaption.Size = new Size(59, 20);
            lblYearCaption.TabIndex = 4;
            lblYearCaption.Text = "На рік:";
            //
            // lblYear
            //
            lblYear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblYear.Location = new Point(200, 143);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(145, 25);
            lblYear.TabIndex = 5;
            lblYear.Text = "—";
            lblYear.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblOverageCaption
            //
            lblOverageCaption.AutoSize = true;
            lblOverageCaption.Location = new Point(15, 180);
            lblOverageCaption.Name = "lblOverageCaption";
            lblOverageCaption.Size = new Size(170, 20);
            lblOverageCaption.TabIndex = 6;
            lblOverageCaption.Text = "З них доплата:";
            //
            // lblOverage
            //
            lblOverage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOverage.ForeColor = Color.Firebrick;
            lblOverage.Location = new Point(200, 178);
            lblOverage.Name = "lblOverage";
            lblOverage.Size = new Size(145, 25);
            lblOverage.TabIndex = 7;
            lblOverage.Text = "—";
            lblOverage.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblSavingCaption
            //
            lblSavingCaption.AutoSize = true;
            lblSavingCaption.Location = new Point(15, 215);
            lblSavingCaption.Name = "lblSavingCaption";
            lblSavingCaption.Size = new Size(180, 20);
            lblSavingCaption.TabIndex = 8;
            lblSavingCaption.Text = "Дешевше за інші на:";
            //
            // lblSaving
            //
            lblSaving.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSaving.ForeColor = Color.ForestGreen;
            lblSaving.Location = new Point(200, 213);
            lblSaving.Name = "lblSaving";
            lblSaving.Size = new Size(145, 25);
            lblSaving.TabIndex = 9;
            lblSaving.Text = "—";
            lblSaving.TextAlign = ContentAlignment.MiddleRight;
            //
            // groupBoxTariffs
            //
            groupBoxTariffs.Controls.Add(listViewTariffs);
            groupBoxTariffs.Controls.Add(txtSummary);
            groupBoxTariffs.Location = new Point(385, 12);
            groupBoxTariffs.Name = "groupBoxTariffs";
            groupBoxTariffs.Size = new Size(520, 449);
            groupBoxTariffs.TabIndex = 4;
            groupBoxTariffs.TabStop = false;
            groupBoxTariffs.Text = "Порівняння тарифів";
            //
            // listViewTariffs
            //
            listViewTariffs.Columns.AddRange(new ColumnHeader[] { colName, colPackage, colFee, colOverage, colTotal });
            listViewTariffs.FullRowSelect = true;
            listViewTariffs.GridLines = true;
            listViewTariffs.Location = new Point(15, 28);
            listViewTariffs.Name = "listViewTariffs";
            listViewTariffs.Size = new Size(490, 160);
            listViewTariffs.TabIndex = 0;
            listViewTariffs.UseCompatibleStateImageBehavior = false;
            listViewTariffs.View = View.Details;
            //
            // colName
            //
            colName.Text = "Тариф";
            colName.Width = 85;
            //
            // colPackage
            //
            colPackage.Text = "Пакет";
            colPackage.Width = 165;
            //
            // colFee
            //
            colFee.Text = "Абонплата";
            colFee.TextAlign = HorizontalAlignment.Right;
            colFee.Width = 80;
            //
            // colOverage
            //
            colOverage.Text = "Доплата";
            colOverage.TextAlign = HorizontalAlignment.Right;
            colOverage.Width = 75;
            //
            // colTotal
            //
            colTotal.Text = "Разом";
            colTotal.TextAlign = HorizontalAlignment.Right;
            colTotal.Width = 75;
            //
            // txtSummary
            //
            txtSummary.Location = new Point(15, 198);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(490, 236);
            txtSummary.TabIndex = 1;
            //
            // Form1
            //
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 473);
            Controls.Add(groupBoxUsage);
            Controls.Add(btnCalculate);
            Controls.Add(btnReset);
            Controls.Add(groupBoxBest);
            Controls.Add(groupBoxTariffs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Підбір мобільного тарифу";
            groupBoxUsage.ResumeLayout(false);
            groupBoxUsage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numInternet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSms).EndInit();
            groupBoxBest.ResumeLayout(false);
            groupBoxBest.PerformLayout();
            groupBoxTariffs.ResumeLayout(false);
            groupBoxTariffs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsage;
        private Label lblInternet;
        private NumericUpDown numInternet;
        private Label lblMinutes;
        private NumericUpDown numMinutes;
        private Label lblSms;
        private NumericUpDown numSms;
        private Button btnCalculate;
        private Button btnReset;
        private GroupBox groupBoxBest;
        private Label lblBestCaption;
        private Label lblBestName;
        private Label lblCostCaption;
        private Label lblCost;
        private Label lblYearCaption;
        private Label lblYear;
        private Label lblOverageCaption;
        private Label lblOverage;
        private Label lblSavingCaption;
        private Label lblSaving;
        private GroupBox groupBoxTariffs;
        private ListView listViewTariffs;
        private ColumnHeader colName;
        private ColumnHeader colPackage;
        private ColumnHeader colFee;
        private ColumnHeader colOverage;
        private ColumnHeader colTotal;
        private TextBox txtSummary;
    }
}
