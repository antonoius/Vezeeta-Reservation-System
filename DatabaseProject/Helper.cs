using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public static class Helper
    {
        public static int add_clinic(CLINIC cln)
        {
            PerformQuery.OpenConnection();
            // task A3   insert
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p = new OracleParameter();
            p.ParameterName = "any";
            p.Value = cln.CLNC_NAME;
            parms.Add(p);
            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = "any";
            p2.Value = cln.CLNC_ADDRESS;
            parms.Add(p2);

            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = "any";
            p3.Value = cln.CLNC_EMAIL;
            parms.Add(p3);

            OracleParameter p4 = new OracleParameter();
            p4.ParameterName = "any";
            p4.Value = cln.AREA_ID;
            parms.Add(p4);


            string qu2 = "insert into clinic (CLNC_ID, CLNC_NAME, CLNC_ADDRESS, CLNC_EMAIL, AREA_ID) values( clinic_seq.nextval, :a, :a, :a,:a) ";
            PerformQuery.IUDQuery(parms, qu2);
            PerformQuery.CloseConnection();

            // task A2   select one row with parameters  
            PerformQuery.OpenConnection();
            string qu3 = "select clnc_id from clinic where clnc_name=:a";
            List<OracleParameter> parms2 = new List<OracleParameter>();
            OracleParameter p9 = new OracleParameter();
            p9.ParameterName = "any";
            p9.Value = cln.CLNC_NAME;
            parms2.Add(p9);
            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(parms2, qu3);
            int id = 0;
            while (dr.Read())
            {
                id = int.Parse(dr[0].ToString());
            }
            PerformQuery.CloseConnection();
            return id;
        }
        public static void add_doc(DOCTOR doc)
        {
            PerformQuery.OpenConnection();
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p = new OracleParameter();
            p.ParameterName = "any";
            p.Value = doc.DOC_GENDER;
            parms.Add(p);
            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = "any";
            p2.Value = doc.DOC_EMAIL;
            parms.Add(p2);

            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = "any";
            p3.Value = doc.DOC_ADDRESS;
            parms.Add(p3);

            OracleParameter p4 = new OracleParameter();
            p4.ParameterName = "any";
            p4.Value = doc.DOC_NAME;
            parms.Add(p4);

            OracleParameter p5 = new OracleParameter();
            p5.ParameterName = "gregegeg";
            p5.Value = doc.SPEC_ID;
            parms.Add(p5);

            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = doc.PASSWORD;
            parms.Add(p6);
            string qu2 = "insert into doctor (doc_gender, doc_email, doc_address, doc_name, spec_id,doc_id, password) values(:a, :a, :c, :7mada,:a, doctor_seq.nextval, :a) ";

            string qu = "insert into doctor (doc_gender, doc_email, doc_address, doc_name, spec_id,doc_id, password) values('q','dwdqdq','dwqdqd','dwqdqdq',4, doctor_seq.nextval, 'dqwdqdq'); ";

            PerformQuery.IUDQuery(parms, qu2);
            PerformQuery.CloseConnection();
        }
        public static void add_admin(ADMIN admin,int clinic_id)
        {
            PerformQuery.OpenConnection();
            // task A3
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = "any";
            p2.Value = admin.ADMIN_EMAIL;
            parms.Add(p2);

            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = "any";
            p3.Value = admin.ADMIN_NAME;
            parms.Add(p3);

            OracleParameter p4 = new OracleParameter();
            p4.ParameterName = "any";
            p4.Value = clinic_id;
            parms.Add(p4);

            OracleParameter p5 = new OracleParameter();
            p5.ParameterName = "any";
            p5.Value = admin.ADMIN_PASSWORD;
            parms.Add(p5);

            string qu2 = "insert into admin (ADMIN_ID, ADMIN_EMAIL, ADMIN_NAME, CLNC_ID,ADMIN_PASSWORD) values( admin_seq.nextval, :a, :a, :a,:a) ";


            PerformQuery.IUDQuery(parms, qu2);
            PerformQuery.CloseConnection();
        }
        public static void add_patient(PATIENT patient)
        {
            PerformQuery.OpenConnection();
            // task A3
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = "any";
            p2.Value = patient.PATIENT_EMAIL;
            parms.Add(p2);

            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = "any";
            p3.Value = patient.PATIENT_NAME;
            parms.Add(p3);

            OracleParameter p4 = new OracleParameter();
            p4.ParameterName = "any";
            p4.Value = patient.PATIENT_TEL;
            parms.Add(p4);

            OracleParameter p5 = new OracleParameter();
            p5.ParameterName = "any";
            p5.Value = patient.PATIENT_ADDRESS;
            parms.Add(p5);

            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = patient.AREA_ID;
            parms.Add(p6);

            OracleParameter p7 = new OracleParameter();
            p7.ParameterName = "any";
            p7.Value = patient.PATIENT_PASSWORD;
            parms.Add(p7);
            string qu2 = "insert into patient (PATIENT_ID, PATIENT_EMAIL,PATIENT_NAME, PATIENT_TEL, PATIENT_ADDRESS,AREA_ID,PATIENT_PASSWORD) values( patient_seq.nextval, :a, :a, :a,:a,:a,:a) ";

            PerformQuery.IUDQuery(parms, qu2);
            PerformQuery.CloseConnection();

        }
        public static void add_appointment(APPOINTMENT ap)
        {
            PerformQuery.OpenConnection();
            string qu2 = "insert into appointment (APPOIN_STATE,APPOIN_START_DATE, APPOIN_MAX_PATIENTS,APPOIN_END_DATE, DOC_ID, CLNC_ID,APPOIN_ID) values(:a, :a, :a,:a,:a,:a,appointment__seq.nextval) ";
            List<OracleParameter> parms = new List<OracleParameter>();

            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = ap.APPOIN_STATE;
            parms.Add(p6);

            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = "any";
            p2.Value = ap.APPOIN_START_DATE;
            parms.Add(p2);

            OracleParameter p7 = new OracleParameter();
            p7.ParameterName = "any";
            p7.Value = ap.APPOIN_MAX_PATIENTS;
            parms.Add(p7);

            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = "any";
            p3.Value = ap.APPOIN_END_DATE;
            parms.Add(p3);

            OracleParameter p4 = new OracleParameter();
            p4.ParameterName = "any";
            p4.Value = ap.DOC_ID;
            parms.Add(p4);

            OracleParameter p5 = new OracleParameter();
            p5.ParameterName = "any";
            p5.Value = ap.CLNC_ID;
            parms.Add(p5);

            PerformQuery.IUDQuery(parms, qu2);
            PerformQuery.CloseConnection();

        }
        public static int find_doctor(string Email , string Pass)
        {
            PerformQuery.OpenConnection();
            string qu2 = "find_doc";
            List<OracleParameter> inparms = new List<OracleParameter>();
            OracleParameter p2 = new OracleParameter();
            p2.OracleDbType = OracleDbType.Varchar2;
            p2.ParameterName = "doctor_email";
            p2.Value = Email;
            inparms.Add(p2);
            OracleParameter p3 = new OracleParameter();
            p3.OracleDbType = OracleDbType.Varchar2;
            p3.ParameterName = "doc_password";
            p3.Value = Pass;
            inparms.Add(p3);

            List<OracleParameter> outparms = new List<OracleParameter>();
            OracleParameter p4 = new OracleParameter();
            p4.OracleDbType = OracleDbType.Int32;
            p4.ParameterName = "doctor_id";
            p4.Value = -1;
            outparms.Add(p4);

            PerformQuery.OneRowsSelectionProcedure(inparms,outparms, qu2);
            PerformQuery.CloseConnection();
            
            return int.Parse( outparms[0].Value.ToString());


        }
        public static int find_patient(string Email, string Pass)
        {
            string qu2 = "find_patient";
            PerformQuery.OpenConnection();
            List<OracleParameter> inparms = new List<OracleParameter>();
            OracleParameter p2 = new OracleParameter();
            p2.OracleDbType = OracleDbType.Varchar2;
            p2.ParameterName = "pat_email";
            p2.Value = Email;
            inparms.Add(p2);
            OracleParameter p3 = new OracleParameter();
            p3.OracleDbType = OracleDbType.Varchar2;
            p3.ParameterName = "pat_password";
            p3.Value = Pass;
            inparms.Add(p3);

            List<OracleParameter> outparms = new List<OracleParameter>();
            OracleParameter p4 = new OracleParameter();
            p4.OracleDbType = OracleDbType.Int32;
            p4.ParameterName = "pat_id";
            p4.Value = -1;
            outparms.Add(p4);

            PerformQuery.OneRowsSelectionProcedure(inparms, outparms, qu2);
            PerformQuery.CloseConnection();

            return int.Parse(outparms[0].Value.ToString());


        }
        public static DOCTOR Get_doctor_data(int doc_id)
        {
            // task A2 
            
            PerformQuery.OpenConnection();
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p = new OracleParameter();
            p.ParameterName = "any";
            p.Value = doc_id;
            parms.Add(p);
            string get_data = "select DOC_EMAIL ,DOC_ADDRESS,DOC_NAME,DOC_STATE,SPEC_ID,PASSWORD from doctor where DOC_ID=:a";
            OracleDataReader dr= PerformQuery.MultiRowsSelectionQuery(parms, get_data);
            DOCTOR doc = new DOCTOR();
            while(dr.Read())
            {
                doc.DOC_EMAIL = dr[0].ToString() ;
                doc.DOC_ADDRESS = dr[1].ToString();
                doc.DOC_NAME = dr[2].ToString();
                doc.DOC_STATE = dr[3].ToString();
                doc.SPEC_ID =int.Parse( dr[4].ToString());
                doc.PASSWORD = dr[5].ToString();
            }
            PerformQuery.CloseConnection();
            return doc;
        }
        public static PATIENT Get_patient_data(int pat_id)
        {
            // task A2 

            PerformQuery.OpenConnection();
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p = new OracleParameter();
            p.ParameterName = "any";
            p.Value = pat_id;
            parms.Add(p);
            string get_data = "select PATIENT_EMAIL ,PATIENT_NAME,PATIENT_TEL,PATIENT_ADDRESS,AREA_ID,PATIENT_PASSWORD from patient where PATIENT_ID=:a";
            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(parms, get_data);
            PATIENT pat = new PATIENT();
            while (dr.Read())
            {
                pat.PATIENT_EMAIL = dr[0].ToString();
                pat.PATIENT_NAME = dr[1].ToString();
                pat.PATIENT_TEL = dr[2].ToString();
                pat.PATIENT_ADDRESS = dr[3].ToString();
                pat.AREA_ID = int.Parse(dr[4].ToString());
                pat.PATIENT_PASSWORD = dr[5].ToString();
            }
            PerformQuery.CloseConnection();
            return pat;
        }
        public static List<APPOINTMENT> get_appoints(int doc_id)
        {
            PerformQuery.OpenConnection();
            string qu = "select * from appointment where doc_id=:a";
            List<OracleParameter> parms = new List<OracleParameter>();

            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = doc_id;
            parms.Add(p6);
           OracleDataReader dr= PerformQuery.MultiRowsSelectionQuery(parms, qu);
            List<APPOINTMENT> appoints = new List<APPOINTMENT>();
            while (dr.Read())
            {
                APPOINTMENT ap = new APPOINTMENT();
                ap.APPOIN_STATE = dr[0].ToString();
                ap.APPOIN_START_DATE = dr[1].ToString();
                ap.APPOIN_MAX_PATIENTS =int.Parse( dr[2].ToString());
                ap.APPOIN_END_DATE = dr[3].ToString();
                ap.DOC_ID = doc_id;
                ap.CLNC_ID = int.Parse(dr[5].ToString());
                ap.APPOIN_ID= int.Parse(dr[6].ToString());
                appoints.Add(ap);
            }
            PerformQuery.CloseConnection();
            return appoints;

        }
        public static List<APPOINTMENT> get_appoints_by_clinic(int clinic_id)
        {
            PerformQuery.OpenConnection();
            string qu = "select * from appointment where clnc_id=:a";
            List<OracleParameter> parms = new List<OracleParameter>();

            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = clinic_id;
            parms.Add(p6);
            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(parms, qu);
            List<APPOINTMENT> appoints = new List<APPOINTMENT>();
            while (dr.Read())
            {
                APPOINTMENT ap = new APPOINTMENT();
                ap.APPOIN_STATE = dr[0].ToString();
                ap.APPOIN_START_DATE = dr[1].ToString();
                ap.APPOIN_MAX_PATIENTS = int.Parse(dr[2].ToString());
                ap.APPOIN_END_DATE = dr[3].ToString();
                ap.DOC_ID = int.Parse(dr[4].ToString());
                ap.CLNC_ID = int.Parse(dr[5].ToString());
                ap.APPOIN_ID = int.Parse(dr[6].ToString());
                appoints.Add(ap);
            }
            PerformQuery.CloseConnection();
            return appoints;

        }
        public static List<APPOINTMENT> get_appoints(int doc_id,string start_date)
        {
            PerformQuery.OpenConnection();
            string qu = "select * from appointment where doc_id=:a and appoin_start_date like (:a)";
            List<OracleParameter> parms = new List<OracleParameter>();

            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = doc_id;
            parms.Add(p6);

            OracleParameter p7 = new OracleParameter();
            p7.ParameterName = "any";
            p7.Value = start_date;
            parms.Add(p7);
            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(parms, qu);
            List<APPOINTMENT> appoints = new List<APPOINTMENT>();
            while (dr.Read())
            {
                APPOINTMENT ap = new APPOINTMENT();
                ap.APPOIN_STATE = dr[0].ToString();
                ap.APPOIN_START_DATE = dr[1].ToString();
                ap.APPOIN_MAX_PATIENTS = int.Parse(dr[2].ToString());
                ap.APPOIN_END_DATE = dr[3].ToString();
                ap.DOC_ID = doc_id;
                ap.CLNC_ID = int.Parse(dr[5].ToString());
                ap.APPOIN_ID = int.Parse(dr[6].ToString());
                appoints.Add(ap);
            }
            PerformQuery.CloseConnection();
            return appoints;

        }
        public static List<BOOK>get_books_by_doctor(int doc_id,int clnc_id,string start_date)
        {
            // ta2
            PerformQuery.OpenConnection();
            string qu = "select * from books where DOC_ID=:a and clnc_ID=:a and APPOIN_START_DATE =:a";
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = doc_id;
            parms.Add(p6);

            OracleParameter p8 = new OracleParameter();
            p8.ParameterName = "any";
            p8.Value = clnc_id;
            parms.Add(p8);

            OracleParameter p9= new OracleParameter();
            p9.ParameterName = "any";
            p9.Value = start_date;
            parms.Add(p9);
            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(parms, qu);
            List<BOOK> books = new List<BOOK>();
            while (dr.Read())
            {
                BOOK book = new BOOK();
                book.BOOK_STATE = dr[0].ToString();
                book.PATIENT_ID = int.Parse(dr[1].ToString());
                book.APPOIN_START_DATE = dr[2].ToString();
                book.DOC_ID = int.Parse(dr[3].ToString());
                book.CLNC_ID = int.Parse(dr[4].ToString());
                book.APPOIN_END_DATE = dr[5].ToString();
                book.TYPE_ID = int.Parse(dr[6].ToString());
                books.Add(book);
            }
            PerformQuery.CloseConnection();
            return books;
        }
        public static List<BOOK> get_books_by_doctor(int doc_id)
        {
            // ta2
            PerformQuery.OpenConnection();
            string qu = "select * from books where DOC_ID=:a ";
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = doc_id;
            parms.Add(p6);

           
            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(parms, qu);
            List<BOOK> books = new List<BOOK>();
            while (dr.Read())
            {
                BOOK book = new BOOK();
                book.BOOK_STATE = dr[0].ToString();
                book.PATIENT_ID = int.Parse(dr[1].ToString());
                book.APPOIN_START_DATE = dr[2].ToString();
                book.DOC_ID = int.Parse(dr[3].ToString());
                book.CLNC_ID = int.Parse(dr[4].ToString());
                book.APPOIN_END_DATE = dr[5].ToString();
                book.TYPE_ID = int.Parse(dr[6].ToString());
                books.Add(book);
            }
            PerformQuery.CloseConnection();
            return books;
        }
        public static List<BOOK> get_books_by_patient(int pat_id)
        {
            // ta2
            PerformQuery.OpenConnection();
            string qu = "select * from books where patient_id=:a ";
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = pat_id;
            parms.Add(p6);


            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(parms, qu);
            List<BOOK> books = new List<BOOK>();
            while (dr.Read())
            {
                BOOK book = new BOOK();
                book.BOOK_STATE = dr[0].ToString();
                book.PATIENT_ID = int.Parse(dr[1].ToString());
                book.APPOIN_START_DATE = dr[2].ToString();
                book.DOC_ID = int.Parse(dr[3].ToString());
                book.CLNC_ID = int.Parse(dr[4].ToString());
                book.APPOIN_END_DATE = dr[5].ToString();
                book.TYPE_ID = int.Parse(dr[6].ToString());
                books.Add(book);
            }
            PerformQuery.CloseConnection();
            return books;
        }
        public static List<BOOK> get_books_by_appointment(int doc_id, int clnc_id, string start_date)
        {
            PerformQuery.OpenConnection();
            string qu = "select * from books where appoint_id=:a ";
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
           // p6.Value = appoint_id;
            parms.Add(p6);


            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(parms, qu);
            List<BOOK> books = new List<BOOK>();
            while (dr.Read())
            {
                BOOK book = new BOOK();
                book.BOOK_STATE = dr[0].ToString();
                book.PATIENT_ID = int.Parse(dr[1].ToString());
                book.APPOIN_START_DATE = dr[2].ToString();
                book.DOC_ID = int.Parse(dr[3].ToString());
                book.CLNC_ID = int.Parse(dr[4].ToString());
                book.APPOIN_END_DATE = dr[5].ToString();
                book.TYPE_ID = int.Parse(dr[6].ToString());
                books.Add(book);
            }
            PerformQuery.CloseConnection();
            return books;
        }
        public static List<BOOK> get_books_by_clinic(int clinic_id)
        {
            PerformQuery.OpenConnection();
            string qu = "select * from books where clnc_id=:a ";
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = clinic_id;
            parms.Add(p6);


            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(parms, qu);
            List<BOOK> books = new List<BOOK>();
            while (dr.Read())
            {
                BOOK book = new BOOK();
                book.BOOK_STATE = dr[0].ToString();
                book.PATIENT_ID = int.Parse(dr[1].ToString());
                book.APPOIN_START_DATE = dr[2].ToString();
                book.DOC_ID = int.Parse(dr[3].ToString());
                book.CLNC_ID = int.Parse(dr[4].ToString());
                book.APPOIN_END_DATE = dr[5].ToString();
                book.TYPE_ID = int.Parse(dr[6].ToString());
                books.Add(book);
            }
            PerformQuery.CloseConnection();
            return books;
        }
        public static void create_book(BOOK book)
        {
            PerformQuery.OpenConnection();
            string qu2 = "insert into books (BOOK_STATE,PATIENT_ID, APPOIN_START_DATE,DOC_ID, CLNC_ID, APPOIN_END_DATE,TYPE_ID) values(:a, :a, :a,:a,:a,:a,:a) ";

            List<OracleParameter> parms = new List<OracleParameter>();

            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = book.BOOK_STATE;
            parms.Add(p6);

            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = "any";
            p2.Value = book.PATIENT_ID;
            parms.Add(p2);

            OracleParameter p7 = new OracleParameter();
            p7.ParameterName = "any";
            p7.Value = book.APPOIN_START_DATE;
            parms.Add(p7);

            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = "any";
            p3.Value = book.DOC_ID;
            parms.Add(p3);

            OracleParameter p4 = new OracleParameter();
            p4.ParameterName = "any";
            p4.Value = book.CLNC_ID;
            parms.Add(p4);

            OracleParameter p5 = new OracleParameter();
            p5.ParameterName = "any";
            p5.Value = book.APPOIN_END_DATE;
            parms.Add(p5);

            OracleParameter p8 = new OracleParameter();
            p8.ParameterName = "any";
            p8.Value = book.TYPE_ID;
            parms.Add(p8);

            PerformQuery.IUDQuery(parms, qu2);
            PerformQuery.CloseConnection();
        }
        public static ADMIN  get_admin_data(int admin_id)
        {
            PerformQuery.OpenConnection();
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p = new OracleParameter();
            p.ParameterName = "any";
            p.Value = admin_id;
            parms.Add(p);
            string get_data = "select  ADMIN_ID ,ADMIN_EMAIL,ADMIN_NAME,ADMIN_PASSWORD,CLNC_ID from admin where ADMIN_ID=:a";
            OracleDataReader dr = PerformQuery.MultiRowsSelectionQuery(parms, get_data);
            ADMIN admin = new ADMIN();
            while (dr.Read())
            {
                admin.ADMIN_ID =int.Parse( dr[0].ToString());
                admin.ADMIN_EMAIL = dr[1].ToString();
                admin.ADMIN_NAME = dr[2].ToString();
                admin.ADMIN_PASSWORD = dr[3].ToString();
                admin.CLNC_ID =int.Parse( dr[4].ToString());

            }
            PerformQuery.CloseConnection();
            return admin;
        }
        public static int get_admin_data(string admin_email, string admin_pass)
        {
            //ta4
            string qu2 = "find_admin";
            PerformQuery.OpenConnection();
            List<OracleParameter> inparms = new List<OracleParameter>();
            OracleParameter p2 = new OracleParameter();
            p2.OracleDbType = OracleDbType.Varchar2;
            p2.ParameterName = "ad_email";
            p2.Value = admin_email;
            inparms.Add(p2);
            OracleParameter p3 = new OracleParameter();
            p3.OracleDbType = OracleDbType.Varchar2;
            p3.ParameterName = "ad_password";
            p3.Value = admin_pass;
            inparms.Add(p3);

            List<OracleParameter> outparms = new List<OracleParameter>();
            OracleParameter p4 = new OracleParameter();
            p4.OracleDbType = OracleDbType.Int32;
            p4.ParameterName = "ad_id";
            p4.Value = -1;
            outparms.Add(p4);

            PerformQuery.OneRowsSelectionProcedure(inparms, outparms, qu2);
            PerformQuery.CloseConnection();

            return int.Parse(outparms[0].Value.ToString());
        }
        public static void update_book_state(string state,BOOK book)
        {
            // ta3
            PerformQuery.OpenConnection();
            
            string qu2 = "update books set book_state=:a where doc_id=:a and clnc_id=:a and patient_id=:a and APPOIN_START_DATE=:a ";
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = "any";
            p2.Value = state;
            parms.Add(p2);

            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = "any";
            p3.Value = book.DOC_ID;
            parms.Add(p3);

            OracleParameter p4 = new OracleParameter();
            p4.ParameterName = "any";
            p4.Value = book.CLNC_ID;
            parms.Add(p4);

            OracleParameter p5 = new OracleParameter();
            p5.ParameterName = "any";
            p5.Value = book.PATIENT_ID;
            parms.Add(p5);

            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = book.APPOIN_START_DATE;
            parms.Add(p6);

            PerformQuery.IUDQuery(parms, qu2);
            PerformQuery.CloseConnection();
        }
        public static void update_clinic( CLINIC clinic,ADMIN admin)
        {
            PerformQuery.OpenConnection();
            // ta6
            string qu2 = "update_clnc_admin";
            List<OracleParameter> parms = new List<OracleParameter>();
            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = "C_id";
            p2.Value = clinic.CLNC_ID;
            parms.Add(p2);

            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = "C_NAME";
            
            p3.Value = clinic.CLNC_NAME;
            parms.Add(p3);

            OracleParameter p4 = new OracleParameter();
            p4.ParameterName = "C_ADDRESS";
            p4.Value = clinic.CLNC_ADDRESS;
            parms.Add(p4);

            OracleParameter p5 = new OracleParameter();
            p5.ParameterName = "C_EMAIL";
            p5.Value = clinic.CLNC_EMAIL;
            parms.Add(p5);

            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "A_id";
            p6.Value = admin.CLNC_ID;
            parms.Add(p6);

            OracleParameter p7 = new OracleParameter();
            p7.ParameterName = "A_NAME";
            p7.Value = admin.ADMIN_NAME;
            parms.Add(p7);

            OracleParameter p66 = new OracleParameter();
            p66.ParameterName = "A_PASSWORD";
            p66.Value = admin.ADMIN_PASSWORD;
            parms.Add(p66);

            PerformQuery.IUDProcedure(parms, qu2);
            PerformQuery.CloseConnection();
        }
        public static void update_appointment(APPOINTMENT ap)
        {
            if(Helper.get_books_by_doctor(int.Parse( ap.DOC_ID.ToString()),int.Parse( ap.CLNC_ID.ToString()),ap.APPOIN_START_DATE).Count!=0)
            {
                MessageBox.Show("You Can't Update Appointment Once Any Patient Book It");
            }
            else
            {
                //ta3
                PerformQuery.OpenConnection();
                string qu2 = "update appointment set APPOIN_START_DATE=:a , APPOIN_END_DATE=:a , CLNC_ID=:a , APPOIN_STATE=:a , APPOIN_MAX_PATIENTS=:a  where APPOIN_ID=:a";
                List<OracleParameter> parms = new List<OracleParameter>();
                OracleParameter p2 = new OracleParameter();
                p2.ParameterName = "C_id";
                p2.Value = ap.APPOIN_START_DATE.ToString();
                parms.Add(p2);

                OracleParameter p3 = new OracleParameter();
                p3.ParameterName = "C_NAME";
                p3.Value = ap.APPOIN_END_DATE.ToString();
                parms.Add(p3);

                OracleParameter p4 = new OracleParameter();
                p4.ParameterName = "C_ADDRESS";
                p4.Value = ap.CLNC_ID;
                parms.Add(p4);

                OracleParameter p5 = new OracleParameter();
                p5.ParameterName = "C_EMAIL";
                p5.Value = ap.APPOIN_STATE;
                parms.Add(p5);



                OracleParameter p7 = new OracleParameter();
                p7.ParameterName = "A_NAME";
                p7.Value = ap.APPOIN_MAX_PATIENTS;
                parms.Add(p7);

                OracleParameter p66 = new OracleParameter();
                p66.ParameterName = "A_PASSWORD";
                p66.Value = ap.APPOIN_ID;
                parms.Add(p66);

                PerformQuery.IUDQuery(parms, qu2);
                PerformQuery.CloseConnection();
                MessageBox.Show("Appointment Updated");
            }


            
        }
        public static void delete_appointment(APPOINTMENT ap)
        {
            if (Helper.get_books_by_doctor(int.Parse(ap.DOC_ID.ToString()), int.Parse(ap.CLNC_ID.ToString()), ap.APPOIN_START_DATE).Count != 0)
            {
                MessageBox.Show("You Can't Delete Appointment Once Any Patient Book It");
            }
            else
            {
                PerformQuery.OpenConnection();

                string qu2 = "delete appointment   where APPOIN_ID=:a";
                List<OracleParameter> parms = new List<OracleParameter>();
                OracleParameter p2 = new OracleParameter();
                p2.ParameterName = "C_id";
                p2.Value = ap.APPOIN_ID;
                parms.Add(p2);

                PerformQuery.IUDQuery(parms, qu2);
                PerformQuery.CloseConnection();
                MessageBox.Show("Appointment Deleted");
            }

        }
        public static void review_doctor(decimal doc_id, decimal pat_id,string cont )
        {
            PerformQuery.OpenConnection();
            string qu2 = "insert into DOCTORREVIEW values(:a, :a, :a,:a) ";

            List<OracleParameter> parms = new List<OracleParameter>();

            OracleParameter p6 = new OracleParameter();
            p6.ParameterName = "any";
            p6.Value = cont;
            parms.Add(p6);

            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = "any";
            p2.Value = DateTime.Now;
            parms.Add(p2);

            OracleParameter p7 = new OracleParameter();
            p7.ParameterName = "any";
            p7.Value = doc_id;
            parms.Add(p7);

            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = "any";
            p3.Value = pat_id;
            parms.Add(p3);

            

            PerformQuery.IUDQuery(parms, qu2);
            PerformQuery.CloseConnection();
        }
        public static int validit_email(string email )
        {
            string qu2 = "validit_email";
            PerformQuery.OpenConnection();
            List<OracleParameter> inparms = new List<OracleParameter>();
            OracleParameter p2 = new OracleParameter();
            p2.OracleDbType = OracleDbType.Varchar2;
            p2.ParameterName = "ad_email";
            p2.Value = email;
            inparms.Add(p2);


            List<OracleParameter> outparms = new List<OracleParameter>();
            OracleParameter p4 = new OracleParameter();
            p4.OracleDbType = OracleDbType.Int32;
            p4.ParameterName = "bool_val";
            p4.Value = -1;
            outparms.Add(p4);

            PerformQuery.OneRowsSelectionProcedure(inparms, outparms, qu2);
            PerformQuery.CloseConnection();

            return int.Parse(outparms[0].Value.ToString());
        }
    }
}
