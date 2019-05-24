namespace DatabaseProject
{
    partial class ReviewDoctor
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
            this.Review = new System.Windows.Forms.Label();
            this.txt_rev = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Review
            // 
            this.Review.AutoSize = true;
            this.Review.Location = new System.Drawing.Point(43, 84);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(51, 17);
            this.Review.TabIndex = 0;
            this.Review.Text = "Review";
            // 
            // txt_rev
            // 
            this.txt_rev.Location = new System.Drawing.Point(109, 84);
            this.txt_rev.Name = "txt_rev";
            this.txt_rev.Size = new System.Drawing.Size(361, 182);
            this.txt_rev.TabIndex = 1;
            this.txt_rev.Text = "";
            this.txt_rev.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submet Review";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReviewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_rev);
            this.Controls.Add(this.Review);
            this.Name = "ReviewDoctor";
            this.Text = "ReviewDoctor";
            this.Load += new System.EventHandler(this.ReviewDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Review;
        private System.Windows.Forms.RichTextBox txt_rev;
        private System.Windows.Forms.Button button1;
    }
}