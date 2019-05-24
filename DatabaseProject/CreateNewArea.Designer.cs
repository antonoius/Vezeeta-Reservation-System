namespace DatabaseProject
{
    partial class CreateNewArea
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
            this.txt_area_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_area_name
            // 
            this.txt_area_name.Location = new System.Drawing.Point(166, 35);
            this.txt_area_name.Name = "txt_area_name";
            this.txt_area_name.Size = new System.Drawing.Size(155, 24);
            this.txt_area_name.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Area Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Area";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CreateNewArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_area_name);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewArea";
            this.Text = "CreateNewArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_area_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}