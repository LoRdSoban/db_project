using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace db_project
{
    public partial class login : Form
    {
        Connect DB_Connect;
        OracleConnection con;
        public login()
        {
            
            InitializeComponent();
           
        }

        private void login_Load(object sender, EventArgs e)
        {
            DB_Connect = new Connect();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //usernamr
        {
            
        }
        private void Form1_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void button1_Click(object sender, EventArgs e)  // login button
        {
            string id = textBox2.Text;
            string query = "SELECT emp_password, emp_position, emp_email FROM Employees WHERE emp_id = :emp_id";
            using (OracleCommand command = new OracleCommand(query, con))
            {
                command.Parameters.Add("emp_id", OracleDbType.Varchar2).Value = id;
                try
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string password = reader.GetString(0);
                            string position = reader.GetString(1);
                            string email = reader.GetString(2);

                            if (password == password_text.Text && email ==username_text.Text && position == "Salesman")
                            {
                                // Login successful
                                salesman obj = new salesman();
                                obj.Show();
                                this.Hide();

                            }
                            else
                            {
                                // Login failed
                                MessageBox.Show("Access denied");
                            }
                        }
                        else
                        {
                            // No employee with this ID found
                            MessageBox.Show("Wrong ID ");
                        }

                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("errr");
                }
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //clear
        {
            textBox2.Text = string.Empty;
            username_text.Text = string.Empty;
            password_text.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // table from oracle and match email with pass
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = textBox3.Text;
            con = DB_Connect.connect();
            string query = "SELECT emp_password, emp_position, emp_email FROM Employees WHERE emp_id = :emp_id";
            using (OracleCommand command = new OracleCommand(query, con))
            {
               command.Parameters.Add("emp_id",OracleDbType.Varchar2).Value= id;
                try
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string password = reader.GetString(0);
                            string position = reader.GetString(1);
                            string email = reader.GetString(2);
                            
                            if (password == textBox1.Text && email == textBox4.Text && position == "Admin")
                            {
                                // Login successful
                                MessageBox.Show("Welcome to Admin Menu");
                                main obj = new main();
                                obj.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Login failed
                                MessageBox.Show("Access denied");
                            }
                        }
                        else
                        {
                            // No employee with this ID found
                            MessageBox.Show("Wrong ID ");
                        }

                        con.Close();    
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("errr");
                }
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();

            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox1.Text = string.Empty;
        }
    }
}
