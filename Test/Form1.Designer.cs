namespace Test
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
            lblDistance = new Label();
            txtDistance = new TextBox();
            lblTariff = new Label();
            cboTariff = new ComboBox();
            chkNightTariff = new CheckBox();
            chkChildSeat = new CheckBox();
            lblPromoCode = new Label();
            txtPromoCode = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            lblResultCaption = new Label();
            lblResultValue = new Label();
            SuspendLayout();
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(24, 24);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(218, 20);
            lblDistance.TabIndex = 0;
            lblDistance.Text = "Відстань поїздки (км):";
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(24, 47);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(220, 27);
            txtDistance.TabIndex = 1;
            // 
            // lblTariff
            // 
            lblTariff.AutoSize = true;
            lblTariff.Location = new Point(24, 88);
            lblTariff.Name = "lblTariff";
            lblTariff.Size = new Size(133, 20);
            lblTariff.TabIndex = 2;
            lblTariff.Text = "Обрати тариф:";
            // 
            // cboTariff
            // 
            cboTariff.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTariff.FormattingEnabled = true;
            cboTariff.Location = new Point(24, 111);
            cboTariff.Name = "cboTariff";
            cboTariff.Size = new Size(220, 28);
            cboTariff.TabIndex = 3;
            // 
            // chkNightTariff
            // 
            chkNightTariff.AutoSize = true;
            chkNightTariff.Location = new Point(24, 155);
            chkNightTariff.Name = "chkNightTariff";
            chkNightTariff.Size = new Size(134, 24);
            chkNightTariff.TabIndex = 4;
            chkNightTariff.Text = "Нічний тариф";
            chkNightTariff.UseVisualStyleBackColor = true;
            // 
            // chkChildSeat
            // 
            chkChildSeat.AutoSize = true;
            chkChildSeat.Location = new Point(24, 189);
            chkChildSeat.Name = "chkChildSeat";
            chkChildSeat.Size = new Size(127, 24);
            chkChildSeat.TabIndex = 5;
            chkChildSeat.Text = "Дитяче крісло";
            chkChildSeat.UseVisualStyleBackColor = true;
            // 
            // lblPromoCode
            // 
            lblPromoCode.AutoSize = true;
            lblPromoCode.Location = new Point(24, 228);
            lblPromoCode.Name = "lblPromoCode";
            lblPromoCode.Size = new Size(184, 20);
            lblPromoCode.TabIndex = 6;
            lblPromoCode.Text = "Промокод (необов'язково):";
            // 
            // txtPromoCode
            // 
            txtPromoCode.CharacterCasing = CharacterCasing.Upper;
            txtPromoCode.Location = new Point(24, 251);
            txtPromoCode.Name = "txtPromoCode";
            txtPromoCode.Size = new Size(220, 27);
            txtPromoCode.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(272, 47);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(140, 40);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Розрахувати";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(272, 99);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 40);
            btnClear.TabIndex = 9;
            btnClear.Text = "Очистити";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblResultCaption
            // 
            lblResultCaption.AutoSize = true;
            lblResultCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultCaption.Location = new Point(24, 304);
            lblResultCaption.Name = "lblResultCaption";
            lblResultCaption.Size = new Size(165, 23);
            lblResultCaption.TabIndex = 10;
            lblResultCaption.Text = "Вартість поїздки:";
            // 
            // lblResultValue
            // 
            lblResultValue.AutoSize = true;
            lblResultValue.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultValue.Location = new Point(195, 304);
            lblResultValue.Name = "lblResultValue";
            lblResultValue.Size = new Size(27, 23);
            lblResultValue.TabIndex = 11;
            lblResultValue.Text = "—";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 354);
            Controls.Add(lblResultValue);
            Controls.Add(lblResultCaption);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtPromoCode);
            Controls.Add(lblPromoCode);
            Controls.Add(chkChildSeat);
            Controls.Add(chkNightTariff);
            Controls.Add(cboTariff);
            Controls.Add(lblTariff);
            Controls.Add(txtDistance);
            Controls.Add(lblDistance);
            MinimumSize = new Size(466, 401);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор вартості поїздки на таксі";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistance;
        private TextBox txtDistance;
        private Label lblTariff;
        private ComboBox cboTariff;
        private CheckBox chkNightTariff;
        private CheckBox chkChildSeat;
        private Label lblPromoCode;
        private TextBox txtPromoCode;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblResultCaption;
        private Label lblResultValue;
    }
}
