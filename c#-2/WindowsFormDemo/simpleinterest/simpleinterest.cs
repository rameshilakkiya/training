using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleinterest
{
    public partial class simpleinterest : Form
    {
        public simpleinterest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(principle.Text);
            double r = Convert.ToDouble(roi.Text);
            int t = Convert.ToInt32(time.Text);
            double si = (p * r * t) / 100;
            silbl.Text = si.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
