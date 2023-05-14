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

namespace db_project
{
    public partial class category : Form
    {

        Connect DB_Connect;
        OracleConnection con;
        public category()
        {
            InitializeComponent();
        }

        private void category_Load(object sender, EventArgs e)
        {
            DB_Connect = new Connect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (id_add.Text == "" || name_add.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                con = DB_Connect.connect();

                string query = "INSERT INTO CATEGORY VALUES (:id, :name)";
                using (OracleCommand command = new OracleCommand(query, con))
                {


                    command.Parameters.Add(new OracleParameter("id", id_add.Text));
                    command.Parameters.Add(new OracleParameter("name", name_add.Text));

                    int i = command.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Category Added Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Catergory Addition Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            id_add.Clear();
            name_add.Clear();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (id_del.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {

                con = DB_Connect.connect();

                string query = "DELETE FROM CATEGORY WHERE category_id = :id";
                using (OracleCommand command = new OracleCommand(query, con))
                {


                    command.Parameters.Add(new OracleParameter("id", id_del.Text));

                    int i = command.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Customer Deleted Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Customer Deletion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            id_del.Clear();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (id_update.Text == "" || name_update.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                con = DB_Connect.connect();

                string query = "UPDATE CATEGORY SET category_name = :name WHERE category_id = :id";
                using (OracleCommand command = new OracleCommand(query, con))
                {

                    command.Parameters.Add(new OracleParameter("name", name_update.Text));
                    command.Parameters.Add(new OracleParameter("id", id_update.Text));

                    int i = command.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Category Updated Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Catergory Updation Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            id_update.Clear();
            name_update.Clear();
        }
    }
}
