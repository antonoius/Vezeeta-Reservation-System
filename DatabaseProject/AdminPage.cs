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
    public partial class AdminPage : Form
    {
        List<AREA> areas = new List<AREA>();
        List<CLINIC> clinics = new List<CLINIC>();
        List<SPECIALTY> specialties = new List<SPECIALTY>();
        List<APPOINTMENT> appoints = new List<APPOINTMENT>();
        List<DOCTOR> doctors = new List<DOCTOR>();
        List<PATIENT> patients = new List<PATIENT>();
        List<BOOK_TYPE> book_types = new List<BOOK_TYPE>();
        List<BOOK> books = new List<BOOK>();
        ADMIN main_admin = new ADMIN();
        CLINIC main_clinic= new CLINIC();
        int clnc_id; 
        int admin_id;
        public AdminPage(int ad_id)
        {
            InitializeComponent();
            admin_id = ad_id;
            
            string qu = "select clnc_id , clnc_name ,CLNC_ADDRESS,CLNC_EMAIL,AREA_ID from clinic ";
            PerformQuery.OpenConnection();
            List<OracleParameter> tt = new List<OracleParameter>();
            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                CLINIC clnc = new CLINIC();
                clnc.CLNC_ID = int.Parse(dr[0].ToString());
                clnc.CLNC_NAME = dr[1].ToString();
                clnc.CLNC_ADDRESS= dr[2].ToString();
                clnc.CLNC_EMAIL = dr[3].ToString();
                clnc.AREA_ID =int.Parse( dr[4].ToString());
                clinics.Add(clnc);
                

            }
            // dr.Close();
            PerformQuery.CloseConnection();

            //load areas data
            qu = "select * from area";
            PerformQuery.OpenConnection();
            tt = new List<OracleParameter>();
            dr = PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                AREA ar = new AREA();
                ar.AREA_ID = int.Parse(dr[0].ToString());
                ar.AREA_NAME = dr[1].ToString();
                areas.Add(ar);
                
            }
            //PerformQuery.CloseConnection();
            dr.Close();
            PerformQuery.CloseConnection();

            PerformQuery.CloseConnection();

            //load doctors data
            qu = "select doc_name,doc_id ,spec_id from doctor";
            PerformQuery.OpenConnection();
            tt = new List<OracleParameter>();
            dr = PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                DOCTOR doc = new DOCTOR();
                doc.DOC_NAME = dr[0].ToString();
                doc.DOC_ID =  int.Parse(dr[1].ToString());
                doc.SPEC_ID = int.Parse(dr[2].ToString());
                doctors.Add(doc);

            }
            //PerformQuery.CloseConnection();
            dr.Close();
            PerformQuery.CloseConnection();

            //load admin data

            main_admin = Helper.get_admin_data(admin_id);
            txt_admin_email.Text = main_admin.ADMIN_EMAIL;
            txt_admin_name.Text = main_admin.ADMIN_NAME;
            txt_admin_password.Text = main_admin.ADMIN_PASSWORD;
            clnc_id =int.Parse( main_admin.CLNC_ID.ToString());




            //load clinc data
            main_clinic = clinics.Single(a => a.CLNC_ID == clnc_id);
            txt_clinic_name.Text = main_clinic.CLNC_NAME;
            txt_clinic_email.Text = main_clinic.CLNC_EMAIL;
            txt_clinic_address.Text = main_clinic.CLNC_ADDRESS;
            txt_area.Text = areas.Single(a => a.AREA_ID == main_clinic.AREA_ID).AREA_NAME;
            


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
               
            }
            dr2.Close();
            // load appoints
            appoints = Helper.get_appoints_by_clinic(clnc_id);

            dt_appoint.Format = DateTimePickerFormat.Custom;
            dt_appoint.CustomFormat = "dddd, dd MMMM yyyy";

            dt_report_day.Format = DateTimePickerFormat.Short;
            dt_report_day.CustomFormat = "dddd, dd MMMM yyyy";
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

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void txt_admin_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt_appoint_ValueChanged(object sender, EventArgs e)
        {
            List<APPOINTMENT> appoints_with_date = new List<APPOINTMENT>();            
            appoints_with_date = appoints.Where(a => (Convert.ToDateTime(a.APPOIN_START_DATE).Date == Convert.ToDateTime(dt_appoint.Text).Date)).ToList();
            for (int row = 0; row < appoints_with_date.Count; row++)
            {
                DataGridViewRow r = new DataGridViewRow();
                dgv_appoint.Rows.Add(r);
                dgv_appoint.Rows[row].Height = 50;
                //  dgv_appoint.Rows[row]. = 60;
                dgv_appoint.Rows[row].Cells[0].Value = Convert.ToDateTime(appoints_with_date[row].APPOIN_START_DATE).Day.ToString();
                dgv_appoint.Rows[row].Cells[1].Value = Convert.ToDateTime(appoints_with_date[row].APPOIN_START_DATE).TimeOfDay.ToString();
                dgv_appoint.Rows[row].Cells[2].Value = Convert.ToDateTime(appoints_with_date[row].APPOIN_END_DATE).TimeOfDay.ToString();
                dgv_appoint.Rows[row].Cells[3].Value = doctors.Single(a => a.DOC_ID == appoints_with_date[row].DOC_ID).DOC_NAME;
                dgv_appoint.Rows[row].Cells[4].Value = appoints_with_date[row].APPOIN_MAX_PATIENTS;
                dgv_appoint.Rows[row].Cells[5].Value= Helper.get_books_by_doctor(int.Parse(appoints_with_date[row].DOC_ID.ToString()), int.Parse(appoints_with_date[row].CLNC_ID.ToString()), appoints_with_date[row].APPOIN_START_DATE).Count;
                dgv_appoint.Rows[row].Cells[6].Value = specialties.Single(a => a.SPEC_ID == doctors.Single(aa => aa.DOC_ID == appoints_with_date[row].DOC_ID).SPEC_ID).SPEC_NAME;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            books = Helper.get_books_by_clinic(clnc_id);
            //decimal clnc_id = appoints.Single(b => b.APPOIN_ID == (int.Parse(cmb_books_appointment.Text))).CLNC_ID;
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
                dgv_books.Rows[row].Cells[1].Value = doctors.Single(a => a.DOC_ID == books[row].DOC_ID).DOC_NAME;
                dgv_books.Rows[row].Cells[2].Value = books[row].APPOIN_START_DATE;
                dgv_books.Rows[row].Cells[3].Value = books[row].APPOIN_END_DATE;
                dgv_books.Rows[row].Cells[4].Value =   books[row].BOOK_STATE=="D"?"Done" : books[row].BOOK_STATE == "O" ? "Opened" :  "Canceled";
                dgv_books.Rows[row].Cells[5].Value = book_types.Single(a => a.TYPE_ID == books[row].TYPE_ID).TYPE_NAME;
                //dgv_appoint.Rows[row].Cells[6].Tag = books[row].;
                dgv_books.Rows[row].Cells[6].Value = "Mark As Done";
            }
        }

        private void dt_books_ValueChanged(object sender, EventArgs e)
        {
            List<APPOINTMENT> appoints_with_date = new List<APPOINTMENT>();
            cmb_books_appointment.Text = "";
            cmb_books_appointment.Items.Clear();
            //appoints = Helper.get_appoints_by_clinic(clnc_id);
            appoints_with_date = appoints.Where(a => (Convert.ToDateTime(a.APPOIN_START_DATE).Date == Convert.ToDateTime(dt_books.Text).Date)).ToList();
            for (int i = 0; i < appoints_with_date.Count; i++)
            {
                cmb_books_appointment.Items.Add(appoints_with_date[i].APPOIN_ID);
            }
            dgv_books.Rows.Clear();
        }

        private void cmb_doc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_books_appointment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dgv_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (books[e.RowIndex].BOOK_STATE == "O")
                {
                    Helper.update_book_state("D", books[e.RowIndex]);
                    MessageBox.Show("Book Marked As Done");
                }
                else if (books[e.RowIndex].BOOK_STATE == "D")
                {
                    MessageBox.Show("Book Is Already Done");
                }
                else
                {
                    MessageBox.Show("You Can't Done Cenceld Book");
                }
                //MessageBox.Show(dgv_appoint.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CLINIC c = new CLINIC();
            c.CLNC_ID = clnc_id;
            c.CLNC_NAME = txt_clinic_name.Text;
            c.CLNC_ADDRESS = txt_clinic_address.Text;
            c.CLNC_EMAIL = txt_clinic_email.Text;

            ADMIN ad = new ADMIN();
            ad.ADMIN_ID = admin_id;
            ad.ADMIN_NAME = txt_admin_name.Text;
            ad.ADMIN_PASSWORD = txt_admin_password.Text;
            Helper.update_clinic(c, ad);
            MessageBox.Show("Edited");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_appoint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dt_report_day.Value.ToShortDateString());
            // load crystak report parameters 
            AdminReport ad_report = new AdminReport();
            ad_report.SetParameterValue(0, clnc_id);
            ad_report.SetParameterValue(1, dt_report_day.Value.ToShortDateString());
            crystalReportViewer1.ReportSource = ad_report;
        }
    }
}
