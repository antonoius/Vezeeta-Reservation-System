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
    public partial class ReviewDoctor : Form
    {
        decimal patient;
        decimal doctor;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds = new DataSet();
        public ReviewDoctor(decimal doc , decimal pat)
        {
            doctor = doc;
            patient = pat;
            InitializeComponent();
            string con_string = "data source=orcl; user id=project_v2; password=0129272801;";
            string query = "select * from DOCTORREVIEW";
             adapter = new OracleDataAdapter(query, con_string);
            
            adapter.Fill(ds);
           // dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
            



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReviewDoctor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Helper.review_doctor(doctor, patient, txt_rev.Text);
            MessageBox.Show("Your Review Recorded");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
