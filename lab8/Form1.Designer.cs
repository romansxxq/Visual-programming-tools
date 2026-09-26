namespace lab8
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
            groupBoxCar = new GroupBox();
            lblTrips = new Label();
            numTrips = new NumericUpDown();
            lblDistance = new Label();
            numDistance = new NumericUpDown();
            lblFuel = new Label();
            cmbFuel = new ComboBox();
            groupBoxDevices = new GroupBox();
            lblComputer = new Label();
            numComputer = new NumericUpDown();
            lblTv = new Label();
            numTv = new NumericUpDown();
            lblHeater = new Label();
            numHeater = new NumericUpDown();
            lblKettle = new Label();
            numKettle = new NumericUpDown();
            lblWasher = new Label();
            numWasher = new NumericUpDown();
            lblLighting = new Label();
            numLighting = new NumericUpDown();
            btnCalculate = new Button();
            btnReset = new Button();
            groupBoxTotals = new GroupBox();
            lblWeekCaption = new Label();
            lblWeek = new Label();
            lblMonthCaption = new Label();
            lblMonth = new Label();
            lblYearCaption = new Label();
            lblYear = new Label();
            lblTreesCaption = new Label();
            lblTrees = new Label();
            groupBoxBreakdown = new GroupBox();
            listViewSources = new ListView();
            colSource = new ColumnHeader();
            colKg = new ColumnHeader();
            colShare = new ColumnHeader();
            txtSummary = new TextBox();
            groupBoxCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTrips).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
            groupBoxDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numComputer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKettle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWasher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLighting).BeginInit();
            groupBoxTotals.SuspendLayout();
            groupBoxBreakdown.SuspendLayout();
            SuspendLayout();
            //
            // groupBoxCar
            //
            groupBoxCar.Controls.Add(lblTrips);
            groupBoxCar.Controls.Add(numTrips);
            groupBoxCar.Controls.Add(lblDistance);
            groupBoxCar.Controls.Add(numDistance);
            groupBoxCar.Controls.Add(lblFuel);
            groupBoxCar.Controls.Add(cmbFuel);
            groupBoxCar.Location = new Point(12, 12);
            groupBoxCar.Name = "groupBoxCar";
            groupBoxCar.Size = new Size(360, 145);
            groupBoxCar.TabIndex = 0;
            groupBoxCar.TabStop = false;
            groupBoxCar.Text = "Поїздки на авто";
            //
            // lblTrips
            //
            lblTrips.AutoSize = true;
            lblTrips.Location = new Point(15, 32);
            lblTrips.Name = "lblTrips";
            lblTrips.Size = new Size(150, 20);
            lblTrips.TabIndex = 0;
            lblTrips.Text = "Поїздок на тиждень:";
            //
            // numTrips
            //
            numTrips.Location = new Point(220, 30);
            numTrips.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numTrips.Name = "numTrips";
            numTrips.Size = new Size(125, 27);
            numTrips.TabIndex = 1;
            numTrips.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numTrips.ValueChanged += Input_Changed;
            //
            // lblDistance
            //
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(15, 67);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(185, 20);
            lblDistance.TabIndex = 2;
            lblDistance.Text = "Середня поїздка, км:";
            //
            // numDistance
            //
            numDistance.DecimalPlaces = 1;
            numDistance.Location = new Point(220, 65);
            numDistance.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(125, 27);
            numDistance.TabIndex = 3;
            numDistance.Value = new decimal(new int[] { 12, 0, 0, 0 });
            numDistance.ValueChanged += Input_Changed;
            //
            // lblFuel
            //
            lblFuel.AutoSize = true;
            lblFuel.Location = new Point(15, 102);
            lblFuel.Name = "lblFuel";
            lblFuel.Size = new Size(106, 20);
            lblFuel.TabIndex = 4;
            lblFuel.Text = "Тип пального:";
            //
            // cmbFuel
            //
            cmbFuel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuel.Location = new Point(220, 99);
            cmbFuel.Name = "cmbFuel";
            cmbFuel.Size = new Size(125, 28);
            cmbFuel.TabIndex = 5;
            cmbFuel.SelectedIndexChanged += Input_Changed;
            //
            // groupBoxDevices
            //
            groupBoxDevices.Controls.Add(lblComputer);
            groupBoxDevices.Controls.Add(numComputer);
            groupBoxDevices.Controls.Add(lblTv);
            groupBoxDevices.Controls.Add(numTv);
            groupBoxDevices.Controls.Add(lblHeater);
            groupBoxDevices.Controls.Add(numHeater);
            groupBoxDevices.Controls.Add(lblKettle);
            groupBoxDevices.Controls.Add(numKettle);
            groupBoxDevices.Controls.Add(lblWasher);
            groupBoxDevices.Controls.Add(numWasher);
            groupBoxDevices.Controls.Add(lblLighting);
            groupBoxDevices.Controls.Add(numLighting);
            groupBoxDevices.Location = new Point(12, 165);
            groupBoxDevices.Name = "groupBoxDevices";
            groupBoxDevices.Size = new Size(360, 250);
            groupBoxDevices.TabIndex = 1;
            groupBoxDevices.TabStop = false;
            groupBoxDevices.Text = "Електроприлади (годин на день)";
            //
            // lblComputer
            //
            lblComputer.AutoSize = true;
            lblComputer.Location = new Point(15, 32);
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new Size(170, 20);
            lblComputer.TabIndex = 0;
            lblComputer.Text = "Комп'ютер (0,15 кВт):";
            //
            // numComputer
            //
            numComputer.DecimalPlaces = 1;
            numComputer.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numComputer.Location = new Point(220, 30);
            numComputer.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numComputer.Name = "numComputer";
            numComputer.Size = new Size(125, 27);
            numComputer.TabIndex = 1;
            numComputer.Value = new decimal(new int[] { 6, 0, 0, 0 });
            numComputer.ValueChanged += Input_Changed;
            //
            // lblTv
            //
            lblTv.AutoSize = true;
            lblTv.Location = new Point(15, 67);
            lblTv.Name = "lblTv";
            lblTv.Size = new Size(160, 20);
            lblTv.TabIndex = 2;
            lblTv.Text = "Телевізор (0,1 кВт):";
            //
            // numTv
            //
            numTv.DecimalPlaces = 1;
            numTv.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numTv.Location = new Point(220, 65);
            numTv.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numTv.Name = "numTv";
            numTv.Size = new Size(125, 27);
            numTv.TabIndex = 3;
            numTv.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numTv.ValueChanged += Input_Changed;
            //
            // lblHeater
            //
            lblHeater.AutoSize = true;
            lblHeater.Location = new Point(15, 102);
            lblHeater.Name = "lblHeater";
            lblHeater.Size = new Size(195, 20);
            lblHeater.TabIndex = 4;
            lblHeater.Text = "Кондиціонер (1,5 кВт):";
            //
            // numHeater
            //
            numHeater.DecimalPlaces = 1;
            numHeater.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numHeater.Location = new Point(220, 100);
            numHeater.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numHeater.Name = "numHeater";
            numHeater.Size = new Size(125, 27);
            numHeater.TabIndex = 5;
            numHeater.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numHeater.ValueChanged += Input_Changed;
            //
            // lblKettle
            //
            lblKettle.AutoSize = true;
            lblKettle.Location = new Point(15, 137);
            lblKettle.Name = "lblKettle";
            lblKettle.Size = new Size(180, 20);
            lblKettle.TabIndex = 6;
            lblKettle.Text = "Електрочайник (2 кВт):";
            //
            // numKettle
            //
            numKettle.DecimalPlaces = 1;
            numKettle.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numKettle.Location = new Point(220, 135);
            numKettle.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numKettle.Name = "numKettle";
            numKettle.Size = new Size(125, 27);
            numKettle.TabIndex = 7;
            numKettle.Value = new decimal(new int[] { 3, 0, 0, 65536 });
            numKettle.ValueChanged += Input_Changed;
            //
            // lblWasher
            //
            lblWasher.AutoSize = true;
            lblWasher.Location = new Point(15, 172);
            lblWasher.Name = "lblWasher";
            lblWasher.Size = new Size(195, 20);
            lblWasher.TabIndex = 8;
            lblWasher.Text = "Пральна машина (0,8 кВт):";
            //
            // numWasher
            //
            numWasher.DecimalPlaces = 1;
            numWasher.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numWasher.Location = new Point(220, 170);
            numWasher.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numWasher.Name = "numWasher";
            numWasher.Size = new Size(125, 27);
            numWasher.TabIndex = 9;
            numWasher.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            numWasher.ValueChanged += Input_Changed;
            //
            // lblLighting
            //
            lblLighting.AutoSize = true;
            lblLighting.Location = new Point(15, 207);
            lblLighting.Name = "lblLighting";
            lblLighting.Size = new Size(170, 20);
            lblLighting.TabIndex = 10;
            lblLighting.Text = "Освітлення (0,1 кВт):";
            //
            // numLighting
            //
            numLighting.DecimalPlaces = 1;
            numLighting.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numLighting.Location = new Point(220, 205);
            numLighting.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numLighting.Name = "numLighting";
            numLighting.Size = new Size(125, 27);
            numLighting.TabIndex = 11;
            numLighting.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numLighting.ValueChanged += Input_Changed;
            //
            // btnCalculate
            //
            btnCalculate.Location = new Point(12, 425);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(215, 36);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Оцінити викиди";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            //
            // btnReset
            //
            btnReset.Location = new Point(237, 425);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(135, 36);
            btnReset.TabIndex = 3;
            btnReset.Text = "Скинути";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            //
            // groupBoxTotals
            //
            groupBoxTotals.Controls.Add(lblWeekCaption);
            groupBoxTotals.Controls.Add(lblWeek);
            groupBoxTotals.Controls.Add(lblMonthCaption);
            groupBoxTotals.Controls.Add(lblMonth);
            groupBoxTotals.Controls.Add(lblYearCaption);
            groupBoxTotals.Controls.Add(lblYear);
            groupBoxTotals.Controls.Add(lblTreesCaption);
            groupBoxTotals.Controls.Add(lblTrees);
            groupBoxTotals.Location = new Point(385, 12);
            groupBoxTotals.Name = "groupBoxTotals";
            groupBoxTotals.Size = new Size(420, 175);
            groupBoxTotals.TabIndex = 4;
            groupBoxTotals.TabStop = false;
            groupBoxTotals.Text = "Орієнтовні викиди CO₂";
            //
            // lblWeekCaption
            //
            lblWeekCaption.AutoSize = true;
            lblWeekCaption.Location = new Point(15, 32);
            lblWeekCaption.Name = "lblWeekCaption";
            lblWeekCaption.Size = new Size(97, 20);
            lblWeekCaption.TabIndex = 0;
            lblWeekCaption.Text = "За тиждень:";
            //
            // lblWeek
            //
            lblWeek.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWeek.Location = new Point(200, 30);
            lblWeek.Name = "lblWeek";
            lblWeek.Size = new Size(200, 25);
            lblWeek.TabIndex = 1;
            lblWeek.Text = "—";
            lblWeek.TextAlign = ContentAlignment.MiddleRight;
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
            lblMonth.Location = new Point(200, 65);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(200, 25);
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
            lblYear.ForeColor = Color.Firebrick;
            lblYear.Location = new Point(200, 100);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(200, 25);
            lblYear.TabIndex = 5;
            lblYear.Text = "—";
            lblYear.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblTreesCaption
            //
            lblTreesCaption.AutoSize = true;
            lblTreesCaption.Location = new Point(15, 137);
            lblTreesCaption.Name = "lblTreesCaption";
            lblTreesCaption.Size = new Size(175, 20);
            lblTreesCaption.TabIndex = 6;
            lblTreesCaption.Text = "Дерев для поглинання:";
            //
            // lblTrees
            //
            lblTrees.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTrees.ForeColor = Color.ForestGreen;
            lblTrees.Location = new Point(200, 135);
            lblTrees.Name = "lblTrees";
            lblTrees.Size = new Size(200, 25);
            lblTrees.TabIndex = 7;
            lblTrees.Text = "—";
            lblTrees.TextAlign = ContentAlignment.MiddleRight;
            //
            // groupBoxBreakdown
            //
            groupBoxBreakdown.Controls.Add(listViewSources);
            groupBoxBreakdown.Controls.Add(txtSummary);
            groupBoxBreakdown.Location = new Point(385, 195);
            groupBoxBreakdown.Name = "groupBoxBreakdown";
            groupBoxBreakdown.Size = new Size(420, 266);
            groupBoxBreakdown.TabIndex = 5;
            groupBoxBreakdown.TabStop = false;
            groupBoxBreakdown.Text = "Звідки беруться викиди";
            //
            // listViewSources
            //
            listViewSources.Columns.AddRange(new ColumnHeader[] { colSource, colKg, colShare });
            listViewSources.FullRowSelect = true;
            listViewSources.GridLines = true;
            listViewSources.Location = new Point(15, 28);
            listViewSources.Name = "listViewSources";
            listViewSources.Size = new Size(390, 140);
            listViewSources.TabIndex = 0;
            listViewSources.UseCompatibleStateImageBehavior = false;
            listViewSources.View = View.Details;
            //
            // colSource
            //
            colSource.Text = "Джерело";
            colSource.Width = 190;
            //
            // colKg
            //
            colKg.Text = "кг CO₂/рік";
            colKg.TextAlign = HorizontalAlignment.Right;
            colKg.Width = 100;
            //
            // colShare
            //
            colShare.Text = "Частка";
            colShare.TextAlign = HorizontalAlignment.Right;
            colShare.Width = 75;
            //
            // txtSummary
            //
            txtSummary.Location = new Point(15, 176);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(390, 76);
            txtSummary.TabIndex = 1;
            //
            // Form1
            //
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 473);
            Controls.Add(groupBoxCar);
            Controls.Add(groupBoxDevices);
            Controls.Add(btnCalculate);
            Controls.Add(btnReset);
            Controls.Add(groupBoxTotals);
            Controls.Add(groupBoxBreakdown);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор викидів CO₂";
            groupBoxCar.ResumeLayout(false);
            groupBoxCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTrips).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            groupBoxDevices.ResumeLayout(false);
            groupBoxDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numComputer).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTv).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeater).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKettle).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWasher).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLighting).EndInit();
            groupBoxTotals.ResumeLayout(false);
            groupBoxTotals.PerformLayout();
            groupBoxBreakdown.ResumeLayout(false);
            groupBoxBreakdown.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCar;
        private Label lblTrips;
        private NumericUpDown numTrips;
        private Label lblDistance;
        private NumericUpDown numDistance;
        private Label lblFuel;
        private ComboBox cmbFuel;
        private GroupBox groupBoxDevices;
        private Label lblComputer;
        private NumericUpDown numComputer;
        private Label lblTv;
        private NumericUpDown numTv;
        private Label lblHeater;
        private NumericUpDown numHeater;
        private Label lblKettle;
        private NumericUpDown numKettle;
        private Label lblWasher;
        private NumericUpDown numWasher;
        private Label lblLighting;
        private NumericUpDown numLighting;
        private Button btnCalculate;
        private Button btnReset;
        private GroupBox groupBoxTotals;
        private Label lblWeekCaption;
        private Label lblWeek;
        private Label lblMonthCaption;
        private Label lblMonth;
        private Label lblYearCaption;
        private Label lblYear;
        private Label lblTreesCaption;
        private Label lblTrees;
        private GroupBox groupBoxBreakdown;
        private ListView listViewSources;
        private ColumnHeader colSource;
        private ColumnHeader colKg;
        private ColumnHeader colShare;
        private TextBox txtSummary;
    }
}
