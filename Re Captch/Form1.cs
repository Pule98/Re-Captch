using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Re_Captch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void classRoom1_Click(object sender, EventArgs e)
        {
            classRoom1.Image = null;
            classRoom1.BackColor = Color.Black;
        }

        private void classRoom2_Click(object sender, EventArgs e)
        {
            classRoom2.Image = null;
            classRoom2.BackColor = Color.Black;
        }

        private void classRoom3_Click(object sender, EventArgs e)
        {
            classRoom3.Image = null;
            classRoom3.BackColor = Color.Black;
        }

        private void classRoom4_Click(object sender, EventArgs e)
        {
            classRoom4.Image = null;
            classRoom4.BackColor = Color.Black;
        }

        private void classRoom5_Click(object sender, EventArgs e)
        {
            classRoom5.Image = null;
            classRoom5.BackColor = Color.Black;
        }

        private void classRoom6_Click(object sender, EventArgs e)
        {
            classRoom6.Image = null;
            classRoom6.BackColor = Color.Black;
        }

        private void classRoom7_Click(object sender, EventArgs e)
        {
            classRoom7.Image = null;
            classRoom7.BackColor = Color.Black;
        }

        private void classRoom8_Click(object sender, EventArgs e)
        {
            classRoom8.Image = null;
            classRoom8.BackColor = Color.Black;
        }

        private void classRoom9_Click(object sender, EventArgs e)
        {
            classRoom9.Image = null;
            classRoom9.BackColor = Color.Black;
        }

        private void confrimbtn_Click(object sender, EventArgs e)
        {
            if(classRoom4.Image == null && classRoom5.Image == null && classRoom6.Image == null && classRoom7.Image == null && classRoom8.Image == null && classRoom9.Image == null && classRoom1.Image != null && classRoom2.Image != null && classRoom3.Image != null)
            {
                MessageBox.Show("Access Granted");
            }
            else
            {
                MessageBox.Show("Access Denied");
            }
            Application.Exit();
        }
    }
}
