namespace College_Management_System
{
    partial class Add_Teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Teacher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtchID = new System.Windows.Forms.TextBox();
            this.richTextBoxchAddress = new System.Windows.Forms.RichTextBox();
            this.comboBoxchDuration = new System.Windows.Forms.ComboBox();
            this.comboBoxchprogramming = new System.Windows.Forms.ComboBox();
            this.comboBoxchSemester = new System.Windows.Forms.ComboBox();
            this.radioButtonchFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonchMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerchDOB = new System.Windows.Forms.DateTimePicker();
            this.txtchEmail = new System.Windows.Forms.TextBox();
            this.txtchMobile = new System.Windows.Forms.TextBox();
            this.txtchFullName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btuReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(230, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(349, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Basic Informations";
            // 
            // txtchID
            // 
            this.txtchID.Location = new System.Drawing.Point(181, 145);
            this.txtchID.Multiline = true;
            this.txtchID.Name = "txtchID";
            this.txtchID.Size = new System.Drawing.Size(165, 25);
            this.txtchID.TabIndex = 62;
            // 
            // richTextBoxchAddress
            // 
            this.richTextBoxchAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxchAddress.Location = new System.Drawing.Point(583, 407);
            this.richTextBoxchAddress.Name = "richTextBoxchAddress";
            this.richTextBoxchAddress.Size = new System.Drawing.Size(208, 96);
            this.richTextBoxchAddress.TabIndex = 61;
            this.richTextBoxchAddress.Text = "";
            // 
            // comboBoxchDuration
            // 
            this.comboBoxchDuration.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxchDuration.FormattingEnabled = true;
            this.comboBoxchDuration.Items.AddRange(new object[] {
            "2020-2024",
            "2024-2028"});
            this.comboBoxchDuration.Location = new System.Drawing.Point(613, 329);
            this.comboBoxchDuration.Name = "comboBoxchDuration";
            this.comboBoxchDuration.Size = new System.Drawing.Size(161, 26);
            this.comboBoxchDuration.TabIndex = 60;
            this.comboBoxchDuration.Text = "--Select--";
            // 
            // comboBoxchprogramming
            // 
            this.comboBoxchprogramming.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxchprogramming.FormattingEnabled = true;
            this.comboBoxchprogramming.Items.AddRange(new object[] {
            "C Programming",
            "C++",
            "Java",
            "JSP",
            "C#(C sharp)",
            "Python",
            "PHP"});
            this.comboBoxchprogramming.Location = new System.Drawing.Point(613, 265);
            this.comboBoxchprogramming.Name = "comboBoxchprogramming";
            this.comboBoxchprogramming.Size = new System.Drawing.Size(161, 26);
            this.comboBoxchprogramming.TabIndex = 59;
            this.comboBoxchprogramming.Text = "--Select--";
            // 
            // comboBoxchSemester
            // 
            this.comboBoxchSemester.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxchSemester.FormattingEnabled = true;
            this.comboBoxchSemester.Items.AddRange(new object[] {
            "1st sem",
            "2nd sem",
            "3rd sem",
            "4th sem",
            "5th sem",
            "6th sem",
            "7th sem",
            "8th sem"});
            this.comboBoxchSemester.Location = new System.Drawing.Point(613, 201);
            this.comboBoxchSemester.Name = "comboBoxchSemester";
            this.comboBoxchSemester.Size = new System.Drawing.Size(161, 26);
            this.comboBoxchSemester.TabIndex = 58;
            this.comboBoxchSemester.Text = "--Select--";
            // 
            // radioButtonchFemale
            // 
            this.radioButtonchFemale.AutoSize = true;
            this.radioButtonchFemale.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonchFemale.Location = new System.Drawing.Point(255, 266);
            this.radioButtonchFemale.Name = "radioButtonchFemale";
            this.radioButtonchFemale.Size = new System.Drawing.Size(73, 22);
            this.radioButtonchFemale.TabIndex = 57;
            this.radioButtonchFemale.TabStop = true;
            this.radioButtonchFemale.Text = "Female";
            this.radioButtonchFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonchMale
            // 
            this.radioButtonchMale.AutoSize = true;
            this.radioButtonchMale.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonchMale.Location = new System.Drawing.Point(183, 265);
            this.radioButtonchMale.Name = "radioButtonchMale";
            this.radioButtonchMale.Size = new System.Drawing.Size(56, 22);
            this.radioButtonchMale.TabIndex = 56;
            this.radioButtonchMale.TabStop = true;
            this.radioButtonchMale.Text = "Male";
            this.radioButtonchMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerchDOB
            // 
            this.dateTimePickerchDOB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerchDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerchDOB.Location = new System.Drawing.Point(181, 340);
            this.dateTimePickerchDOB.Name = "dateTimePickerchDOB";
            this.dateTimePickerchDOB.Size = new System.Drawing.Size(165, 26);
            this.dateTimePickerchDOB.TabIndex = 55;
            // 
            // txtchEmail
            // 
            this.txtchEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchEmail.Location = new System.Drawing.Point(613, 142);
            this.txtchEmail.Name = "txtchEmail";
            this.txtchEmail.Size = new System.Drawing.Size(165, 26);
            this.txtchEmail.TabIndex = 53;
            // 
            // txtchMobile
            // 
            this.txtchMobile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchMobile.Location = new System.Drawing.Point(177, 407);
            this.txtchMobile.Name = "txtchMobile";
            this.txtchMobile.Size = new System.Drawing.Size(165, 26);
            this.txtchMobile.TabIndex = 52;
            this.txtchMobile.TextChanged += new System.EventHandler(this.TxtMobile_TextChanged);
            // 
            // txtchFullName
            // 
            this.txtchFullName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchFullName.Location = new System.Drawing.Point(181, 201);
            this.txtchFullName.Name = "txtchFullName";
            this.txtchFullName.Size = new System.Drawing.Size(165, 26);
            this.txtchFullName.TabIndex = 50;
            this.txtchFullName.TextChanged += new System.EventHandler(this.TxtFullName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(276, 476);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 27);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Submit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(470, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 47;
            this.label12.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(470, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 23);
            this.label11.TabIndex = 46;
            this.label11.Text = "Duration(Year)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(470, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 23);
            this.label9.TabIndex = 44;
            this.label9.Text = "Programming";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(470, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Email ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Mobile No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Date of Brith";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Full Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(58, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 23);
            this.label13.TabIndex = 63;
            this.label13.Text = "Teacher ID";
            // 
            // btuReset
            // 
            this.btuReset.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btuReset.Location = new System.Drawing.Point(402, 476);
            this.btuReset.Name = "btuReset";
            this.btuReset.Size = new System.Drawing.Size(81, 27);
            this.btuReset.TabIndex = 64;
            this.btuReset.Text = "Reset";
            this.btuReset.UseVisualStyleBackColor = true;
            this.btuReset.Click += new System.EventHandler(this.BtuReset_Click);
            // 
            // Add_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 525);
            this.Controls.Add(this.btuReset);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtchID);
            this.Controls.Add(this.richTextBoxchAddress);
            this.Controls.Add(this.comboBoxchDuration);
            this.Controls.Add(this.comboBoxchprogramming);
            this.Controls.Add(this.comboBoxchSemester);
            this.Controls.Add(this.radioButtonchFemale);
            this.Controls.Add(this.radioButtonchMale);
            this.Controls.Add(this.dateTimePickerchDOB);
            this.Controls.Add(this.txtchEmail);
            this.Controls.Add(this.txtchMobile);
            this.Controls.Add(this.txtchFullName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Add_Teacher";
            this.Text = "Add_Teacher";
            this.Load += new System.EventHandler(this.Add_Teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtchID;
        private System.Windows.Forms.RichTextBox richTextBoxchAddress;
        private System.Windows.Forms.ComboBox comboBoxchDuration;
        private System.Windows.Forms.ComboBox comboBoxchprogramming;
        private System.Windows.Forms.ComboBox comboBoxchSemester;
        private System.Windows.Forms.RadioButton radioButtonchFemale;
        private System.Windows.Forms.RadioButton radioButtonchMale;
        private System.Windows.Forms.DateTimePicker dateTimePickerchDOB;
        private System.Windows.Forms.TextBox txtchEmail;
        private System.Windows.Forms.TextBox txtchMobile;
        private System.Windows.Forms.TextBox txtchFullName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btuReset;
    }
}