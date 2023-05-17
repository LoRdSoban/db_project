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
    public partial class vendor : Form
    {
        Connect DB_Connect;
        OracleConnection con;
        int vendor_inv_id;
        public vendor()
        {
            InitializeComponent();
        }

        private void vendor_Load(object sender, EventArgs e)
        {
            DB_Connect= new Connect();
            loadProducts();
            loadVendors();
            loadVendorID();
        }

        private void loadProducts()
        {
            con = DB_Connect.connect();

            string query = "SELECT * FROM PRODUCT";
            OracleCommand command = new OracleCommand(query, con);
            OracleDataAdapter da = new OracleDataAdapter(command);

            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            command.ExecuteNonQuery();
            con.Close();

            Product_add.DataSource = dataSet.Tables[0];
            Product_add.DisplayMember = "product_name";
            Product_add.ValueMember = "product_id";

            //Product_update.DataSource = dataSet.Tables[0];
            //Product_update.DisplayMember = "product_name";
            //Product_update.ValueMember = "product_id";
        }

        private void loadVendors()
        {
            con = DB_Connect.connect();

            string query = "SELECT * FROM VENDOR";
            OracleCommand command = new OracleCommand(query, con);
            OracleDataAdapter da = new OracleDataAdapter(command);

            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            command.ExecuteNonQuery();
            con.Close();

            Product_update.DataSource = dataSet.Tables[0];
            Product_update.DisplayMember = "V_NAME";
            Product_update.ValueMember = "V_ID";


        }

        private void loadVendorID()
        {
            try
            {

                con = DB_Connect.connect();

                string query = "SELECT COUNT(*) FROM VENDOR";
                using (OracleCommand command = new OracleCommand(query, con))
                {

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            vendor_inv_id = reader.GetInt32(0) + 1;

                            vendorID_add.Text = Convert.ToString(vendor_inv_id);
                        }

                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                vendorID_add.Text = "1";
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (vendorID_add.Text == "" || Name_add.Text == "" || Contact_add.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Contact_add.Text.Length != 11)
            {
                MessageBox.Show("Enter valid Phone number", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                con = DB_Connect.connect();

                string query = "INSERT INTO VENDOR VALUES (vendor_id_seq.NEXTVAL, :p_id, :name, :contact)";
                using (OracleCommand command = new OracleCommand(query, con))
                {


                    command.Parameters.Add(new OracleParameter("p_id", Product_add.SelectedValue));
                    command.Parameters.Add(new OracleParameter("name", Name_add.Text));
                    command.Parameters.Add(new OracleParameter("contact", Convert.ToInt64(Contact_add.Text)));

                    int i = command.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Vendor Added Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Vendor Addition Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            loadVendorID();
            Name_add.Clear();
            Contact_add.Clear();
        }

        private void vendorID_update_Leave(object sender, EventArgs e)
        {

            try
            {
                con = DB_Connect.connect();

                string query = "SELECT p_id, v_name, contact FROM VENDOR WHERE v_id = :id";
                using (OracleCommand command = new OracleCommand(query, con))
                {

                    command.Parameters.Add(new OracleParameter("id", vendorID_update.Text));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Product_update.SelectedValue = reader.GetString(0);
                            string name = reader.GetString(1);
                            long contact = reader.GetInt64(2);

                            string contact_str = Convert.ToString(contact);

                            Name_update.Text = name;
                            Contact_update.Text = (contact_str.Length != 11) ? "0" + contact_str : contact_str;

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
            if (vendorID_add.Text == "" || Name_add.Text == "" || Contact_add.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Contact_update.Text.Length != 11)
            {
                MessageBox.Show("Enter valid Phone number", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                con = DB_Connect.connect();

                string query = "UPDATE VENDOR SET p_id = :Pid, v_name = :name, contact = :cont WHERE v_id = Vid";
                using (OracleCommand command = new OracleCommand(query, con))
                {


                    command.Parameters.Add(new OracleParameter("Pid", Product_update.SelectedValue));
                    command.Parameters.Add(new OracleParameter("name", Name_update.Text));
                    command.Parameters.Add(new OracleParameter("contact", Convert.ToInt64(Contact_update.Text)));

                    command.Parameters.Add(new OracleParameter("Vid", vendorID_update.Text));

                    int i = command.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Vendor Updated Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Vendor Updation Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            vendorID_update.Clear();
            Name_update.Clear();
            Contact_update.Clear();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (vendorID_del.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                con = DB_Connect.connect();

                string query = "DELETE FROM VENDOR WHERE v_id = :id";
                using (OracleCommand command = new OracleCommand(query, con))
                {


                    command.Parameters.Add(new OracleParameter("id", vendorID_del.Text));

                    int i = command.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Vendor Deleted Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Vendor Deletion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
