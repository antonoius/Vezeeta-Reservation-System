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
    public partial class PatientPage : Form
    {
        List<BOOK_TYPE> book_types = new List<BOOK_TYPE>();
        List<SPECIALTY> specialties = new List<SPECIALTY>();
        List<AREA> areas = new List<AREA>();
        List<CLINIC> clinics = new List<CLINIC>();
        List<DOCTOR> doctors = new List<DOCTOR>();
        List<APPOINTMENT> appointments = new List<APPOINTMENT>();
        List<APPOINTMENT> appoin = new List<APPOINTMENT>();
        List<BOOK> books = new List<BOOK>();
        int patient_id;

        public PatientPage(int pat_id)
        {
            patient_id = pat_id;
            InitializeComponent();
            cmb_area_2.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_area_2.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_doc.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_doc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_clinic.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_clinic.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_specialty.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_specialty.AutoCompleteSource = AutoCompleteSource.ListItems;
            //load specialties
            string qu = "select * from specialty";
            PerformQuery.OpenConnection();
            List<OracleParameter> tt = new List<OracleParameter>();
            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                SPECIALTY sp = new SPECIALTY();
                sp.SPEC_ID = int.Parse(dr[1].ToString());
                sp.SPEC_NAME = dr[0].ToString();
                specialties.Add(sp);
                cmb_specialty.Items.Add(dr[0].ToString());

            }
            //PerformQuery.CloseConnection();
            dr.Close();
            PerformQuery.CloseConnection();

            //load clinices data
            qu = "select  clnc_id , clnc_name,area_id  from clinic";
            PerformQuery.OpenConnection();
             tt = new List<OracleParameter>();
             dr = PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                CLINIC clnc = new CLINIC();
                clnc.CLNC_ID = int.Parse(dr[0].ToString());
                clnc.CLNC_NAME = dr[1].ToString();
                clnc.AREA_ID = int.Parse(dr[2].ToString());
                clinics.Add(clnc);
               
                cmb_clinic.Items.Add(dr[1].ToString());

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
                cmb_area_2.Items.Add(dr[1].ToString());
            }
            //PerformQuery.CloseConnection();
            dr.Close();
            PerformQuery.CloseConnection();

            //load appointments data
            qu = "select * from appointment";
            PerformQuery.OpenConnection();
            tt = new List<OracleParameter>();
            dr = PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                APPOINTMENT appoin = new APPOINTMENT();
                appoin.APPOIN_STATE = dr[0].ToString();
                appoin.APPOIN_START_DATE = dr[1].ToString();
                appoin.APPOIN_MAX_PATIENTS =int.Parse( dr[2].ToString());
                appoin.APPOIN_END_DATE = dr[3].ToString();
                appoin.DOC_ID =int.Parse( dr[4].ToString());
                appoin.CLNC_ID = int.Parse(dr[5].ToString());
                appoin.APPOIN_ID = int.Parse(dr[6].ToString());
                appointments.Add(appoin);
            }
            //PerformQuery.CloseConnection();
            dr.Close();
            PerformQuery.CloseConnection();

            //load doctors data
            qu = "select doc_id ,doc_name,spec_id from doctor";
            PerformQuery.OpenConnection();
            tt = new List<OracleParameter>();
            dr = PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                DOCTOR doc = new DOCTOR();
                doc.DOC_ID =int.Parse( dr[0].ToString());
                doc.DOC_NAME = dr[1].ToString();
                doc.SPEC_ID = int.Parse(dr[2].ToString());
                cmb_doc.Items.Add(doc.DOC_NAME);
                doctors.Add(doc);
            }
            //PerformQuery.CloseConnection();
            dr.Close();
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


            //load books data
            qu = "select doc_id,clnc_id,patient_id,APPOIN_START_DATE from books";
            PerformQuery.OpenConnection();
            tt = new List<OracleParameter>();
            dr = PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                BOOK book = new BOOK();
                book.DOC_ID = int.Parse(dr[0].ToString());
                book.CLNC_ID = int.Parse(dr[1].ToString());
                book.PATIENT_ID = int.Parse(dr[2].ToString());
                book.APPOIN_START_DATE = dr[3].ToString();

                books.Add(book);
            }
            //PerformQuery.CloseConnection();
            dr.Close();
            PerformQuery.CloseConnection();


            dt_appoint.Format = DateTimePickerFormat.Custom;
            dt_appoint.CustomFormat = "dddd, dd MMMM yyyy";
            dt_appoint.Text = "";
            load_patient_data();

            // load crystak report parameters 
            //tc2
            PatientReport ad_report = new PatientReport();
            ad_report.SetParameterValue(0, patient_id);
            
            crystalReportViewer1.ReportSource = ad_report;
        }
        public void load_patient_data()
        {
            PATIENT pat = new PATIENT();
            pat= Helper.Get_patient_data(patient_id);
            txt_Patient_address.Text = pat.PATIENT_ADDRESS;
            txt_Patient_email.Text = pat.PATIENT_EMAIL;
            txt_Patient_name.Text = pat.PATIENT_NAME;
            txt_Patient_pawwrod.Text = pat.PATIENT_PASSWORD;
            txt_patient_tel.Text = pat.PATIENT_TEL;
            for (int i = 0; i < areas.Count; i++)
            {
                cmb_area.Items.Add(areas[i].AREA_NAME);

            }
            cmb_area.Text = areas.Single(a => a.AREA_ID == pat.AREA_ID).AREA_NAME;
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void cmd_specialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void set_cmbs(object sender, EventArgs e)
        {
            
        }
        public void search ()
        {

        }

        private void set_spec_cmb(object sender, EventArgs e)
        {
           if( specialties.Where(a=>a.SPEC_NAME== cmb_specialty.Text).FirstOrDefault()==null && cmb_specialty.Text != "")
            {
                MessageBox.Show("Choose A valid value");
                cmb_specialty.Text = null;
            }
           else if(cmb_specialty.Text != "")
            {
                List<DOCTOR> docs = new List<DOCTOR>();
                int spec_id = int.Parse(specialties.Where(b => b.SPEC_NAME == cmb_specialty.Text).FirstOrDefault().SPEC_ID.ToString());

                docs = doctors.Where(a => a.SPEC_ID == spec_id).ToList();
                cmb_doc.Items.Clear();
                for (int i = 0; i < docs.Count; i++)
                {
                    cmb_doc.Items.Add(docs[i].DOC_NAME);
                }
            }
            else
            {
                cmb_doc.Items.Clear();
                for (int i = 0; i < doctors.Count; i++)
                {
                    cmb_doc.Items.Add(doctors[i].DOC_NAME);
                }
            }
                
        }

        private void set_area_cmb(object sender, EventArgs e)
        {
            if (areas.Where(a => a.AREA_NAME == cmb_area_2.Text).FirstOrDefault() == null&& cmb_area_2.Text!="")
            {
                MessageBox.Show("Choose A valid value");
                cmb_area_2.Text = null;
            }
            else if(cmb_area_2.Text != "")
            {
                List<AREA> ares = new List<AREA>();
                ares = areas;
                int area_id =int.Parse( areas.Where(b => b.AREA_NAME == cmb_area_2.Text).FirstOrDefault().AREA_ID.ToString());
                List<CLINIC>clncs= clinics.Where(a => a.AREA_ID == area_id).ToList().ToList();
                cmb_clinic.Items.Clear();
                for (int i = 0; i < clncs.Count; i++)
                {
                    cmb_clinic.Items.Add(clncs[i].CLNC_NAME);
                }

                

            }
        }

        private void set_clinic_cmb(object sender, EventArgs e)
        {
            if (clinics.Where(a => a.CLNC_NAME == cmb_clinic.Text).FirstOrDefault() == null && cmb_clinic.Text != "")
            {
                MessageBox.Show("Choose A valid value");
                cmb_clinic.Text = null;
            }
            else if(cmb_clinic.Text != "")
            {
                List<DOCTOR> docs = new List<DOCTOR>();
                
            }
        }

        private void set_doc_cmb(object sender, EventArgs e)
        {
            if (doctors.Where(a => a.DOC_NAME == cmb_doc.Text).FirstOrDefault() == null && cmb_doc.Text != "")
            {
                MessageBox.Show("Choose A valid value");
                cmb_doc.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appoin = appointments;
            if(cmb_area_2.Text!="")
            {
                int area_id = int.Parse(areas.Where(b => b.AREA_NAME == cmb_area_2.Text).FirstOrDefault().AREA_ID.ToString());
                List<CLINIC> clncs = clinics.Where(a => a.AREA_ID == area_id).ToList().ToList();
                 
                List<APPOINTMENT> items=new List<APPOINTMENT>();
                List<CLINIC> categories = new List<CLINIC>();
                items = appoin;
                categories = clncs;
                IEnumerable<APPOINTMENT> result = items.Where(item =>
                categories.Any(category => category.CLNC_ID==(item.CLNC_ID)));
                appoin = result.ToList();
                //MessageBox.Show(categories.Count.ToString());
            }
            if(cmb_specialty.Text!="")
            {
                int spec_id = int.Parse(specialties.Where(b => b.SPEC_NAME == cmb_specialty.Text).FirstOrDefault().SPEC_ID.ToString());
                List<DOCTOR> docs = doctors.Where(a => a.SPEC_ID == spec_id).ToList();

                List<APPOINTMENT> items = new List<APPOINTMENT>();
                List<DOCTOR> categories = new List<DOCTOR>();
                items = appoin;
                categories = docs;
                IEnumerable<APPOINTMENT> result = items.Where(item =>
                categories.Any(category => category.DOC_ID == (item.DOC_ID)));
                appoin = result.ToList();
              //  MessageBox.Show(appoin.Count.ToString());

            }
            if (cmb_doc.Text != "")
            {
                int doc_id = int.Parse(doctors.Where(b => b.DOC_NAME == cmb_doc.Text).FirstOrDefault().DOC_ID.ToString());
                appoin = appoin.Where(a => a.DOC_ID == doc_id).ToList();

            }

            appoin = appoin.Where(a => a.APPOIN_STATE != "C").ToList();

            //fill appointments
            dgv_appoint.Rows.Clear();
            for (int row = 0; row < appoin.Count; row++)
            {
               // if (current_patient_number != appoin[row].APPOIN_MAX_PATIENTS)
              //  {
                DataGridViewRow r = new DataGridViewRow();
                dgv_appoint.Rows.Add(r);
                dgv_appoint.Rows[row].Height = 50;
                //  dgv_appoint.Rows[row]. = 60;
                dgv_appoint.Rows[row].Cells[0].Value = Convert.ToDateTime(appoin[row].APPOIN_START_DATE).Date.ToString();
                dgv_appoint.Rows[row].Cells[1].Value = Convert.ToDateTime(appoin[row].APPOIN_START_DATE).TimeOfDay.ToString();
                dgv_appoint.Rows[row].Cells[2].Value = Convert.ToDateTime(appoin[row].APPOIN_END_DATE).TimeOfDay.ToString();
                dgv_appoint.Rows[row].Cells[3].Value = doctors.Single(a => a.DOC_ID == appoin[row].DOC_ID).DOC_NAME;
                dgv_appoint.Rows[row].Cells[5].Value = specialties.Single(aa => aa.SPEC_ID == doctors.Single(a => a.DOC_ID == appoin[row].DOC_ID).SPEC_ID).SPEC_NAME;
                dgv_appoint.Rows[row].Cells[6].Value = clinics.Single(aa => aa.CLNC_ID == appoin[row].CLNC_ID).CLNC_NAME;
                dgv_appoint.Rows[row].Cells[7].Value = appoin[row].APPOIN_MAX_PATIENTS;
                dgv_appoint.Rows[row].Cells[8].Value = books.Where(a => a.CLNC_ID == appoin[row].CLNC_ID).Where(aa => aa.DOC_ID == appoin[row].DOC_ID).Where(a => a.APPOIN_START_DATE == appoin[row].APPOIN_START_DATE).Count().ToString();
                dgv_appoint.Rows[row].Cells[9].Value = appoin[row].APPOIN_STATE == "O" ? "Opened" : "Closed";
                dgv_appoint.Rows[row].Cells[10].Tag = appoin[row].APPOIN_ID;
                dgv_appoint.Rows[row].Cells[10].Value = "Book";
           // }
               

            }
        }

        private void dgv_appoint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int current_patient_number = books.Where(a => a.CLNC_ID == appoin[e.RowIndex].CLNC_ID).Where(aa => aa.DOC_ID == appoin[e.RowIndex].DOC_ID).Where(a => a.APPOIN_START_DATE == appoin[e.RowIndex].APPOIN_START_DATE).Count();
                //MessageBox.Show(dgv_appoint.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString()); 
                int appoint_id =int.Parse(dgv_appoint.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString());
                APPOINTMENT ap = new APPOINTMENT();
                ap = appointments.Single(a => a.APPOIN_ID == appoint_id);
                if(current_patient_number< ap.APPOIN_MAX_PATIENTS)
                {
                    ConfirmBook confirm_book = new ConfirmBook(ap, patient_id);
                    confirm_book.Show();
                }
                else
                {
                    MessageBox.Show("Appointment Is Full");
                }

            }
        }

        private void dt_appoint_ValueChanged(object sender, EventArgs e)
        {
            List<APPOINTMENT> dt_appoints = new List<APPOINTMENT>();
            dt_appoints = appoin.Where(a => Convert.ToDateTime(a.APPOIN_START_DATE).Date == Convert.ToDateTime(dt_appoint.Text).Date).ToList();
            dgv_appoint.Rows.Clear();
            for (int row = 0; row < dt_appoints.Count; row++)
            {
                DataGridViewRow r = new DataGridViewRow();
                dgv_appoint.Rows.Add(r);
                dgv_appoint.Rows[row].Height = 50;
                //  dgv_appoint.Rows[row]. = 60;
                dgv_appoint.Rows[row].Cells[0].Value = Convert.ToDateTime(dt_appoints[row].APPOIN_START_DATE).Date.ToString();
                dgv_appoint.Rows[row].Cells[1].Value = Convert.ToDateTime(dt_appoints[row].APPOIN_START_DATE).TimeOfDay.ToString();
                dgv_appoint.Rows[row].Cells[2].Value = Convert.ToDateTime(dt_appoints[row].APPOIN_END_DATE).TimeOfDay.ToString();
                dgv_appoint.Rows[row].Cells[3].Value = doctors.Single(a => a.DOC_ID == dt_appoints[row].DOC_ID).DOC_NAME;

                dgv_appoint.Rows[row].Cells[5].Value = specialties.Single(aa => aa.SPEC_ID == doctors.Single(a => a.DOC_ID == dt_appoints[row].DOC_ID).SPEC_ID).SPEC_NAME;
                dgv_appoint.Rows[row].Cells[6].Value = clinics.Single(aa => aa.CLNC_ID == dt_appoints[row].CLNC_ID).CLNC_NAME;
                dgv_appoint.Rows[row].Cells[7].Value = dt_appoints[row].APPOIN_MAX_PATIENTS;
                dgv_appoint.Rows[row].Cells[8].Value = dt_appoints[row].APPOIN_MAX_PATIENTS;
                dgv_appoint.Rows[row].Cells[9].Value = dt_appoints[row].APPOIN_STATE == "O" ? "Opened" : dt_appoints[row].APPOIN_STATE == "D" ? "Done":"Canceled";

                dgv_appoint.Rows[row].Cells[10].Tag = dt_appoints[row].APPOIN_ID;
                dgv_appoint.Rows[row].Cells[10].Value = "Book";

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dt_books_ValueChanged(object sender, EventArgs e)
        {
            books = Helper.get_books_by_patient(patient_id);
            books = books.Where(a => Convert.ToDateTime(a.APPOIN_START_DATE).Date == dt_books.Value.Date).ToList();

            //   books=books.Where()
            //MessageBox.Show(books.Count.ToString());
            dgv_books.Rows.Clear();
            for (int row = 0; row < books.Count; row++)
            {
                DataGridViewRow r = new DataGridViewRow();
                dgv_books.Rows.Add(r);
                dgv_books.Rows[row].Height = 50;
                dgv_books.Rows[row].Cells[0].Value = Helper.Get_doctor_data(int.Parse(books[row].DOC_ID.ToString())).DOC_NAME;
                dgv_books.Rows[row].Cells[1].Value = clinics.Single(a => a.CLNC_ID == books[row].CLNC_ID).CLNC_NAME;
                dgv_books.Rows[row].Cells[2].Value = books[row].APPOIN_START_DATE;
                dgv_books.Rows[row].Cells[3].Value = books[row].APPOIN_END_DATE;
                dgv_books.Rows[row].Cells[4].Value = books[row].BOOK_STATE == "D" ? "Done" : books[row].BOOK_STATE == "O" ? "Opened" : "Canceled";
                dgv_books.Rows[row].Cells[5].Value = book_types.Single(a => a.TYPE_ID == books[row].TYPE_ID).TYPE_NAME;
                //dgv_appoint.Rows[row].Cells[6].Tag = books[row].;
                dgv_books.Rows[row].Cells[6].Value = "Cancel";
                dgv_books.Rows[row].Cells[7].Value = "Review Doctor";

            }
        }

        private void dgv_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {


                //MessageBox.Show(dgv_appoint.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString());
                if(e.ColumnIndex==6)
                {
                    if (books[e.RowIndex].BOOK_STATE == "D")
                    {
                        MessageBox.Show("Book Is Already Done ");
                    }
                    else
                    {
                        Helper.update_book_state("C", books[e.RowIndex]);
                        MessageBox.Show("Book Has Been Canceled");
                    }
                }
                else if (e.ColumnIndex == 7)
                {
                    ReviewDoctor rd = new ReviewDoctor(books[e.RowIndex].DOC_ID, books[e.RowIndex].PATIENT_ID);
                    rd.Show();
                }


            }
        }

        private void PatientPage_Load(object sender, EventArgs e)
        {

        }
    }
}
