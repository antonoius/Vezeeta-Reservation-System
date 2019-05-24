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
    public partial class EditAppointment : Form
    {
        List<CLINIC> clinics = new List<CLINIC>();
        List<APPOINTMENT> appoints = new List<APPOINTMENT>();
        APPOINTMENT main_ap = new APPOINTMENT();
        public EditAppointment( APPOINTMENT ap)
        {
            InitializeComponent();
            main_ap = ap;
            //load areas data
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

            dt_end.Format = DateTimePickerFormat.Custom;
            dt_end.CustomFormat = "dddd, dd MMMM yyyy HH:mm:ss";
            dt_end.Value = DateTime.Now;
            dt_start.Value = DateTime.Now;
            dt_start.Format = DateTimePickerFormat.Custom;
            dt_start.CustomFormat = "dddd, dd MMMM yyyy HH:mm:ss";
        }

        private void EditAppointment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_ap.APPOIN_START_DATE = dt_start.Value.ToString();
            main_ap.APPOIN_END_DATE = dt_end.Value.ToString();
            main_ap.CLNC_ID = clinics.Single(a => a.CLNC_NAME == cmb_clinic.Text).CLNC_ID;
            main_ap.APPOIN_STATE =  "O" ;
            main_ap.APPOIN_MAX_PATIENTS = int.Parse(txt_max_number.Text);
            Helper.update_appointment(main_ap);
            
        }

        private void dt_start_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
