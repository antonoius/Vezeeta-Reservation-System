namespace DatabaseProject
{
    partial class EditAppointment
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
            this.cmb_clinic = new System.Windows.Forms.ComboBox();
            this.txt_max_number = new System.Windows.Forms.TextBox();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_clinic
            // 
            this.cmb_clinic.FormattingEnabled = true;
            this.cmb_clinic.Location = new System.Drawing.Point(240, 226);
            this.cmb_clinic.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmb_clinic.Name = "cmb_clinic";
            this.cmb_clinic.Size = new System.Drawing.Size(394, 32);
            this.cmb_clinic.TabIndex = 16;
            // 
            // txt_max_number
            // 
            this.txt_max_number.Location = new System.Drawing.Point(240, 318);
            this.txt_max_number.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_max_number.Name = "txt_max_number";
            this.txt_max_number.Size = new System.Drawing.Size(394, 32);
            this.txt_max_number.TabIndex = 15;
            // 
            // dt_end
            // 
            this.dt_end.Location = new System.Drawing.Point(240, 150);
            this.dt_end.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(471, 32);
            this.dt_end.TabIndex = 13;
            // 
            // dt_start
            // 
            this.dt_start.CustomFormat = "";
            this.dt_start.Location = new System.Drawing.Point(240, 47);
            this.dt_start.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(471, 32);
            this.dt_start.TabIndex = 14;
            this.dt_start.ValueChanged += new System.EventHandler(this.dt_start_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "End Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 318);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Max patient Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 226);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Clinic";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Start Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_clinic);
            this.Controls.Add(this.txt_max_number);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.dt_start);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "EditAppointment";
            this.Text = "EditAppointment";
            this.Load += new System.EventHandler(this.EditAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_clinic;
        private System.Windows.Forms.TextBox txt_max_number;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}