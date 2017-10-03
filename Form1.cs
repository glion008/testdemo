using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChuongTrinhXamXamXiDu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCong_Click(object sender, EventArgs e)
        {
            double x = double.Parse(a.Text);
            double y = double.Parse(b.Text);
            double kq = x + y;
        }
    }
}
