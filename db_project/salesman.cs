using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_project
{
    public partial class salesman : Form
    {
        Connect DB_Connect;
        OracleConnection con;
        int curr_inv_id;
        public salesman()
        {
            InitializeComponent();
        }

        private void salesman_Load(object sender, EventArgs e)
        {
            DB_Connect = new Connect();
            loadInvoiceNo();

            salesmanName.Text = LoginDetails.SalesmanName;

            //tabPage2.Text = "Receipt";
            // product.TabPages.Add(tabPage2);

        }
        private void loadInvoiceNo()
        {
            try
            {

                con = DB_Connect.connect();

                string query = "SELECT inv_id_seq.CURRVAL FROM dual";
                using (OracleCommand command = new OracleCommand(query, con))
                {

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            curr_inv_id = reader.GetInt32(0) + 1;

                            InvID.Text = Convert.ToString(curr_inv_id);
                        }

                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                InvID.Text = "1";
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // select from order items of cust_id
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            DialogResult d;
           d= MessageBox.Show("Progress will be lost!\nAre you really want to close?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(d==DialogResult.Yes)
            {
                Close();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();

              
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            // inset row in order table
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // will display the filtered product when enter product id
        }

        private void ProdName_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = DB_Connect.connect();

                string query = "SELECT product_id, product_name, sale_price, quantity_left FROM PRODUCT WHERE product_name LIKE :name ORDER BY product_id";
                using (OracleCommand command = new OracleCommand(query, con))
                {
                    command.Parameters.Add(new OracleParameter("name", ProdName_search.Text + "%"));


                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        DataTable empDT = new DataTable();
                        empDT.Load(reader);
                        dataGridView3.DataSource = empDT;
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


        private void ProdID_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = DB_Connect.connect();

                string query = "SELECT product_id, product_name, sale_price, quantity_left FROM PRODUCT WHERE product_id LIKE :id ORDER BY product_id";
                using (OracleCommand command = new OracleCommand(query, con))
                {
                    command.Parameters.Add(new OracleParameter("id", ProdID_search.Text + "%"));


                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        DataTable empDT = new DataTable();
                        empDT.Load(reader);
                        dataGridView3.DataSource = empDT;
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

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.CurrentRow.Selected = true;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            if (dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row is selected", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (prodQuantity.Text == "")
            {
                MessageBox.Show("Invalid Quantity", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string prodID = dataGridView3.SelectedRows[0].Cells["product_id"].Value.ToString();
            string prodName = dataGridView3.SelectedRows[0].Cells["product_name"].Value.ToString();
            int sale_price = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["sale_price"].Value.ToString());
            int quantity_left = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["quantity_left"].Value.ToString());
            int quantity = Convert.ToInt32(prodQuantity.Text);

            if(quantity <= 0 || quantity > quantity_left ) 
            {
                MessageBox.Show("Invalid Quantity", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool found = false;
            for(int x = 0; x < dataGridView2.Rows.Count-1; x++)
            {
                if(dataGridView2.Rows[x].Cells[0].Value.ToString() == prodID)
                {
                    found = true;

                    dataGridView2.Rows[x].Cells[3].Value = Convert.ToString(Convert.ToInt32(dataGridView2.Rows[x].Cells[3].Value.ToString()) + quantity);
                }
            }

            if( found == false)
            {
                int i = dataGridView2.Rows.Add();

                dataGridView2.Rows[i].Cells[0].Value = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                dataGridView2.Rows[i].Cells[1].Value = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                dataGridView2.Rows[i].Cells[2].Value = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                dataGridView2.Rows[i].Cells[3].Value = Convert.ToString(quantity);


                Total_textbox.Text = Convert.ToString(Convert.ToInt32(Total_textbox.Text) + (quantity * sale_price));
            }
           

            removeProductFromDB(prodID, quantity);

        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            string prodID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            string prodName = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();

            int sale_price = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[2].Value.ToString());
            int quantity = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[3].Value.ToString());


            Total_textbox.Text = Convert.ToString(Convert.ToInt32(Total_textbox.Text) - (quantity * sale_price));

            dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);

            AddProductToDB(prodID, quantity);
        }

        private bool custID_exist(string id)
        {

            try
            {
                con = DB_Connect.connect();

                string query = "SELECT * FROM CUSTOMERS WHERE cust_id = :id";
                using (OracleCommand command = new OracleCommand(query, con))
                {
                    //string theDate = date.Value.ToString("dd-MM-yyyy");

                    command.Parameters.Add(new OracleParameter("id", custID.Text));
                  
                    int i = command.ExecuteNonQuery();

                    con.Close();
                    
                    if(i == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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

            return false;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(dataGridView2.Rows.Count == 1)
            {
                MessageBox.Show("Please add a item!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(custID_exist(custID.Text) == false)
            {
                MessageBox.Show("Customer ID does not exist!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con = DB_Connect.connect();

                string query = "INSERT INTO RECEIPTS VALUES (inv_id_seq.NEXTVAL, :custID, :salesman, :invDate, :amount)";
                using (OracleCommand command = new OracleCommand(query, con))
                {
                    //string theDate = date.Value.ToString("dd-MM-yyyy");

                    command.Parameters.Add(new OracleParameter("custID", custID.Text));
                    command.Parameters.Add(new OracleParameter("salesman", LoginDetails.SalesmanName));
                    command.Parameters.Add("invDate", OracleDbType.Date).Value = date.Value;
                    command.Parameters.Add(new OracleParameter("amount", Convert.ToInt32(Total_textbox.Text)));

                    int i = command.ExecuteNonQuery();

                    Console.WriteLine("\n\n\n" + i + "\n\n\n");
                }

                for(int i =0; i < dataGridView2.Rows.Count-1;i++)
                {
                    query = "INSERT INTO RECEIPT_DETAILS VALUES (inv_id_seq.CURRVAL, :prodID, :quantity)";
                    using (OracleCommand command = new OracleCommand(query, con))
                    {

                        command.Parameters.Add(new OracleParameter("prodID", dataGridView2.Rows[i].Cells[0].Value));
                        command.Parameters.Add(new OracleParameter("quantity", Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value)));

                        command.ExecuteNonQuery();
                    }
                }

                dataGridView2.Rows.Clear();
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
        void removeProductFromDB(string prodID, int new_quantity)
        {
            try
            {

                con = DB_Connect.connect();

                string query = "UPDATE PRODUCT SET quantity_left = quantity_left - :left WHERE  product_id = :id";

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Total_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true;
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void InvID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
