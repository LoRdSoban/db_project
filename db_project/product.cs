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
    public partial class product : Form
    {
        Connect DB_Connect;
        OracleConnection con;
        public product()
        {
            InitializeComponent();
        }
        private void product_Load(object sender, EventArgs e)
        {
            DB_Connect= new Connect();
            loadCategories();
        }

        private void loadCategories()
        {
            con = DB_Connect.connect(); 

            string query = "SELECT * FROM CATEGORY";
            OracleCommand command = new OracleCommand(query, con);
            OracleDataAdapter da = new OracleDataAdapter(command);

            DataSet dataSet= new DataSet();
            da.Fill(dataSet);
            command.ExecuteNonQuery();
            con.Close();

            category_add.DataSource= dataSet.Tables[0];
            category_add.DisplayMember = "category_name";
            category_add.ValueMember= "category_id";

            category_update.DataSource = dataSet.Tables[0];
            category_update.DisplayMember = "category_name";
            category_update.ValueMember = "category_id";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (prodID_add.Text == "" || name_add.Text == "" || rackID_add.Text == "" || salePrice_add.Text == "" || purchasePrice_add.Text == "" || reorderPoint_add.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            try
            {

                con = DB_Connect.connect();

                string query = "INSERT INTO PRODUCT VALUES (:id, :name, :rack, :cat, :sale, :purchase, :left, :reorder)";
                using (OracleCommand command = new OracleCommand(query, con))
                {
                    int salePrice = Convert.ToInt32(salePrice_add.Text);
                    int purchasePrice = Convert.ToInt32(purchasePrice_add.Text);
                    int left = Convert.ToInt32(quantity_add.Text);
                    int reorder = Convert.ToInt32(reorderPoint_add.Text);

                    command.Parameters.Add(new OracleParameter("id", prodID_add.Text));
                    command.Parameters.Add(new OracleParameter("name", name_add.Text));
                    command.Parameters.Add(new OracleParameter("rack", rackID_add.Text));
                    command.Parameters.Add(new OracleParameter("cat", category_add.SelectedValue));
                    command.Parameters.Add(new OracleParameter("sale", salePrice));
                    command.Parameters.Add(new OracleParameter("purchase", purchasePrice));
                    command.Parameters.Add(new OracleParameter("left", left));
                    command.Parameters.Add(new OracleParameter("reorder", reorder));

                    int i = command.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Product Added Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Product Addition Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            prodID_add.Clear();
            name_add.Clear();
            rackID_add.Clear();
            salePrice_add.Clear();
            purchasePrice_add.Clear();
            quantity_add.Clear();
            reorderPoint_add.Clear();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (prodID_update.Text == "" || name_update.Text == "" || rackID_update.Text == "" || salePrice_update.Text == "" || purchasePrice_update.Text == "" || reorderPoint_update.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {

                con = DB_Connect.connect();

                string query = "UPDATE PRODUCT SET product_name = :name, rack_id = :rack, categ_id = :cat, sale_price = :sale, purchase_price = :purchase, quantity_left = :left, reorder_point = :reorder WHERE  product_id = :id";
                using (OracleCommand command = new OracleCommand(query, con))
                {
                    int salePrice = Convert.ToInt32(salePrice_update.Text);
                    int purchasePrice = Convert.ToInt32(purchasePrice_update.Text);
                    int left = Convert.ToInt32(quantity_update.Text);
                    int reorder = Convert.ToInt32(reorderPoint_update.Text);

                    command.Parameters.Add(new OracleParameter("name", name_update.Text));
                    command.Parameters.Add(new OracleParameter("rack", rackID_update.Text));
                    command.Parameters.Add(new OracleParameter("cat", category_update.SelectedValue));
                    command.Parameters.Add(new OracleParameter("sale", salePrice));
                    command.Parameters.Add(new OracleParameter("purchase", purchasePrice));
                    command.Parameters.Add(new OracleParameter("left", left));
                    command.Parameters.Add(new OracleParameter("reorder", reorder));
                    
                    command.Parameters.Add(new OracleParameter("id", prodID_update.Text));

                    int i = command.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Product Updated Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Product Updation Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            prodID_update.Clear();
            name_update.Clear();
            rackID_update.Clear();
            salePrice_update.Clear();
            purchasePrice_update.Clear();
            quantity_update.Clear();
            reorderPoint_update.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
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

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void prodID_update_Leave(object sender, EventArgs e)
        {
            try
            {

                con = DB_Connect.connect();

                string query = "SELECT * FROM PRODUCT WHERE product_id = :id";
                using (OracleCommand command = new OracleCommand(query, con))
                {

                    command.Parameters.Add(new OracleParameter("id", prodID_update.Text));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name_update.Text = reader.GetString(1);
                            rackID_update.Text = reader.GetString(2);
                            category_update.SelectedValue = reader.GetString(3);
                            salePrice_update.Text = Convert.ToString(reader.GetInt32(4));
                            purchasePrice_update.Text = Convert.ToString(reader.GetInt32(5));
                            quantity_update.Text = Convert.ToString(reader.GetInt32(6));
                            reorderPoint_update.Text = Convert.ToString(reader.GetInt32(7));


                        }
                        else
                        {
                            MessageBox.Show("Wrong ID", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (prodID_del.Text == "")
            {
                MessageBox.Show("Please provide the Product ID", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {

                con = DB_Connect.connect();

                string query = "DELETE FROM PRODUCT WHERE  product_id = :id";
                using (OracleCommand command = new OracleCommand(query, con))
                {

                    command.Parameters.Add(new OracleParameter("id", prodID_del.Text));

                    int i = command.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Product Deleted Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Product Deletion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            prodID_del.Clear();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con = DB_Connect.connect();

                string query = "SELECT * FROM PRODUCT WHERE product_id LIKE :id ORDER BY product_id";
                using (OracleCommand command = new OracleCommand(query, con))
                {
                    command.Parameters.Add(new OracleParameter("id", prodID_search.Text + "%"));


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

            prodID_search.Clear();
        }
    }
}
