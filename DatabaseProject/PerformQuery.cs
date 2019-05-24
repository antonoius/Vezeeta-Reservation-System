using System;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DatabaseProject
{
    

    public static class  PerformQuery
    {
        static string con_string = "data source=orcl; user id=project_v1; password=0129272801;";

        //static string con_string2 = "data source=orcl; user id=scott; password=tiger;";
        static OracleConnection con = new OracleConnection();
        public static void OpenConnection()
        {
            try
            {
                con.ConnectionString = con_string;
                con.Open();
            }
            catch (Exception)
            {

                //throw;
            }

        }
        public static void CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {

              //  throw;
            }
           
        }
        public static int IUDQuery(List<OracleParameter> parameters,string query)
        {
            OracleCommand com = new OracleCommand();
            com.Connection = con;
            com.CommandType= CommandType.Text;
            com.CommandText = query;
            for (int i = 0; i < parameters.Count; i++)
            {
                
                com.Parameters.Add( parameters[i]);
            }
            int x = com.ExecuteNonQuery();
            
            return x;


        }
        public static OracleDataReader MultiRowsSelectionQuery(List<OracleParameter> parameters, string query)
        {

            
            OracleCommand com = new OracleCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = query;
            OracleParameter p = new OracleParameter();
            
            for (int i = 0; i < parameters.Count; i++)
            {
                com.Parameters.Add( parameters[i]);
            }
            OracleDataReader dr = com.ExecuteReader();

            // MessageBox.Show(dr[0].ToString());
            //con.Close();
            return dr;
        }
        public static OracleDataReader MultiRowsSelectionProcedure(List<OracleParameter> parameters, string procedure)
        {
            OracleCommand com = new OracleCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = procedure;
            for (int i = 0; i < parameters.Count; i++)
            {
                com.Parameters.Add(parameters[i]);
            }
            com.Parameters.Add("any", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = com.ExecuteReader();
            //dr.Close();
            //con.Close();
            return dr;
        }
        public static int IUDProcedure(List<OracleParameter> parameters, string procedure)
        {
            OracleCommand com = new OracleCommand();
            com.Connection = con;
            com.CommandText = procedure;
            com.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameters.Count; i++)
            {
                parameters[i].Direction = ParameterDirection.Input;
                com.Parameters.Add( parameters[i]);
            }
            int re = com.ExecuteNonQuery();
            //con.Close();
            return re;
        }
        public static int OneRowsSelectionProcedure(List<OracleParameter> INparameters, List<OracleParameter> Outparameters, string procedure)
        {
            OracleCommand com = new OracleCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = procedure;
            for (int i = 0; i < INparameters.Count; i++)
            {
                INparameters[i].Direction = ParameterDirection.Input;
                com.Parameters.Add(INparameters[i]);
            }
            for (int i = 0; i < Outparameters.Count; i++)
            {

                Outparameters[i].Direction = ParameterDirection.Output;
                com.Parameters.Add(Outparameters[i]);
            }
            // com.Parameters.Add("any", OracleDbType.RefCursor, ParameterDirection.Output);
            try
            {
                int x = com.ExecuteNonQuery();
                //con.Close();
              return  x;
            }
            catch (Exception)
            {
                //con.Close();
                return -1;
            }
           
        }


    }
}
