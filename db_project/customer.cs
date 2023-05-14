using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace db_project
{
    public partial class customer : Form
    {
        Connect DB_Connect;
        OracleConnection con;
        public customer()
        {
            InitializeComponent();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            DB_Connect = new Connect();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            if (custID_add.Text == "" || name_add.Text == "" || contact_add.Text == "" || address_add.Text == "" || contact_add.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contact_add.Text.Length != 11)
            {
                MessageBox.Show("Enter valid Phone number", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                con = DB_Connect.connect();

                string query = "INSERT INTO CUSTOMERS VALUES (:id, :name, :contact, :email, :address)";
                using (OracleCommand command = new OracleCommand(query, con))
                {
                    long cont = Convert.ToInt64(contact_add.Text);

                    command.Parameters.Add(new OracleParameter("id", custID_add.Text) );
                    command.Parameters.Add(new OracleParameter("name", name_add.Text) );
                    command.Parameters.Add(new OracleParameter("contact", cont) );
                    command.Parameters.Add(new OracleParameter("email", email_add.Text) );
                    command.Parameters.Add(new OracleParameter("address", address_add.Text) );

                    int i = command.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Customer Added Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Customer Addition Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (custID_del.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            try
            {

                con = DB_Connect.connect();

                string query = "DELETE FROM CUSTOMERS WHERE cust_id = :id";
                using (OracleCommand command = new OracleCommand(query, con))
                {


                    command.Parameters.Add(new OracleParameter("id", custID_del.Text));
                   
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //del cust
            // msgbox  alert
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // updatecust
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void custID_update_Leave(object sender, EventArgs e)
        {
 
            try
            {

                con = DB_Connect.connect();

                string query = "SELECT cust_name, contact, email, address FROM CUSTOMERS WHERE cust_id = :id";
                using (OracleCommand command = new OracleCommand(query, con))
                {


                    command.Parameters.Add(new OracleParameter("id", custID_update.Text));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader.GetString(0);
                            long contact = reader.GetInt64(1);
                            string email = reader.GetString(2);
                            string adress = reader.GetString(3);

                            string contact_str = Convert.ToString(contact);

                            name_update.Text = name;
                            contact_update.Text = (contact_str.Length != 11)? "0" + contact_str : contact_str ;
                            email_update.Text = email;
                            address_update.Text = adress;

                        }
                        else
                        {
                            MessageBox.Show("Wrong ID");
                        }

                        con.Close();
                    }
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (custID_update.Text == "" || name_update.Text == "" || contact_update.Text == "" || address_update.Text == "" || contact_update.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contact_update.Text.Length != 11)
            {
                MessageBox.Show("Enter valid Phone number", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                con = DB_Connect.connect();

                string query = "UPDATE CUSTOMERS SET cust_name = :name, contact = :cust_contact, email = :cust_email, address = :cust_address WHERE cust_id = :id";

                using (OracleCommand command = new OracleCommand(query, con))
                {
                    long cont = Convert.ToInt64(contact_update.Text);


                    command.Parameters.Add(new OracleParameter("name", name_update.Text));
                    command.Parameters.Add(new OracleParameter("cust_contact", cont));
                    command.Parameters.Add(new OracleParameter("cust_email", email_update.Text));
                    command.Parameters.Add(new OracleParameter("cust_address", address_update.Text));
                    command.Parameters.Add(new OracleParameter("id", custID_update.Text));

                    int i = command.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Customer Updated Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Customer Updation Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    contact_update.Clear();
                    name_update.Clear();
                    email_update.Clear();
                    address_update.Clear();
                    custID_update.Clear();

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
