using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace db_project
{

    public partial class cust2 : Form
    {
        Connect DB_Connect;
        OracleConnection con;
        public cust2()
        {
            InitializeComponent();
        }

        private void cust2_Load(object sender, EventArgs e)
        {
            DB_Connect = new Connect();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

            try
            {
                con = DB_Connect.connect();

                string query = "SELECT * FROM CUSTOMERS WHERE cust_id LIKE :id ORDER BY cust_id";
                using (OracleCommand command = new OracleCommand(query, con))
                {
                    command.Parameters.Add(new OracleParameter("id", custID_search.Text + "%"));


                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        DataTable empDT = new DataTable();
                        empDT.Load(reader);
                        dataGridView1.DataSource = empDT;
                    }

                    con.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            string custID = dataGridView1.Rows[e.RowIndex].Cells["cust_id"].Value.ToString();

            try
            {
                con = DB_Connect.connect();

                string query = "SELECT * FROM RECEIPTS WHERE cust_id = :id";

                using (OracleCommand command = new OracleCommand(query, con))
                {
                    command.Parameters.Add(new OracleParameter("id", custID));


                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        DataTable empDT = new DataTable();
                        empDT.Load(reader);
                        dataGridView2.DataSource = empDT;
                    }

                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }


        }
    }
}
