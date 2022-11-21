using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nam = name.Text;
            String ema=email.Text;
            long mob=Convert.ToInt64(mobile.Text);
            String se;
            if (female.Checked == true)
            {
                se=female.Text;
            }
            else
            {
                se=male.Text;
            }
            String d = dateTimePicker1.Text;
            String l=comboBox1.Text;
           
            result.Text="Name: "+nam+" "+ "Email: "+ema+" "+ "Mobile: "+mob+" "+ "Sex: "+se+" "+ "DOB: "+d +" "+"Location: " +l;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
