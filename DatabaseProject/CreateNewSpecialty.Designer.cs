﻿namespace DatabaseProject
{
    partial class CreateNewSpecialty
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
            this.txt_specialty_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Specialty";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_specialty_name
            // 
            this.txt_specialty_name.Location = new System.Drawing.Point(169, 35);
            this.txt_specialty_name.Name = "txt_specialty_name";
            this.txt_specialty_name.Size = new System.Drawing.Size(155, 24);
            this.txt_specialty_name.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Specialty Name";
            // 
            // CreateNewSpecialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_specialty_name);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewSpecialty";
            this.Text = "CreateNewSpecialty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_specialty_name;
        private System.Windows.Forms.Label label1;
    }
}