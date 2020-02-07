using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TuuTahYwayPayPah
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(35,Color.Black);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(3);
        }
    }
}
