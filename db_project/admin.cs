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
    public partial class admin : Form
    {
        private bool isCollapsed;
        public admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            login obj = new login();
            obj.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if(isCollapsed)
            {
                paneldrop.Height += 10;
                if(paneldrop.Size==paneldrop.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                paneldrop.Height -= 10;
                if (paneldrop.Size == paneldrop.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
