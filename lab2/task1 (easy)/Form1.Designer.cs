using System.Drawing;
using System.Windows.Forms;

namespace task1__easy_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelWeight;
        private Label labelHeight;
        private TextBox textBoxWeight;
        private TextBox textBoxHeight;
        private Button buttonCalculate;
        private Label labelValue;
        
        /// <summary>
        ///  Required designer variable.
        /// </summary>

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
            components = new System.ComponentModel.Container();
            labelWeight = new Label();
            labelHeight = new Label();
            textBoxWeight = new TextBox();
            textBoxHeight = new TextBox();
            buttonCalculate = new Button();
            labelValue = new Label();
            SuspendLayout();
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(34, 34);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(95, 20);
            labelWeight.TabIndex = 0;
            labelWeight.Text = "Вага (кг):";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(34, 78);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(120, 20);
            labelHeight.TabIndex = 1;
            labelHeight.Text = "Зріст (см):";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(170, 31);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(150, 27);
            textBoxWeight.TabIndex = 2;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(170, 75);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(150, 27);
            textBoxHeight.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(34, 125);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(286, 35);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Розрахувати ІМТ";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(34, 182);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(0, 20);
            labelValue.TabIndex = 5;
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 260);
            Controls.Add(labelValue);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWeight);
            Controls.Add(labelHeight);
            Controls.Add(labelWeight);
            Name = "Form1";
            Text = "ІМТ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
