namespace DatabaseProject
{
    partial class PatientPage
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
            this.cmb_area = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_patient_tel = new System.Windows.Forms.TextBox();
            this.txt_Patient_pawwrod = new System.Windows.Forms.TextBox();
            this.txt_Patient_address = new System.Windows.Forms.TextBox();
            this.txt_Patient_email = new System.Windows.Forms.TextBox();
            this.txt_Patient_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dt_appoint = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_appoint = new System.Windows.Forms.DataGridView();
            this.dgv_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_spec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clinic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_max_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_current_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmb_doc = new System.Windows.Forms.ComboBox();
            this.cmb_clinic = new System.Windows.Forms.ComboBox();
            this.cmb_area_2 = new System.Windows.Forms.ComboBox();
            this.cmb_specialty = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.dt_books = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_patient_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_book_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_book_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_can_book = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_doc_rev = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appoint)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1474, 696);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmb_area);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_patient_tel);
            this.tabPage1.Controls.Add(this.txt_Patient_pawwrod);
            this.tabPage1.Controls.Add(this.txt_Patient_address);
            this.tabPage1.Controls.Add(this.txt_Patient_email);
            this.tabPage1.Controls.Add(this.txt_Patient_name);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1466, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmb_area
            // 
            this.cmb_area.FormattingEnabled = true;
            this.cmb_area.Location = new System.Drawing.Point(243, 266);
            this.cmb_area.Name = "cmb_area";
            this.cmb_area.Size = new System.Drawing.Size(155, 29);
            this.cmb_area.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Area";
            // 
            // txt_patient_tel
            // 
            this.txt_patient_tel.Location = new System.Drawing.Point(241, 171);
            this.txt_patient_tel.Name = "txt_patient_tel";
            this.txt_patient_tel.Size = new System.Drawing.Size(155, 28);
            this.txt_patient_tel.TabIndex = 33;
            // 
            // txt_Patient_pawwrod
            // 
            this.txt_Patient_pawwrod.Location = new System.Drawing.Point(241, 211);
            this.txt_Patient_pawwrod.Name = "txt_Patient_pawwrod";
            this.txt_Patient_pawwrod.Size = new System.Drawing.Size(155, 28);
            this.txt_Patient_pawwrod.TabIndex = 34;
            // 
            // txt_Patient_address
            // 
            this.txt_Patient_address.Location = new System.Drawing.Point(241, 338);
            this.txt_Patient_address.Name = "txt_Patient_address";
            this.txt_Patient_address.Size = new System.Drawing.Size(155, 28);
            this.txt_Patient_address.TabIndex = 37;
            // 
            // txt_Patient_email
            // 
            this.txt_Patient_email.Location = new System.Drawing.Point(241, 117);
            this.txt_Patient_email.Name = "txt_Patient_email";
            this.txt_Patient_email.ReadOnly = true;
            this.txt_Patient_email.Size = new System.Drawing.Size(155, 28);
            this.txt_Patient_email.TabIndex = 32;
            // 
            // txt_Patient_name
            // 
            this.txt_Patient_name.Location = new System.Drawing.Point(241, 62);
            this.txt_Patient_name.Name = "txt_Patient_name";
            this.txt_Patient_name.Size = new System.Drawing.Size(155, 28);
            this.txt_Patient_name.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Patient Tel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Patient Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Patient Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Patient Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Patient Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dt_appoint);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dgv_appoint);
            this.tabPage2.Controls.Add(this.cmb_doc);
            this.tabPage2.Controls.Add(this.cmb_clinic);
            this.tabPage2.Controls.Add(this.cmb_area_2);
            this.tabPage2.Controls.Add(this.cmb_specialty);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1466, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Book Apointment";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dt_appoint
            // 
            this.dt_appoint.Location = new System.Drawing.Point(1013, 144);
            this.dt_appoint.Name = "dt_appoint";
            this.dt_appoint.Size = new System.Drawing.Size(394, 32);
            this.dt_appoint.TabIndex = 4;
            this.dt_appoint.ValueChanged += new System.EventHandler(this.dt_appoint_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dgv_doctor,
            this.dgv_spec,
            this.dgv_clinic,
            this.dgv_area,
            this.dgv_max_number,
            this.dgv_current_number,
            this.dgv_state,
            this.dgv_edit,
            this.dgv_delete});
            this.dgv_appoint.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_appoint.Location = new System.Drawing.Point(6, 256);
            this.dgv_appoint.Name = "dgv_appoint";
            this.dgv_appoint.RowTemplate.Height = 26;
            this.dgv_appoint.Size = new System.Drawing.Size(1441, 397);
            this.dgv_appoint.TabIndex = 2;
            this.dgv_appoint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_appoint_CellContentClick);
            // 
            // dgv_day
            // 
            this.dgv_day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_day.HeaderText = "Day";
            this.dgv_day.Name = "dgv_day";
            this.dgv_day.Width = 74;
            // 
            // dgv_start_time
            // 
            this.dgv_start_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_start_time.HeaderText = "Start Time";
            this.dgv_start_time.Name = "dgv_start_time";
            this.dgv_start_time.Width = 122;
            // 
            // dgv_end_time
            // 
            this.dgv_end_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_end_time.HeaderText = "End Time";
            this.dgv_end_time.Name = "dgv_end_time";
            this.dgv_end_time.Width = 113;
            // 
            // dgv_doctor
            // 
            this.dgv_doctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_doctor.HeaderText = "Doctor";
            this.dgv_doctor.Name = "dgv_doctor";
            this.dgv_doctor.Width = 98;
            // 
            // dgv_spec
            // 
            this.dgv_spec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_spec.HeaderText = "Specialty";
            this.dgv_spec.Name = "dgv_spec";
            this.dgv_spec.Width = 119;
            // 
            // dgv_clinic
            // 
            this.dgv_clinic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_clinic.HeaderText = "Clinic Name";
            this.dgv_clinic.Name = "dgv_clinic";
            this.dgv_clinic.Width = 132;
            // 
            // dgv_area
            // 
            this.dgv_area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_area.HeaderText = "Area";
            this.dgv_area.Name = "dgv_area";
            this.dgv_area.Width = 80;
            // 
            // dgv_max_number
            // 
            this.dgv_max_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_max_number.HeaderText = "Max Number";
            this.dgv_max_number.Name = "dgv_max_number";
            this.dgv_max_number.Width = 138;
            // 
            // dgv_current_number
            // 
            this.dgv_current_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_current_number.HeaderText = "Current Number";
            this.dgv_current_number.Name = "dgv_current_number";
            this.dgv_current_number.Width = 165;
            // 
            // dgv_state
            // 
            this.dgv_state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_state.HeaderText = "State";
            this.dgv_state.Name = "dgv_state";
            this.dgv_state.Width = 86;
            // 
            // dgv_edit
            // 
            this.dgv_edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_edit.HeaderText = "Edit";
            this.dgv_edit.Name = "dgv_edit";
            this.dgv_edit.Width = 50;
            // 
            // dgv_delete
            // 
            this.dgv_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_delete.HeaderText = "Delete";
            this.dgv_delete.Name = "dgv_delete";
            this.dgv_delete.Width = 75;
            // 
            // cmb_doc
            // 
            this.cmb_doc.FormattingEnabled = true;
            this.cmb_doc.Location = new System.Drawing.Point(726, 144);
            this.cmb_doc.Name = "cmb_doc";
            this.cmb_doc.Size = new System.Drawing.Size(255, 32);
            this.cmb_doc.TabIndex = 1;
            this.cmb_doc.Leave += new System.EventHandler(this.set_doc_cmb);
            // 
            // cmb_clinic
            // 
            this.cmb_clinic.FormattingEnabled = true;
            this.cmb_clinic.Location = new System.Drawing.Point(461, 144);
            this.cmb_clinic.Name = "cmb_clinic";
            this.cmb_clinic.Size = new System.Drawing.Size(251, 32);
            this.cmb_clinic.TabIndex = 1;
            this.cmb_clinic.Leave += new System.EventHandler(this.set_clinic_cmb);
            // 
            // cmb_area_2
            // 
            this.cmb_area_2.FormattingEnabled = true;
            this.cmb_area_2.Location = new System.Drawing.Point(242, 144);
            this.cmb_area_2.Name = "cmb_area_2";
            this.cmb_area_2.Size = new System.Drawing.Size(185, 32);
            this.cmb_area_2.TabIndex = 1;
            this.cmb_area_2.Leave += new System.EventHandler(this.set_area_cmb);
            // 
            // cmb_specialty
            // 
            this.cmb_specialty.FormattingEnabled = true;
            this.cmb_specialty.Location = new System.Drawing.Point(10, 144);
            this.cmb_specialty.Name = "cmb_specialty";
            this.cmb_specialty.Size = new System.Drawing.Size(206, 32);
            this.cmb_specialty.TabIndex = 1;
            this.cmb_specialty.SelectedIndexChanged += new System.EventHandler(this.cmd_specialty_SelectedIndexChanged);
            this.cmb_specialty.Leave += new System.EventHandler(this.set_spec_cmb);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1013, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(722, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Doctor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Clinic";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Area";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Specialty";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_books);
            this.tabPage3.Controls.Add(this.dt_books);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1466, 659);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "My Books";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dgv_books
            // 
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_patient_name,
            this.dgv_clnc,
            this.dgv_start,
            this.dgv_end,
            this.dgv_book_state,
            this.dgv_book_type,
            this.dgv_can_book,
            this.dgv_doc_rev});
            this.dgv_books.Location = new System.Drawing.Point(31, 106);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.RowTemplate.Height = 26;
            this.dgv_books.Size = new System.Drawing.Size(1404, 509);
            this.dgv_books.TabIndex = 7;
            this.dgv_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentClick);
            // 
            // dt_books
            // 
            this.dt_books.Location = new System.Drawing.Point(192, 47);
            this.dt_books.Name = "dt_books";
            this.dt_books.Size = new System.Drawing.Size(468, 32);
            this.dt_books.TabIndex = 6;
            this.dt_books.ValueChanged += new System.EventHandler(this.dt_books_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // dgv_patient_name
            // 
            this.dgv_patient_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_patient_name.HeaderText = "Doctor Name";
            this.dgv_patient_name.Name = "dgv_patient_name";
            this.dgv_patient_name.Width = 156;
            // 
            // dgv_clnc
            // 
            this.dgv_clnc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_clnc.HeaderText = "Clinic";
            this.dgv_clnc.Name = "dgv_clnc";
            this.dgv_clnc.Width = 86;
            // 
            // dgv_start
            // 
            this.dgv_start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_start.HeaderText = "Start";
            this.dgv_start.Name = "dgv_start";
            this.dgv_start.Width = 82;
            // 
            // dgv_end
            // 
            this.dgv_end.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_end.HeaderText = "End";
            this.dgv_end.Name = "dgv_end";
            this.dgv_end.Width = 72;
            // 
            // dgv_book_state
            // 
            this.dgv_book_state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_book_state.HeaderText = "State";
            this.dgv_book_state.Name = "dgv_book_state";
            this.dgv_book_state.Width = 86;
            // 
            // dgv_book_type
            // 
            this.dgv_book_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_book_type.HeaderText = "Book Type";
            this.dgv_book_type.Name = "dgv_book_type";
            this.dgv_book_type.Width = 133;
            // 
            // dgv_can_book
            // 
            this.dgv_can_book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_can_book.HeaderText = "Cancel";
            this.dgv_can_book.Name = "dgv_can_book";
            this.dgv_can_book.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_can_book.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgv_can_book.Width = 98;
            // 
            // dgv_doc_rev
            // 
            this.dgv_doc_rev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_doc_rev.HeaderText = "Review Doctor";
            this.dgv_doc_rev.Name = "dgv_doc_rev";
            this.dgv_doc_rev.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_doc_rev.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgv_doc_rev.Width = 168;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.crystalReportViewer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1466, 659);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Books Report";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1460, 653);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // PatientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 720);
            this.Controls.Add(this.tabControl1);
            this.Name = "PatientPage";
            this.Text = "PatientPage";
            this.Load += new System.EventHandler(this.PatientPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appoint)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmb_area;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_patient_tel;
        private System.Windows.Forms.TextBox txt_Patient_pawwrod;
        private System.Windows.Forms.TextBox txt_Patient_address;
        private System.Windows.Forms.TextBox txt_Patient_email;
        private System.Windows.Forms.TextBox txt_Patient_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_doc;
        private System.Windows.Forms.ComboBox cmb_clinic;
        private System.Windows.Forms.ComboBox cmb_area_2;
        private System.Windows.Forms.ComboBox cmb_specialty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_appoint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_spec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clinic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_max_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_current_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_state;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_edit;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_delete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dt_appoint;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.DateTimePicker dt_books;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_patient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_book_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_book_type;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_can_book;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_doc_rev;
        private System.Windows.Forms.TabPage tabPage4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}