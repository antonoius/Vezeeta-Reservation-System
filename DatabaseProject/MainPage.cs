using System;
using System.Collections.Generic;
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
    public partial class MainPage : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewPatient p = new CreateNewPatient();
            p.Show();
        }
        private void LogIn_Click(object sender, EventArgs e)
        {
            

            int doc_id= Helper.find_doctor(txt_email.Text, txt_pass.Text);
            int patient_id = Helper.find_patient(txt_email.Text, txt_pass.Text);
            int admin_id = Helper.get_admin_data( txt_email.Text, txt_pass.Text);
            //int doc_id = Helper.find_doctor("tonysmart", "tony");
            if (doc_id!=-1)
            {
                DoctorPage dr = new DoctorPage(doc_id);
                    dr.Show();
            }
            else if(patient_id!=-1)
            {
                PatientPage pat = new PatientPage(patient_id);
                pat.Show();
            }
            else if (admin_id!=-1)
            {
                AdminPage pat = new AdminPage(admin_id);
                pat.Show();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateNewDoctor cnd = new CreateNewDoctor();
            cnd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateNewClinic clinc = new CreateNewClinic();
            clinc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // PatientPage pe = new PatientPage();
           // pe.Show();
        }
    }
}
