namespace DatabaseProject
{
    partial class CreateNewDoctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_doctor_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_doctor_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_doctor_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmd_specialty = new System.Windows.Forms.ComboBox();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_doctor_pawwrod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Name";
            // 
            // txt_doctor_name
            // 
            this.txt_doctor_name.Location = new System.Drawing.Point(142, 71);
            this.txt_doctor_name.Name = "txt_doctor_name";
            this.txt_doctor_name.Size = new System.Drawing.Size(155, 24);
            this.txt_doctor_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doctor Email";
            // 
            // txt_doctor_email
            // 
            this.txt_doctor_email.Location = new System.Drawing.Point(142, 126);
            this.txt_doctor_email.Name = "txt_doctor_email";
            this.txt_doctor_email.Size = new System.Drawing.Size(155, 24);
            this.txt_doctor_email.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doctor Address";
            // 
            // txt_doctor_address
            // 
            this.txt_doctor_address.Location = new System.Drawing.Point(142, 381);
            this.txt_doctor_address.Name = "txt_doctor_address";
            this.txt_doctor_address.Size = new System.Drawing.Size(155, 24);
            this.txt_doctor_address.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Specialty";
            // 
            // cmd_specialty
            // 
            this.cmd_specialty.FormattingEnabled = true;
            this.cmd_specialty.Location = new System.Drawing.Point(142, 312);
            this.cmd_specialty.Name = "cmd_specialty";
            this.cmd_specialty.Size = new System.Drawing.Size(155, 24);
            this.cmd_specialty.TabIndex = 6;
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Location = new System.Drawing.Point(142, 254);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(55, 21);
            this.rad_male.TabIndex = 4;
            this.rad_male.TabStop = true;
            this.rad_male.Text = "Male";
            this.rad_male.UseVisualStyleBackColor = true;
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.Location = new System.Drawing.Point(257, 254);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(71, 21);
            this.rad_female.TabIndex = 5;
            this.rad_female.TabStop = true;
            this.rad_female.Text = "Female";
            this.rad_female.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Doctor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doctor Password";
            // 
            // txt_doctor_pawwrod
            // 
            this.txt_doctor_pawwrod.Location = new System.Drawing.Point(142, 192);
            this.txt_doctor_pawwrod.Name = "txt_doctor_pawwrod";
            this.txt_doctor_pawwrod.Size = new System.Drawing.Size(155, 24);
            this.txt_doctor_pawwrod.TabIndex = 3;
            // 
            // CreateNewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rad_female);
            this.Controls.Add(this.rad_male);
            this.Controls.Add(this.cmd_specialty);
            this.Controls.Add(this.txt_doctor_pawwrod);
            this.Controls.Add(this.txt_doctor_address);
            this.Controls.Add(this.txt_doctor_email);
            this.Controls.Add(this.txt_doctor_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewDoctor";
            this.Text = "CreateNewDoctor";
            this.Load += new System.EventHandler(this.CreateNewDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_doctor_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_doctor_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_doctor_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmd_specialty;
        private System.Windows.Forms.RadioButton rad_male;
        private System.Windows.Forms.RadioButton rad_female;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_doctor_pawwrod;
    }
}