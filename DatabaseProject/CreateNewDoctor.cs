using System;
using System.Collections.   Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace DatabaseProject
{
    public partial class CreateNewDoctor : Form
    {
        List<SPECIALTY> specialties = new List<SPECIALTY>();
        public CreateNewDoctor()
        {          
            InitializeComponent();
            // ta1
            string qu = "select * from specialty";
            PerformQuery.OpenConnection();
            List<OracleParameter> tt = new List<OracleParameter>();
            OracleDataReader dr= PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                SPECIALTY sp = new SPECIALTY();
                sp.SPEC_ID=int.Parse(dr[1].ToString());
                sp.SPEC_NAME = dr[0].ToString();
                specialties.Add(sp);
                cmd_specialty.Items.Add(dr[0].ToString());

            }
            dr.Close();
            PerformQuery.CloseConnection();
            //con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Helper.validit_email(txt_doctor_email.Text) == 0)
            {
                string qu = "insert into doctor (doc_gender, doc_email, doc_address, doc_name, spec_id,doc_id, password) values(:a, :a, :a, :a, :a, doctor_seq.nextval, ':a); ";
            //string con_string = "data source=orcl; user id=scott; password=tiger;";
           // PerformQuery.OpenConnection();
            DOCTOR new_doc = new DOCTOR();
            new_doc.DOC_NAME = txt_doctor_name.Text;
            new_doc.DOC_EMAIL = txt_doctor_email.Text;
            new_doc.PASSWORD = txt_doctor_pawwrod.Text;
            new_doc.DOC_ADDRESS = txt_doctor_address.Text;
            if (rad_male.Checked)
                new_doc.DOC_GENDER = "M";
            else
            {
                new_doc.DOC_GENDER = "F";
            }
            new_doc.SPEC_ID = specialties.Where(A => A.SPEC_NAME == cmd_specialty.SelectedItem.ToString()).FirstOrDefault().SPEC_ID;
            Helper.add_doc(new_doc);
            MessageBox.Show("Done");
            PerformQuery.CloseConnection();

        }
            else
            {
                MessageBox.Show("Not Valid Email");
            }

}

        private void CreateNewDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
