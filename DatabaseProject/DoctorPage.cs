using DatabaseProject;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class DoctorPage : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        List<BOOK> books = new List<BOOK>();
        List<CLINIC> clinics = new List<CLINIC>();
        List<SPECIALTY> specialties = new List<SPECIALTY>();
        List<APPOINTMENT> appoints = new List<APPOINTMENT>();
        List<PATIENT> patients = new List<PATIENT>();
        List<BOOK_TYPE> book_types = new List<BOOK_TYPE>();
        DOCTOR main_doctor = new DOCTOR();
        int doctor_id;
        public DoctorPage(int doc_id)
        {
            InitializeComponent();
            
            doctor_id = doc_id;

            
            //tc3
            DcotorReport drr = new DcotorReport();
            crystalReportViewer1.ReportSource = drr;


            // ta1
            string qu = "select clnc_id , clnc_name  from clinic";
            PerformQuery.OpenConnection();
            List<OracleParameter> tt = new List<OracleParameter>();
            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                CLINIC clnc = new CLINIC();
                clnc.CLNC_ID = int.Parse(dr[0].ToString());
                clnc.CLNC_NAME = dr[1].ToString();
                clinics.Add(clnc);
                cmb_clinic.Items.Add(dr[1].ToString());

            }
           // dr.Close();
            PerformQuery.CloseConnection();
            //load doctor data
            
            main_doctor= Helper.Get_doctor_data(doctor_id);
            txt_doctor_address.Text = main_doctor.DOC_ADDRESS;
            txt_doctor_email.Text = main_doctor.DOC_EMAIL;
            txt_doctor_name.Text = main_doctor.DOC_NAME;
            txt_doctor_pawwrod.Text = main_doctor.PASSWORD;


            // fill specialty cobobox
             qu = "select * from specialty";
            PerformQuery.OpenConnection();
           tt = new List<OracleParameter>();
            OracleDataReader dr2 = PerformQuery.MultiRowsSelectionQuery(tt, qu);
           
            while (dr2.Read())
            {
                SPECIALTY sp = new SPECIALTY();
                sp.SPEC_ID = int.Parse(dr2[1].ToString());
                sp.SPEC_NAME = dr2[0].ToString();
                specialties.Add(sp);
                cmd_specialty.Items.Add(dr2[0].ToString());

            }
            cmd_specialty.Text = specialties.Where(A => A.SPEC_ID == main_doctor.SPEC_ID).FirstOrDefault().SPEC_NAME;
            dr2.Close();

            dt_end.Format = DateTimePickerFormat.Custom;
            dt_end.CustomFormat = "dddd, dd MMMM yyyy HH:mm:ss";
            dt_end.Value = DateTime.Now;
            dt_start.Value = DateTime.Now;
            dt_start.Format = DateTimePickerFormat.Custom;
            dt_start.CustomFormat = "dddd, dd MMMM yyyy HH:mm:ss";

            dt_appoint.Format = DateTimePickerFormat.Custom;
            dt_appoint.CustomFormat = "dddd, dd MMMM yyyy";
            // dt_appoint.CustomFormat = " WW MMMM yyyy";

            //load datagridview
            PerformQuery.CloseConnection();

            //load types data
            qu = "select TYPE_ID,TYPE_NAME from book_type";
            PerformQuery.OpenConnection();
            tt = new List<OracleParameter>();
            dr = PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                BOOK_TYPE type = new BOOK_TYPE();
                type.TYPE_ID = int.Parse(dr[0].ToString());
                type.TYPE_NAME = dr[1].ToString();

                book_types.Add(type);
            }
            //PerformQuery.CloseConnection();
            dr.Close();
            PerformQuery.CloseConnection();

        }
        public DoctorPage()
        {
            InitializeComponent();
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            APPOINTMENT apoin = new APPOINTMENT();
            apoin.CLNC_ID= clinics.Where(A => A.CLNC_NAME == cmb_clinic.SelectedItem.ToString()).FirstOrDefault().CLNC_ID;

            apoin.APPOIN_STATE = "O";
            apoin.APPOIN_MAX_PATIENTS = int.Parse(txt_max_number.Text);
            apoin.APPOIN_START_DATE = dt_start.Value.ToString();
            apoin.APPOIN_END_DATE = dt_end.Value.ToString();
            apoin.DOC_ID = doctor_id;
            Helper.add_appointment(apoin);
            MessageBox.Show("added");


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void dgv_appoint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                appoints = Helper.get_appoints(doctor_id);
                // MessageBox.Show(dgv_appoint.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString());
                int ap_id = int.Parse(dgv_appoint.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString());
                APPOINTMENT ap = new APPOINTMENT();
                ap = appoints.Single(a => a.APPOIN_ID == ap_id);
                ap.APPOIN_ID = ap_id;
                //TODO - Button Clicked - Execute Code Here
                if (e.ColumnIndex==6)
                {
                    if (Helper.get_books_by_doctor(int.Parse(ap.DOC_ID.ToString()), int.Parse(ap.CLNC_ID.ToString()), ap.APPOIN_START_DATE).Count != 0)
                    {
                        MessageBox.Show("You Can't Update Appointment Once Any Patient Book It");
                    }
                    else
                    {
                        EditAppointment ep = new EditAppointment(ap);
                        ep.Show();
                    }

                }
                else if(e.ColumnIndex == 7)
                {
                    if (Helper.get_books_by_doctor(int.Parse(ap.DOC_ID.ToString()), int.Parse(ap.CLNC_ID.ToString()), ap.APPOIN_START_DATE).Count != 0)
                    {
                        MessageBox.Show("You Can't Delete Appointment Once Any Patient Book It");
                    }
                    else
                    {
                        Helper.delete_appointment(ap);
                    }
                }


            }
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dt_appoint_ValueChanged(object sender, EventArgs e)
        {
            dgv_appoint.Rows.Clear();
            List<APPOINTMENT> appointments = new List<APPOINTMENT>();

            appointments= Helper.get_appoints(doctor_id);
            appointments = appointments.Where(a => Convert.ToDateTime(a.APPOIN_START_DATE).Date == dt_appoint.Value.Date).ToList();
          //  MessageBox.Show(appointments.Count.ToString());
            for (int row = 0; row < appointments.Count; row++)
            {
                DataGridViewRow r = new DataGridViewRow();
                dgv_appoint.Rows.Add(r);
                dgv_appoint.Rows[row].Height = 50;
              //  dgv_appoint.Rows[row]. = 60;
                dgv_appoint.Rows[row].Cells[0].Value = Convert.ToDateTime(appointments[row].APPOIN_START_DATE).Date.ToString();
                dgv_appoint.Rows[row].Cells[1].Value = Convert.ToDateTime(appointments[row].APPOIN_START_DATE).TimeOfDay.ToString();
                dgv_appoint.Rows[row].Cells[2].Value = Convert.ToDateTime(appointments[row].APPOIN_END_DATE).TimeOfDay.ToString();
                dgv_appoint.Rows[row].Cells[3].Value = clinics.Single(a => a.CLNC_ID == appointments[row].CLNC_ID).CLNC_NAME;
                dgv_appoint.Rows[row].Cells[4].Value = appointments[row].APPOIN_MAX_PATIENTS;            
                dgv_appoint.Rows[row].Cells[5].Value = Helper.get_books_by_doctor(int.Parse(appointments[row].DOC_ID.ToString()), int.Parse(appointments[row].CLNC_ID.ToString()), appointments[row].APPOIN_START_DATE).Count;
                dgv_appoint.Rows[row].Cells[6].Tag = appointments[row].APPOIN_ID;
                dgv_appoint.Rows[row].Cells[6].Value = "Update";
                dgv_appoint.Rows[row].Cells[7].Tag = appointments[row].APPOIN_ID;
                dgv_appoint.Rows[row].Cells[7].Value = "Delete";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dt_books_ValueChanged(object sender, EventArgs e)
        {
            List<APPOINTMENT> appoints_with_date = new List<APPOINTMENT>();
            cmb_books_appointment.Text = "";
            cmb_books_appointment.Items.Clear();
            appoints = Helper.get_appoints(doctor_id);
            appoints_with_date = appoints.Where(a => (Convert.ToDateTime(a.APPOIN_START_DATE).Date == Convert.ToDateTime(dt_books.Text).Date)).ToList();
            for (int i = 0; i < appoints_with_date.Count; i++)
            {
                cmb_books_appointment.Items.Add(appoints_with_date[i].APPOIN_ID);
            }
            dgv_books.Rows.Clear();
        }

        private void cmb_books_appointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            books = Helper.get_books_by_doctor(doctor_id);
            decimal clnc_id = appoints.Single(b => b.APPOIN_ID==(int.Parse(cmb_books_appointment.Text))).CLNC_ID;
            books = books.Where(a => a.CLNC_ID == clnc_id).Where(c => Convert.ToDateTime(c.APPOIN_START_DATE).Date == Convert.ToDateTime(dt_books.Text).Date).ToList();
         //   books=books.Where()
            //MessageBox.Show(books.Count.ToString());
            dgv_books.Rows.Clear();
            for (int row = 0; row < books.Count; row++)
            {
                DataGridViewRow r = new DataGridViewRow();
                dgv_books.Rows.Add(r);
                dgv_books.Rows[row].Height = 50;
                dgv_books.Rows[row].Cells[0].Value = Helper.Get_patient_data(int.Parse(books[row].PATIENT_ID.ToString())).PATIENT_NAME;
                dgv_books.Rows[row].Cells[1].Value = clinics.Single(a => a.CLNC_ID == books[row].CLNC_ID).CLNC_NAME;
                dgv_books.Rows[row].Cells[2].Value = books[row].APPOIN_START_DATE;
                dgv_books.Rows[row].Cells[3].Value = books[row].APPOIN_END_DATE;
                dgv_books.Rows[row].Cells[4].Value = books[row].BOOK_STATE;
                dgv_books.Rows[row].Cells[5].Value = book_types.Single(a => a.TYPE_ID == books[row].TYPE_ID).TYPE_NAME;
                //dgv_appoint.Rows[row].Cells[6].Tag = books[row].;
                dgv_books.Rows[row].Cells[6].Value = "Cancel";
            }
        }

        private void dgv_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {


                //MessageBox.Show(dgv_appoint.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString());
                Helper.update_book_state("C", books[e.RowIndex]);
                MessageBox.Show("Book Has Been Canceled");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // tb1
            string con_string = "data source=orcl; user id=project_v2; password=0129272801;";
            string query = "select * from DOCTORREVIEW where doc_id=:a";
            adapter = new OracleDataAdapter(query, con_string);
            adapter.SelectCommand.Parameters.Add("a", doctor_id);
            ds = new DataSet();

            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
           // dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            // tb3
           // OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
           // adapter.Update(ds.Tables[0]);
            
        }

        private void DoctorPage_Load(object sender, EventArgs e)
        {

        }
    }
}
