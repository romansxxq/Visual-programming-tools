namespace lab5
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
            lblSalary = new Label();
            txtSalary = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lstSubscriptions = new ListBox();
            lblTotal = new Label();
            lblRemaining = new Label();
            SuspendLayout();
            //
            // lblSalary
            //
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(20, 23);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(83, 15);
            lblSalary.Text = "Зарплата (грн):";
            //
            // txtSalary
            //
            txtSalary.Location = new Point(150, 20);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(150, 23);
            txtSalary.TabIndex = 0;
            txtSalary.TextChanged += txtSalary_TextChanged;
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 63);
            lblName.Name = "lblName";
            lblName.Size = new Size(98, 15);
            lblName.Text = "Назва підписки:";
            //
            // txtName
            //
            txtName.Location = new Point(150, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 1;
            //
            // lblPrice
            //
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 103);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(95, 15);
            lblPrice.Text = "Ціна (грн/міс):";
            //
            // txtPrice
            //
            txtPrice.Location = new Point(150, 100);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 23);
            txtPrice.TabIndex = 2;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(150, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 30);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Додати підписку";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            //
            // btnRemove
            //
            btnRemove.Location = new Point(330, 250);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(250, 30);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Видалити вибрану";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            //
            // lstSubscriptions
            //
            lstSubscriptions.FormattingEnabled = true;
            lstSubscriptions.Location = new Point(330, 20);
            lstSubscriptions.Name = "lstSubscriptions";
            lstSubscriptions.Size = new Size(250, 214);
            lstSubscriptions.TabIndex = 4;
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(20, 200);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(200, 19);
            lblTotal.Text = "Витрати на місяць: 0,00 грн";
            //
            // lblRemaining
            //
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRemaining.Location = new Point(20, 230);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(160, 19);
            lblRemaining.Text = "Залишиться: 0,00 грн";
            //
            // Form1
            //
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 300);
            Controls.Add(lblSalary);
            Controls.Add(txtSalary);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(btnAdd);
            Controls.Add(lstSubscriptions);
            Controls.Add(btnRemove);
            Controls.Add(lblTotal);
            Controls.Add(lblRemaining);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бюджет підписок";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalary;
        private TextBox txtSalary;
        private Label lblName;
        private TextBox txtName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnRemove;
        private ListBox lstSubscriptions;
        private Label lblTotal;
        private Label lblRemaining;
    }
}
