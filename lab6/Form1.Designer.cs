namespace lab6
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
            lblCoffee = new Label();
            numCoffee = new NumericUpDown();
            lblCigarettes = new Label();
            numCigarettes = new NumericUpDown();
            lblTaxi = new Label();
            numTaxi = new NumericUpDown();
            lblOther = new Label();
            numOther = new NumericUpDown();
            lblDaysPerWeek = new Label();
            numDaysPerWeek = new NumericUpDown();
            btnCalculate = new Button();
            btnReset = new Button();
            groupBoxTotals = new GroupBox();
            lblDayCaption = new Label();
            lblDay = new Label();
            lblMonthCaption = new Label();
            lblMonth = new Label();
            lblYearCaption = new Label();
            lblYear = new Label();
            lbl5YearsCaption = new Label();
            lbl5Years = new Label();
            groupBoxCompare = new GroupBox();
            listViewItems = new ListView();
            colItem = new ColumnHeader();
            colPrice = new ColumnHeader();
            colMonth = new ColumnHeader();
            colYear = new ColumnHeader();
            col5Years = new ColumnHeader();
            txtSummary = new TextBox();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCoffee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCigarettes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTaxi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOther).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDaysPerWeek).BeginInit();
            groupBoxTotals.SuspendLayout();
            groupBoxCompare.SuspendLayout();
            SuspendLayout();
            //
            // groupBoxInput
            //
            groupBoxInput.Controls.Add(lblCoffee);
            groupBoxInput.Controls.Add(numCoffee);
            groupBoxInput.Controls.Add(lblCigarettes);
            groupBoxInput.Controls.Add(numCigarettes);
            groupBoxInput.Controls.Add(lblTaxi);
            groupBoxInput.Controls.Add(numTaxi);
            groupBoxInput.Controls.Add(lblOther);
            groupBoxInput.Controls.Add(numOther);
            groupBoxInput.Controls.Add(lblDaysPerWeek);
            groupBoxInput.Controls.Add(numDaysPerWeek);
            groupBoxInput.Controls.Add(btnCalculate);
            groupBoxInput.Controls.Add(btnReset);
            groupBoxInput.Location = new Point(12, 12);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(330, 260);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Щоденні витрати (грн)";
            //
            // lblCoffee
            //
            lblCoffee.AutoSize = true;
            lblCoffee.Location = new Point(15, 32);
            lblCoffee.Name = "lblCoffee";
            lblCoffee.Size = new Size(45, 20);
            lblCoffee.TabIndex = 0;
            lblCoffee.Text = "Кава:";
            //
            // numCoffee
            //
            numCoffee.DecimalPlaces = 2;
            numCoffee.Location = new Point(180, 30);
            numCoffee.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numCoffee.Name = "numCoffee";
            numCoffee.Size = new Size(130, 27);
            numCoffee.TabIndex = 1;
            numCoffee.ThousandsSeparator = true;
            numCoffee.Value = new decimal(new int[] { 70, 0, 0, 0 });
            //
            // lblCigarettes
            //
            lblCigarettes.AutoSize = true;
            lblCigarettes.Location = new Point(15, 67);
            lblCigarettes.Name = "lblCigarettes";
            lblCigarettes.Size = new Size(79, 20);
            lblCigarettes.TabIndex = 2;
            lblCigarettes.Text = "Сигарети:";
            //
            // numCigarettes
            //
            numCigarettes.DecimalPlaces = 2;
            numCigarettes.Location = new Point(180, 65);
            numCigarettes.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numCigarettes.Name = "numCigarettes";
            numCigarettes.Size = new Size(130, 27);
            numCigarettes.TabIndex = 3;
            numCigarettes.ThousandsSeparator = true;
            numCigarettes.Value = new decimal(new int[] { 100, 0, 0, 0 });
            //
            // lblTaxi
            //
            lblTaxi.AutoSize = true;
            lblTaxi.Location = new Point(15, 102);
            lblTaxi.Name = "lblTaxi";
            lblTaxi.Size = new Size(53, 20);
            lblTaxi.TabIndex = 4;
            lblTaxi.Text = "Таксі:";
            //
            // numTaxi
            //
            numTaxi.DecimalPlaces = 2;
            numTaxi.Location = new Point(180, 100);
            numTaxi.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numTaxi.Name = "numTaxi";
            numTaxi.Size = new Size(130, 27);
            numTaxi.TabIndex = 5;
            numTaxi.ThousandsSeparator = true;
            numTaxi.Value = new decimal(new int[] { 150, 0, 0, 0 });
            //
            // lblOther
            //
            lblOther.AutoSize = true;
            lblOther.Location = new Point(15, 137);
            lblOther.Name = "lblOther";
            lblOther.Size = new Size(47, 20);
            lblOther.TabIndex = 6;
            lblOther.Text = "Інше:";
            //
            // numOther
            //
            numOther.DecimalPlaces = 2;
            numOther.Location = new Point(180, 135);
            numOther.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numOther.Name = "numOther";
            numOther.Size = new Size(130, 27);
            numOther.TabIndex = 7;
            numOther.ThousandsSeparator = true;
            //
            // lblDaysPerWeek
            //
            lblDaysPerWeek.AutoSize = true;
            lblDaysPerWeek.Location = new Point(15, 172);
            lblDaysPerWeek.Name = "lblDaysPerWeek";
            lblDaysPerWeek.Size = new Size(131, 20);
            lblDaysPerWeek.TabIndex = 8;
            lblDaysPerWeek.Text = "Днів на тиждень:";
            //
            // numDaysPerWeek
            //
            numDaysPerWeek.Location = new Point(180, 170);
            numDaysPerWeek.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numDaysPerWeek.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDaysPerWeek.Name = "numDaysPerWeek";
            numDaysPerWeek.Size = new Size(130, 27);
            numDaysPerWeek.TabIndex = 9;
            numDaysPerWeek.Value = new decimal(new int[] { 7, 0, 0, 0 });
            //
            // btnCalculate
            //
            btnCalculate.Location = new Point(15, 212);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(170, 34);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Порахувати";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            //
            // btnReset
            //
            btnReset.Location = new Point(195, 212);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(115, 34);
            btnReset.TabIndex = 11;
            btnReset.Text = "Скинути";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            //
            // groupBoxTotals
            //
            groupBoxTotals.Controls.Add(lblDayCaption);
            groupBoxTotals.Controls.Add(lblDay);
            groupBoxTotals.Controls.Add(lblMonthCaption);
            groupBoxTotals.Controls.Add(lblMonth);
            groupBoxTotals.Controls.Add(lblYearCaption);
            groupBoxTotals.Controls.Add(lblYear);
            groupBoxTotals.Controls.Add(lbl5YearsCaption);
            groupBoxTotals.Controls.Add(lbl5Years);
            groupBoxTotals.Location = new Point(12, 278);
            groupBoxTotals.Name = "groupBoxTotals";
            groupBoxTotals.Size = new Size(330, 180);
            groupBoxTotals.TabIndex = 1;
            groupBoxTotals.TabStop = false;
            groupBoxTotals.Text = "Сума витрат";
            //
            // lblDayCaption
            //
            lblDayCaption.AutoSize = true;
            lblDayCaption.Location = new Point(15, 32);
            lblDayCaption.Name = "lblDayCaption";
            lblDayCaption.Size = new Size(83, 20);
            lblDayCaption.TabIndex = 0;
            lblDayCaption.Text = "За день:";
            //
            // lblDay
            //
            lblDay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDay.Location = new Point(140, 30);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(170, 25);
            lblDay.TabIndex = 1;
            lblDay.Text = "—";
            lblDay.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblMonthCaption
            //
            lblMonthCaption.AutoSize = true;
            lblMonthCaption.Location = new Point(15, 67);
            lblMonthCaption.Name = "lblMonthCaption";
            lblMonthCaption.Size = new Size(83, 20);
            lblMonthCaption.TabIndex = 2;
            lblMonthCaption.Text = "За місяць:";
            //
            // lblMonth
            //
            lblMonth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMonth.Location = new Point(140, 65);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(170, 25);
            lblMonth.TabIndex = 3;
            lblMonth.Text = "—";
            lblMonth.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblYearCaption
            //
            lblYearCaption.AutoSize = true;
            lblYearCaption.Location = new Point(15, 102);
            lblYearCaption.Name = "lblYearCaption";
            lblYearCaption.Size = new Size(60, 20);
            lblYearCaption.TabIndex = 4;
            lblYearCaption.Text = "За рік:";
            //
            // lblYear
            //
            lblYear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblYear.Location = new Point(140, 100);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(170, 25);
            lblYear.TabIndex = 5;
            lblYear.Text = "—";
            lblYear.TextAlign = ContentAlignment.MiddleRight;
            //
            // lbl5YearsCaption
            //
            lbl5YearsCaption.AutoSize = true;
            lbl5YearsCaption.Location = new Point(15, 137);
            lbl5YearsCaption.Name = "lbl5YearsCaption";
            lbl5YearsCaption.Size = new Size(94, 20);
            lbl5YearsCaption.TabIndex = 6;
            lbl5YearsCaption.Text = "За 5 років:";
            //
            // lbl5Years
            //
            lbl5Years.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl5Years.ForeColor = Color.Firebrick;
            lbl5Years.Location = new Point(140, 135);
            lbl5Years.Name = "lbl5Years";
            lbl5Years.Size = new Size(170, 25);
            lbl5Years.TabIndex = 7;
            lbl5Years.Text = "—";
            lbl5Years.TextAlign = ContentAlignment.MiddleRight;
            //
            // groupBoxCompare
            //
            groupBoxCompare.Controls.Add(listViewItems);
            groupBoxCompare.Controls.Add(txtSummary);
            groupBoxCompare.Location = new Point(355, 12);
            groupBoxCompare.Name = "groupBoxCompare";
            groupBoxCompare.Size = new Size(600, 446);
            groupBoxCompare.TabIndex = 2;
            groupBoxCompare.TabStop = false;
            groupBoxCompare.Text = "За ці гроші можна купити...";
            //
            // listViewItems
            //
            listViewItems.Columns.AddRange(new ColumnHeader[] { colItem, colPrice, colMonth, colYear, col5Years });
            listViewItems.FullRowSelect = true;
            listViewItems.GridLines = true;
            listViewItems.Location = new Point(15, 30);
            listViewItems.Name = "listViewItems";
            listViewItems.Size = new Size(570, 250);
            listViewItems.TabIndex = 0;
            listViewItems.UseCompatibleStateImageBehavior = false;
            listViewItems.View = View.Details;
            //
            // colItem
            //
            colItem.Text = "Річ";
            colItem.Width = 190;
            //
            // colPrice
            //
            colPrice.Text = "Ціна, грн";
            colPrice.TextAlign = HorizontalAlignment.Right;
            colPrice.Width = 100;
            //
            // colMonth
            //
            colMonth.Text = "Місяць";
            colMonth.TextAlign = HorizontalAlignment.Right;
            colMonth.Width = 85;
            //
            // colYear
            //
            colYear.Text = "Рік";
            colYear.TextAlign = HorizontalAlignment.Right;
            colYear.Width = 85;
            //
            // col5Years
            //
            col5Years.Text = "5 років";
            col5Years.TextAlign = HorizontalAlignment.Right;
            col5Years.Width = 85;
            //
            // txtSummary
            //
            txtSummary.Location = new Point(15, 290);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(570, 140);
            txtSummary.TabIndex = 1;
            //
            // Form1
            //
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 470);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxTotals);
            Controls.Add(groupBoxCompare);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор дрібних витрат";
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCoffee).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCigarettes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTaxi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOther).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDaysPerWeek).EndInit();
            groupBoxTotals.ResumeLayout(false);
            groupBoxTotals.PerformLayout();
            groupBoxCompare.ResumeLayout(false);
            groupBoxCompare.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInput;
        private Label lblCoffee;
        private NumericUpDown numCoffee;
        private Label lblCigarettes;
        private NumericUpDown numCigarettes;
        private Label lblTaxi;
        private NumericUpDown numTaxi;
        private Label lblOther;
        private NumericUpDown numOther;
        private Label lblDaysPerWeek;
        private NumericUpDown numDaysPerWeek;
        private Button btnCalculate;
        private Button btnReset;
        private GroupBox groupBoxTotals;
        private Label lblDayCaption;
        private Label lblDay;
        private Label lblMonthCaption;
        private Label lblMonth;
        private Label lblYearCaption;
        private Label lblYear;
        private Label lbl5YearsCaption;
        private Label lbl5Years;
        private GroupBox groupBoxCompare;
        private ListView listViewItems;
        private ColumnHeader colItem;
        private ColumnHeader colPrice;
        private ColumnHeader colMonth;
        private ColumnHeader colYear;
        private ColumnHeader col5Years;
        private TextBox txtSummary;
    }
}
