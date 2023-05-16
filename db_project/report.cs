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
        public report()
        {
            InitializeComponent();
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

        private void button10_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }
    }
}
