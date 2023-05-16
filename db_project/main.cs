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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // Create the tab control
           
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ((ContextMenuStrip)sender).Show(Cursor.Position);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Show the Form2 form
          
        }

        // Event handler for the Click event of the Menu Item 2 control
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Do something else
        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer form2 = new customer();
            form2.Show();
            this.Hide();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void notificationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            customer obj = new customer();
            obj.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer obj = new customer();
            obj.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer obj = new customer();
            obj.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cust2 obj = new cust2();
            obj.Show();
            this.Hide();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cust2 obj = new cust2();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            category obj = new category();
            obj.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            category obj = new category();
            obj.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            category obj = new category();
            obj.Show();
            this.Hide();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            product obj = new product();
            obj.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            product obj = new product();
            obj.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            product obj = new product();
            obj.Show();
            this.Hide();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            vendor obj = new vendor();
            obj.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            vendor obj = new vendor();
            obj.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            vendor obj = new vendor();
            obj.Show();
            this.Hide();
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            vend2 obj = new vend2();
            obj.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            vend2 obj = new vend2();
            obj.Show();
            this.Hide();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accmanage obj = new accmanage();
            obj.Show();
            this.Hide();
        }

        private void revenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accmanage obj = new accmanage();
            obj.Show();
            this.Hide();
        }

        private void profitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accmanage obj = new accmanage();
            obj.Show();
            this.Hide();
        }

        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noti n = new noti();
            n.Show();
            this.Hide();
        }

        private void notificationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            noti n = new noti();
            n.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report obj = new report();
            obj.Show();
            this.Hide();
        }

        private void inventoryReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report obj = new report();
            obj.Show();
            this.Hide();
        }

        private void customerReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report obj = new report();
            obj.Show();
            this.Hide();
        }

        private void vendorReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report obj = new report();
            obj.Show();
            this.Hide();
        }
    }
}
