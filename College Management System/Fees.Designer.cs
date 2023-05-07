namespace College_Management_System
{
    partial class Fees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fees));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegestration = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.labfull = new System.Windows.Forms.Label();
            this.labmother = new System.Windows.Forms.Label();
            this.labduration = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Regestration Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mother Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fees";
            // 
            // txtRegestration
            // 
            this.txtRegestration.Location = new System.Drawing.Point(215, 230);
            this.txtRegestration.Multiline = true;
            this.txtRegestration.Name = "txtRegestration";
            this.txtRegestration.Size = new System.Drawing.Size(211, 28);
            this.txtRegestration.TabIndex = 7;
            this.txtRegestration.TextChanged += new System.EventHandler(this.TxtRegestration_TextChanged);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(267, 462);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 28);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "Submit";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(206, 398);
            this.txtFees.Multiline = true;
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(220, 24);
            this.txtFees.TabIndex = 9;
            this.txtFees.TextChanged += new System.EventHandler(this.TxtFees_TextChanged);
            // 
            // labfull
            // 
            this.labfull.AutoSize = true;
            this.labfull.Location = new System.Drawing.Point(212, 288);
            this.labfull.Name = "labfull";
            this.labfull.Size = new System.Drawing.Size(55, 13);
            this.labfull.TabIndex = 10;
            this.labfull.Text = "________";
            this.labfull.Click += new System.EventHandler(this.Labfull_Click);
            // 
            // labmother
            // 
            this.labmother.AutoSize = true;
            this.labmother.Location = new System.Drawing.Point(212, 326);
            this.labmother.Name = "labmother";
            this.labmother.Size = new System.Drawing.Size(55, 13);
            this.labmother.TabIndex = 11;
            this.labmother.Text = "________";
            this.labmother.Click += new System.EventHandler(this.Label7_Click);
            // 
            // labduration
            // 
            this.labduration.AutoSize = true;
            this.labduration.Location = new System.Drawing.Point(212, 361);
            this.labduration.Name = "labduration";
            this.labduration.Size = new System.Drawing.Size(55, 13);
            this.labduration.TabIndex = 12;
            this.labduration.Text = "________";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(67, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(341, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 518);
            this.Controls.Add(this.labduration);
            this.Controls.Add(this.labmother);
            this.Controls.Add(this.labfull);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtRegestration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Fees";
            this.Text = "Fees";
            this.Load += new System.EventHandler(this.Fees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegestration;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label labfull;
        private System.Windows.Forms.Label labmother;
        private System.Windows.Forms.Label labduration;
    }
}