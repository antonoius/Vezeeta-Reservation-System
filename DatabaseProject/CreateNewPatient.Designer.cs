namespace DatabaseProject
{
    partial class CreateNewPatient
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
            this.button1 = new System.Windows.Forms.Button();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.txt_Patient_pawwrod = new System.Windows.Forms.TextBox();
            this.txt_Patient_address = new System.Windows.Forms.TextBox();
            this.txt_Patient_email = new System.Windows.Forms.TextBox();
            this.txt_Patient_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_patient_tel = new System.Windows.Forms.TextBox();
            this.cmb_area = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 59);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.Location = new System.Drawing.Point(269, 250);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(71, 21);
            this.rad_female.TabIndex = 19;
            this.rad_female.TabStop = true;
            this.rad_female.Text = "Female";
            this.rad_female.UseVisualStyleBackColor = true;
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Location = new System.Drawing.Point(154, 250);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(55, 21);
            this.rad_male.TabIndex = 18;
            this.rad_male.TabStop = true;
            this.rad_male.Text = "Male";
            this.rad_male.UseVisualStyleBackColor = true;
            // 
            // txt_Patient_pawwrod
            // 
            this.txt_Patient_pawwrod.Location = new System.Drawing.Point(154, 197);
            this.txt_Patient_pawwrod.Name = "txt_Patient_pawwrod";
            this.txt_Patient_pawwrod.Size = new System.Drawing.Size(155, 24);
            this.txt_Patient_pawwrod.TabIndex = 17;
            // 
            // txt_Patient_address
            // 
            this.txt_Patient_address.Location = new System.Drawing.Point(154, 367);
            this.txt_Patient_address.Name = "txt_Patient_address";
            this.txt_Patient_address.Size = new System.Drawing.Size(155, 24);
            this.txt_Patient_address.TabIndex = 21;
            this.txt_Patient_address.TextChanged += new System.EventHandler(this.txt_doctor_address_TextChanged);
            // 
            // txt_Patient_email
            // 
            this.txt_Patient_email.Location = new System.Drawing.Point(154, 103);
            this.txt_Patient_email.Name = "txt_Patient_email";
            this.txt_Patient_email.Size = new System.Drawing.Size(155, 24);
            this.txt_Patient_email.TabIndex = 16;
            // 
            // txt_Patient_name
            // 
            this.txt_Patient_name.Location = new System.Drawing.Point(154, 48);
            this.txt_Patient_name.Name = "txt_Patient_name";
            this.txt_Patient_name.Size = new System.Drawing.Size(155, 24);
            this.txt_Patient_name.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Patient Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Patient Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Patient Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Patient Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Patient Tel";
            // 
            // txt_patient_tel
            // 
            this.txt_patient_tel.Location = new System.Drawing.Point(154, 157);
            this.txt_patient_tel.Name = "txt_patient_tel";
            this.txt_patient_tel.Size = new System.Drawing.Size(155, 24);
            this.txt_patient_tel.TabIndex = 17;
            // 
            // cmb_area
            // 
            this.cmb_area.FormattingEnabled = true;
            this.cmb_area.Location = new System.Drawing.Point(156, 295);
            this.cmb_area.Name = "cmb_area";
            this.cmb_area.Size = new System.Drawing.Size(155, 24);
            this.cmb_area.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Area";
            // 
            // CreateNewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 591);
            this.Controls.Add(this.cmb_area);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rad_female);
            this.Controls.Add(this.rad_male);
            this.Controls.Add(this.txt_patient_tel);
            this.Controls.Add(this.txt_Patient_pawwrod);
            this.Controls.Add(this.txt_Patient_address);
            this.Controls.Add(this.txt_Patient_email);
            this.Controls.Add(this.txt_Patient_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewPatient";
            this.Text = "CreateNewPatient";
            this.Load += new System.EventHandler(this.CreateNewPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rad_female;
        private System.Windows.Forms.RadioButton rad_male;
        private System.Windows.Forms.TextBox txt_Patient_pawwrod;
        private System.Windows.Forms.TextBox txt_Patient_address;
        private System.Windows.Forms.TextBox txt_Patient_email;
        private System.Windows.Forms.TextBox txt_Patient_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_patient_tel;
        private System.Windows.Forms.ComboBox cmb_area;
        private System.Windows.Forms.Label label7;
    }
}