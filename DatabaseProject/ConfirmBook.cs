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
    public partial class ConfirmBook : Form
    {
        List<BOOK_TYPE> book_types = new List<BOOK_TYPE>();
        APPOINTMENT book_ap = new APPOINTMENT();
        int patient_id;
        public ConfirmBook(APPOINTMENT ap,int pat_id)
        {
            patient_id = pat_id;
            book_ap = ap;
            InitializeComponent();
            //load specialties
            string qu = "select * from book_type";
            PerformQuery.OpenConnection();
            List<OracleParameter> tt = new List<OracleParameter>();
            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(tt, qu);
            while (dr.Read())
            {
                BOOK_TYPE bt = new BOOK_TYPE();
                bt.TYPE_NAME = dr[0].ToString();
                bt.TYPE_ID =  int.Parse(dr[1].ToString());
                book_types.Add(bt);
                cmb_book_type.Items.Add(dr[0].ToString());

            }
            //PerformQuery.CloseConnection();
            dr.Close();
            PerformQuery.CloseConnection();

        }

        private void ConfirmBook_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BOOK book = new BOOK();
            book.TYPE_ID = book_types.Single(a => a.TYPE_NAME == cmb_book_type.Text).TYPE_ID;
            book.PATIENT_ID = patient_id;
            book.DOC_ID = book_ap.DOC_ID;
            book.CLNC_ID = book_ap.CLNC_ID;
            book.BOOK_STATE = "O";
            book.APPOIN_START_DATE = book_ap.APPOIN_START_DATE;
            book.APPOIN_END_DATE = book_ap.APPOIN_END_DATE;
            Helper.create_book(book);
            MessageBox.Show("Done");
        }
    }
}
