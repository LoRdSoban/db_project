using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace db_project
{
    public class Connect
    {
        OracleConnection con;

        public static string cs = @"Data Source= localhost:1521/xe; User ID =DBPROJECT;Password=qwerty;";

        public OracleConnection connect()
        {
            try
            {
                con = new OracleConnection(cs);
                con.Open();
                return con;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void closeConnection()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        /*internal void Connect()
        {
            throw new NotImplementedException();
        }*/
    }
}
