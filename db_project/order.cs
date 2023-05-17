using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_project
{
    public partial class order : Form
    {
        int curr_order_id;
        Connect DB_Connect;
        OracleConnection con;
        public order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            DB_Connect = new Connect();

            loadVendors();
            loadOrderID();
        }

        private void loadVendors()
        {
            con = DB_Connect.connect();

            string query = "SELECT * FROM VENDOR";
            OracleCommand command = new OracleCommand(query, con);
            OracleDataAdapter da = new OracleDataAdapter(command);

            DataSet ds = new DataSet();
            da.Fill(ds);
            command.ExecuteNonQuery();
            con.Close();

            ven_name.DataSource = ds.Tables[0];
            ven_name.DisplayMember = "V_NAME";
            ven_name.ValueMember = "V_ID";

           
        }
        private void loadOrderID()
        {
            try
            {

                con = DB_Connect.connect();

                string query = "SELECT COUNT(*) FROM ORDERS";
                using (OracleCommand command = new OracleCommand(query, con))
                {

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            curr_order_id = reader.GetInt32(0) + 1;

                            OrderID.Text = Convert.ToString(curr_order_id);
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
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void ven_name_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                con = DB_Connect.connect();

                string query = "SELECT v.p_id, p.product_name, p.purchase_price FROM VENDOR v, PRODUCT p WHERE v_id = :id AND v.p_id = p.product_id";
                using (OracleCommand command = new OracleCommand(query, con))
                {

                    command.Parameters.Add(new OracleParameter("id", ven_name.SelectedValue));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            prodID.Text = reader.GetString(0);
                            prodName.Text = reader.GetString(1);
                            purchasePrice.Text = Convert.ToString(reader.GetInt32(2));
                            vendorID.Text = ven_name.SelectedValue.ToString();

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

        private void save_btn_Click(object sender, EventArgs e)
        {
           
            if (quantity.Text == "")
            {
                MessageBox.Show("Please enter the quantity!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con = DB_Connect.connect();

                string query = "INSERT INTO ORDERS VALUES (order_id_seq.NEXTVAL, :venID, :invDate, :amount)";
                using (OracleCommand command = new OracleCommand(query, con))
                {
                    //string theDate = date.Value.ToString("dd-MM-yyyy");

                    command.Parameters.Add(new OracleParameter("venID", vendorID.Text));
                    command.Parameters.Add("invDate", OracleDbType.Date).Value = date.Value;
                    command.Parameters.Add(new OracleParameter("amount", Convert.ToInt32(Total_textbox.Text)));

                    command.ExecuteNonQuery();

                }

             
                query = "INSERT INTO ORDER_DETAILS VALUES (order_id_seq.CURRVAL, :prod_ID, :quant)";
                using (OracleCommand command = new OracleCommand(query, con))
                {

                    command.Parameters.Add(new OracleParameter("prod_ID", prodID.Text));
                    command.Parameters.Add(new OracleParameter("quant", Convert.ToInt32(quantity.Text)));

                    command.ExecuteNonQuery();
                }

                AddProductToDB(prodID.Text, Convert.ToInt32(quantity.Text));

                MessageBox.Show("Order Added Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
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
            loadOrderID();
        }

        void AddProductToDB(string prodID, int new_quantity)
        {
            try
            {

                con = DB_Connect.connect();

                string query = "UPDATE PRODUCT SET quantity_left = quantity_left + :left WHERE  product_id = :id";

                using (OracleCommand command = new OracleCommand(query, con))
                {

                    command.Parameters.Add(new OracleParameter("left", Convert.ToString(new_quantity)));
                    command.Parameters.Add(new OracleParameter("id", prodID));

                    int i = command.ExecuteNonQuery();

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

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(quantity.Text) * Convert.ToInt32(purchasePrice.Text);

            Total_textbox.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }
    }
}
