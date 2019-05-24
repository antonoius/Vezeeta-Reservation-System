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
    public partial class CreateNewPatient : Form
    {
        List<AREA> areas = new List<AREA>();
        public CreateNewPatient()
        {
            InitializeComponent();
            string qu = "select * from area";
            PerformQuery.OpenConnection();
            List<OracleParameter> tt = new List<OracleParameter>();
            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                AREA ar = new AREA();
                ar.AREA_ID = int.Parse(dr[0].ToString());
                ar.AREA_NAME = dr[1].ToString();
                areas.Add(ar);
                cmb_area.Items.Add(dr[1].ToString());

            }
            dr.Close();
            PerformQuery.CloseConnection();
        }

        private void txt_doctor_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewPatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Helper.validit_email(txt_Patient_email.Text) == 0)
            {
                PATIENT patient = new PATIENT();
            patient.PATIENT_ADDRESS = txt_Patient_address.Text;
            patient.PATIENT_EMAIL = txt_Patient_email.Text;
            patient.PATIENT_PASSWORD = txt_Patient_pawwrod.Text;
            patient.PATIENT_NAME = txt_Patient_name.Text;
            patient.PATIENT_TEL = txt_patient_tel.Text;
            patient.AREA_ID = areas.Where(A => A.AREA_NAME == cmb_area.SelectedItem.ToString()).FirstOrDefault().AREA_ID;

            Helper.add_patient(patient);
            MessageBox.Show("Done My Patient ");
            }
            else
            {
                MessageBox.Show("Not Valid Email");
            }
            // PerformQuery.CloseConnection();
        }
    }
}
