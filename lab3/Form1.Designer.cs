namespace lab3
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            studentNameLabel = new Label();
            studentNameBox = new TextBox();
            studentSurnameBox = new TextBox();
            studentSurnameLabel = new Label();
            studentMiddleNameBox = new TextBox();
            studentMiddleNameLabel = new Label();
            StudentDateBitrhdayPicker = new DateTimePicker();
            studentDateBirthdayLabel = new Label();
            ManRadioButton = new RadioButton();
            FemaleRadioButton = new RadioButton();
            studentGenderLabel = new Label();
            MajorsComboBox = new ComboBox();
            studentMajorLabel = new Label();
            MainLabel = new Label();
            StudentSignUpButton = new Button();
            SuspendLayout();
            // 
            // studentNameLabel
            // 
            resources.ApplyResources(studentNameLabel, "studentNameLabel");
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Click += studentName_Click;
            // 
            // studentNameBox
            // 
            resources.ApplyResources(studentNameBox, "studentNameBox");
            studentNameBox.Name = "studentNameBox";
            // 
            // studentSurnameBox
            // 
            resources.ApplyResources(studentSurnameBox, "studentSurnameBox");
            studentSurnameBox.Name = "studentSurnameBox";
            studentSurnameBox.TextChanged += textBox2_TextChanged;
            // 
            // studentSurnameLabel
            // 
            resources.ApplyResources(studentSurnameLabel, "studentSurnameLabel");
            studentSurnameLabel.Name = "studentSurnameLabel";
            studentSurnameLabel.Click += studentName_Click;
            // 
            // studentMiddleNameBox
            // 
            resources.ApplyResources(studentMiddleNameBox, "studentMiddleNameBox");
            studentMiddleNameBox.Name = "studentMiddleNameBox";
            studentMiddleNameBox.TextChanged += textBox3_TextChanged;
            // 
            // studentMiddleNameLabel
            // 
            resources.ApplyResources(studentMiddleNameLabel, "studentMiddleNameLabel");
            studentMiddleNameLabel.Name = "studentMiddleNameLabel";
            studentMiddleNameLabel.Click += studentName_Click_1;
            // 
            // StudentDateBitrhdayPicker
            //
            resources.ApplyResources(StudentDateBitrhdayPicker, "StudentDateBitrhdayPicker");
            StudentDateBitrhdayPicker.MaxDate = DateTime.Now;
            StudentDateBitrhdayPicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            StudentDateBitrhdayPicker.Name = "StudentDateBitrhdayPicker";
            StudentDateBitrhdayPicker.Value = new DateTime(2026, 9, 6, 0, 0, 0, 0);
            // 
            // studentDateBirthdayLabel
            // 
            resources.ApplyResources(studentDateBirthdayLabel, "studentDateBirthdayLabel");
            studentDateBirthdayLabel.ForeColor = SystemColors.ControlText;
            studentDateBirthdayLabel.Name = "studentDateBirthdayLabel";
            studentDateBirthdayLabel.Click += label1_Click;
            // 
            // ManRadioButton
            // 
            resources.ApplyResources(ManRadioButton, "ManRadioButton");
            ManRadioButton.Name = "ManRadioButton";
            ManRadioButton.TabStop = true;
            ManRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            resources.ApplyResources(FemaleRadioButton, "FemaleRadioButton");
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentGenderLabel
            // 
            resources.ApplyResources(studentGenderLabel, "studentGenderLabel");
            studentGenderLabel.Name = "studentGenderLabel";
            // 
            // MajorsComboBox
            // 
            resources.ApplyResources(MajorsComboBox, "MajorsComboBox");
            MajorsComboBox.FormattingEnabled = true;
            MajorsComboBox.Name = "MajorsComboBox";
            string[] majors = { "121 Інженерія програмного забезпечення", "122 Комп’ютерні науки", "181 Харчові технології", "124 Інформаційні системи та технології", "125 Кібербезпека", "126 Математика та статистика", "127 Фізика та астрономія", "128 Хімія та біохімія", "129 Біологія та екологія" };
            MajorsComboBox.Items.AddRange(majors);
            // 
            // studentMajorLabel
            // 
            resources.ApplyResources(studentMajorLabel, "studentMajorLabel");
            studentMajorLabel.Name = "studentMajorLabel";
            studentMajorLabel.Click += label2_Click;
            // 
            // MainLabel
            // 
            resources.ApplyResources(MainLabel, "MainLabel");
            MainLabel.Name = "MainLabel";
            MainLabel.Click += label1_Click_1;
            // 
            // StudentSignUpButton
            // 
            resources.ApplyResources(StudentSignUpButton, "StudentSignUpButton");
            StudentSignUpButton.Name = "StudentSignUpButton";
            StudentSignUpButton.UseVisualStyleBackColor = true;
            StudentSignUpButton.Click += StudentSignUpButton_Click;
            // 
            // Registration
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StudentSignUpButton);
            Controls.Add(MainLabel);
            Controls.Add(studentMajorLabel);
            Controls.Add(MajorsComboBox);
            Controls.Add(studentGenderLabel);
            Controls.Add(FemaleRadioButton);
            Controls.Add(ManRadioButton);
            Controls.Add(studentDateBirthdayLabel);
            Controls.Add(StudentDateBitrhdayPicker);
            Controls.Add(studentMiddleNameBox);
            Controls.Add(studentMiddleNameLabel);
            Controls.Add(studentSurnameBox);
            Controls.Add(studentSurnameLabel);
            Controls.Add(studentNameBox);
            Controls.Add(studentNameLabel);
            Name = "Registration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentNameLabel;
        private TextBox studentNameBox;
        private TextBox studentSurnameBox;
        private Label studentSurnameLabel;
        private TextBox studentMiddleNameBox;
        private Label studentMiddleNameLabel;
        private DateTimePicker StudentDateBitrhdayPicker;
        private Label studentDateBirthdayLabel;
        private RadioButton ManRadioButton;
        private RadioButton FemaleRadioButton;
        private Label studentGenderLabel;
        private ComboBox MajorsComboBox;
        private Label studentMajorLabel;
        private Label MainLabel;
        private Button StudentSignUpButton;

    }
}
