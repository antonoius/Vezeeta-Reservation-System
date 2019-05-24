namespace DatabaseProject
{
    partial class AdminPage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_admin_name = new System.Windows.Forms.TextBox();
            this.txt_admin_email = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.txt_admin_password = new System.Windows.Forms.TextBox();
            this.txt_clinic_address = new System.Windows.Forms.TextBox();
            this.txt_clinic_email = new System.Windows.Forms.TextBox();
            this.txt_clinic_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dt_appoint = new System.Windows.Forms.DateTimePicker();
            this.dgv_appoint = new System.Windows.Forms.DataGridView();
            this.dgv_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_max_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_current_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_spec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.dgv_patient_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_book_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_book_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_can_book = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmb_books_appointment = new System.Windows.Forms.ComboBox();
            this.dt_books = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dt_report_day = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appoint)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1417, 713);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txt_admin_name);
            this.tabPage1.Controls.Add(this.txt_admin_email);
            this.tabPage1.Controls.Add(this.txt_area);
            this.tabPage1.Controls.Add(this.txt_admin_password);
            this.tabPage1.Controls.Add(this.txt_clinic_address);
            this.tabPage1.Controls.Add(this.txt_clinic_email);
            this.tabPage1.Controls.Add(this.txt_clinic_name);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1143, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 54);
            this.button3.TabIndex = 38;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_admin_name
            // 
            this.txt_admin_name.Location = new System.Drawing.Point(244, 166);
            this.txt_admin_name.Name = "txt_admin_name";
            this.txt_admin_name.Size = new System.Drawing.Size(266, 35);
            this.txt_admin_name.TabIndex = 30;
            // 
            // txt_admin_email
            // 
            this.txt_admin_email.Location = new System.Drawing.Point(244, 222);
            this.txt_admin_email.Name = "txt_admin_email";
            this.txt_admin_email.ReadOnly = true;
            this.txt_admin_email.Size = new System.Drawing.Size(266, 35);
            this.txt_admin_email.TabIndex = 31;
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(244, 330);
            this.txt_area.Name = "txt_area";
            this.txt_area.ReadOnly = true;
            this.txt_area.Size = new System.Drawing.Size(266, 35);
            this.txt_area.TabIndex = 32;
            this.txt_area.TextChanged += new System.EventHandler(this.txt_admin_password_TextChanged);
            // 
            // txt_admin_password
            // 
            this.txt_admin_password.Location = new System.Drawing.Point(244, 272);
            this.txt_admin_password.Name = "txt_admin_password";
            this.txt_admin_password.Size = new System.Drawing.Size(266, 35);
            this.txt_admin_password.TabIndex = 32;
            this.txt_admin_password.TextChanged += new System.EventHandler(this.txt_admin_password_TextChanged);
            // 
            // txt_clinic_address
            // 
            this.txt_clinic_address.Location = new System.Drawing.Point(244, 389);
            this.txt_clinic_address.Name = "txt_clinic_address";
            this.txt_clinic_address.Size = new System.Drawing.Size(266, 35);
            this.txt_clinic_address.TabIndex = 34;
            // 
            // txt_clinic_email
            // 
            this.txt_clinic_email.Location = new System.Drawing.Point(244, 104);
            this.txt_clinic_email.Name = "txt_clinic_email";
            this.txt_clinic_email.Size = new System.Drawing.Size(266, 35);
            this.txt_clinic_email.TabIndex = 35;
            // 
            // txt_clinic_name
            // 
            this.txt_clinic_name.Location = new System.Drawing.Point(244, 49);
            this.txt_clinic_name.Name = "txt_clinic_name";
            this.txt_clinic_name.Size = new System.Drawing.Size(266, 35);
            this.txt_clinic_name.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 29);
            this.label14.TabIndex = 22;
            this.label14.Text = "Area";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 29);
            this.label15.TabIndex = 24;
            this.label15.Text = "Admin Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 29);
            this.label17.TabIndex = 25;
            this.label17.Text = "Admin Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 278);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(187, 29);
            this.label18.TabIndex = 26;
            this.label18.Text = "Admin Password";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 395);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(157, 29);
            this.label19.TabIndex = 27;
            this.label19.Text = "Clinic address";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 29);
            this.label20.TabIndex = 28;
            this.label20.Text = "Clinic Email";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 29);
            this.label21.TabIndex = 29;
            this.label21.Text = "Clinic Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dt_appoint);
            this.tabPage3.Controls.Add(this.dgv_appoint);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1459, 649);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Appointments";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dt_appoint
            // 
            this.dt_appoint.Location = new System.Drawing.Point(27, 82);
            this.dt_appoint.Name = "dt_appoint";
            this.dt_appoint.Size = new System.Drawing.Size(394, 35);
            this.dt_appoint.TabIndex = 1;
            this.dt_appoint.ValueChanged += new System.EventHandler(this.dt_appoint_ValueChanged);
            // 
            // dgv_appoint
            // 
            this.dgv_appoint.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_appoint.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_appoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_appoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_day,
            this.dgv_start_time,
            this.dgv_end_time,
            this.dgv_doc,
            this.dgv_max_number,
            this.dgv_current_number,
            this.dgv_spec});
            this.dgv_appoint.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_appoint.Location = new System.Drawing.Point(27, 155);
            this.dgv_appoint.Name = "dgv_appoint";
            this.dgv_appoint.RowTemplate.Height = 26;
            this.dgv_appoint.Size = new System.Drawing.Size(1423, 478);
            this.dgv_appoint.TabIndex = 0;
            this.dgv_appoint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_appoint_CellContentClick);
            // 
            // dgv_day
            // 
            this.dgv_day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_day.HeaderText = "Day";
            this.dgv_day.Name = "dgv_day";
            this.dgv_day.Width = 83;
            // 
            // dgv_start_time
            // 
            this.dgv_start_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_start_time.HeaderText = "Start Time";
            this.dgv_start_time.Name = "dgv_start_time";
            this.dgv_start_time.Width = 140;
            // 
            // dgv_end_time
            // 
            this.dgv_end_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_end_time.HeaderText = "End Time";
            this.dgv_end_time.Name = "dgv_end_time";
            this.dgv_end_time.Width = 129;
            // 
            // dgv_doc
            // 
            this.dgv_doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_doc.HeaderText = "Doctor Name";
            this.dgv_doc.Name = "dgv_doc";
            this.dgv_doc.Width = 166;
            // 
            // dgv_max_number
            // 
            this.dgv_max_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_max_number.HeaderText = "Max Number";
            this.dgv_max_number.Name = "dgv_max_number";
            this.dgv_max_number.Width = 163;
            // 
            // dgv_current_number
            // 
            this.dgv_current_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_current_number.HeaderText = "Current Number";
            this.dgv_current_number.Name = "dgv_current_number";
            this.dgv_current_number.Width = 194;
            // 
            // dgv_spec
            // 
            this.dgv_spec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_spec.HeaderText = "Specialty";
            this.dgv_spec.Name = "dgv_spec";
            this.dgv_spec.Width = 135;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.dgv_books);
            this.tabPage4.Controls.Add(this.cmb_books_appointment);
            this.tabPage4.Controls.Add(this.dt_books);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1479, 668);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Books";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 63);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_books
            // 
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_patient_name,
            this.dgv_doctor,
            this.dgv_start,
            this.dgv_end,
            this.dgv_book_state,
            this.dgv_book_type,
            this.dgv_can_book});
            this.dgv_books.Location = new System.Drawing.Point(23, 217);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.RowTemplate.Height = 26;
            this.dgv_books.Size = new System.Drawing.Size(1404, 399);
            this.dgv_books.TabIndex = 3;
            this.dgv_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentClick);
            // 
            // dgv_patient_name
            // 
            this.dgv_patient_name.HeaderText = "Patient Name";
            this.dgv_patient_name.Name = "dgv_patient_name";
            // 
            // dgv_doctor
            // 
            this.dgv_doctor.HeaderText = "Doctor";
            this.dgv_doctor.Name = "dgv_doctor";
            // 
            // dgv_start
            // 
            this.dgv_start.HeaderText = "Start";
            this.dgv_start.Name = "dgv_start";
            // 
            // dgv_end
            // 
            this.dgv_end.HeaderText = "End";
            this.dgv_end.Name = "dgv_end";
            // 
            // dgv_book_state
            // 
            this.dgv_book_state.HeaderText = "State";
            this.dgv_book_state.Name = "dgv_book_state";
            // 
            // dgv_book_type
            // 
            this.dgv_book_type.HeaderText = "Book Type";
            this.dgv_book_type.Name = "dgv_book_type";
            // 
            // dgv_can_book
            // 
            this.dgv_can_book.HeaderText = "Mark As Done";
            this.dgv_can_book.Name = "dgv_can_book";
            this.dgv_can_book.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_can_book.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmb_books_appointment
            // 
            this.cmb_books_appointment.FormattingEnabled = true;
            this.cmb_books_appointment.Location = new System.Drawing.Point(804, 120);
            this.cmb_books_appointment.Name = "cmb_books_appointment";
            this.cmb_books_appointment.Size = new System.Drawing.Size(279, 36);
            this.cmb_books_appointment.TabIndex = 2;
            this.cmb_books_appointment.SelectedIndexChanged += new System.EventHandler(this.cmb_books_appointment_SelectedIndexChanged);
            // 
            // dt_books
            // 
            this.dt_books.Location = new System.Drawing.Point(129, 35);
            this.dt_books.Name = "dt_books";
            this.dt_books.Size = new System.Drawing.Size(468, 35);
            this.dt_books.TabIndex = 1;
            this.dt_books.ValueChanged += new System.EventHandler(this.dt_books_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(617, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = "Appointment";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Date";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dt_report_day);
            this.tabPage2.Controls.Add(this.crystalReportViewer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1409, 672);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1403, 666);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dt_report_day
            // 
            this.dt_report_day.Location = new System.Drawing.Point(6, 6);
            this.dt_report_day.Name = "dt_report_day";
            this.dt_report_day.Size = new System.Drawing.Size(394, 35);
            this.dt_report_day.TabIndex = 1;
            this.dt_report_day.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 726);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appoint)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dt_appoint;
        private System.Windows.Forms.DataGridView dgv_appoint;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.ComboBox cmb_books_appointment;
        private System.Windows.Forms.DateTimePicker dt_books;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_admin_name;
        private System.Windows.Forms.TextBox txt_admin_email;
        private System.Windows.Forms.TextBox txt_admin_password;
        private System.Windows.Forms.TextBox txt_clinic_address;
        private System.Windows.Forms.TextBox txt_clinic_email;
        private System.Windows.Forms.TextBox txt_clinic_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_patient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_book_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_book_type;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_can_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_max_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_current_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_spec;
        private System.Windows.Forms.TabPage tabPage2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker dt_report_day;
    }
}