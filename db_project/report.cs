using DGVPrinterHelper;
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
    public partial class report : Form
    {

        OracleConnection con;
        Connect DB_Connect;
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            DB_Connect= new Connect();  
            loadSalesReport();
            loadInventoryReport();

        }

        private void loadSalesReport()
        {

            try
            {
                con = DB_Connect.connect();

                string query = "SELECT * FROM sales_report";
                using (OracleCommand command = new OracleCommand(query, con))
                {
                 
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

        private void loadInventoryReport()
        {
            try
            {
                con = DB_Connect.connect();

                string query = "SELECT * FROM inventory_report";
                using (OracleCommand command = new OracleCommand(query, con))
                {

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

        private void print1_btn_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinter();
            printer.Title = "\n\nSALES REPORT \n\n";//Header
            printer.SubTitle = string.Format("LoonayWala, Faisalabad \n Phone: 0300-9876543 \n\n Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.FooterAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.Footer = "Shop Management System";

            printer.printDocument.DefaultPageSettings.Landscape = false;

            printer.PrintPreviewDataGridView(dataGridView1);
            //printer.PrintDataGridView(dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DGVPrinterHelper.DGVPrinter printer = new DGVPrinter();
            printer.Title = "\n\nINVENTORY REPORT \n\n";//Header
            printer.SubTitle = string.Format("LoonayWala, Faisalabad \n Phone: 0300-9876543 \n\n Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.FooterAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.Footer = "Shop Management System";

            printer.printDocument.DefaultPageSettings.Landscape = false;

            printer.PrintPreviewDataGridView(dataGridView2);
            //printer.PrintDataGridView(dataGridView2);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }
            


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
