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
    public partial class CreateNewClinic : Form
    {
        List<AREA> areas = new List<AREA>();
        public CreateNewClinic()
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
            //PerformQuery.CloseConnection();
            dr.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateNewClinic_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( Helper.validit_email(txt_admin_email.Text)==0)
            {
                CLINIC cln = new CLINIC();
                cln.CLNC_NAME = txt_clinic_name.Text;
                cln.CLNC_EMAIL = txt_clinic_email.Text;
                cln.CLNC_ADDRESS = txt_clinic_address.Text;
                cln.AREA_ID = areas.Where(A => A.AREA_NAME == cmb_area.SelectedItem.ToString()).FirstOrDefault().AREA_ID;
                int clinc_id = Helper.add_clinic(cln);
                ADMIN admin = new ADMIN();
                admin.ADMIN_EMAIL = txt_admin_email.Text;
                admin.ADMIN_NAME = txt_admin_name.Text;
                admin.ADMIN_PASSWORD = txt_admin_password.Text;
                admin.CLNC_ID = clinc_id;
                Helper.add_admin(admin, clinc_id);
                MessageBox.Show("Clinc Added ");
                PerformQuery.CloseConnection();
            }
            else
            {
                MessageBox.Show("Not Valid Email");
            }

           

        }
    }
}
