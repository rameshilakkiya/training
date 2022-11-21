using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eComm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res = 0;
            double result = 0;
            float d = 0;
            float disch = 0;
            int amt=Convert.ToInt32(pamt.Text);
            if (y.Checked == true)
            {
                disch = d + 5;
            }
            else
                disch = d;
            
            if (amt <= 10000)
            {
                d = 10;
                /*if (y.Checked == true) { 
                d = 10+5;
                }
                else
                {
                    d = 10;
                }*/
                
            }
            else if(amt>10000 && amt<= 20000)
            {
                d = 20;
                /*if (y.Checked == true)
                {
                    d = 20 + 5;
                }
                else
                {
                    d = 20;
                }*/
               

            }
            else if(amt>20000 && amt <= 30000)
            {
                d = 30;
                /*if (y.Checked == true)
                {
                    d = 30 + 5;
                }
                else
                {
                    d = 30;
                }*/
               
            }
            else
            {
                d = 35;
                /*if (y.Checked == true)
                {
                    d = 35 + 5;
                }
                else
                {
                    d = 35;
                }*/
                
            }
            result = (amt * (d+disch)) / 100;
            //result = amt-((amt * (d + disch)) / 100);
            res = amt - result;
            puramt.Text = "Purchase Amount: "+amt.ToString();
            dis.Text="Discount: "+result.ToString();
            neamt.Text = "Net Amount: "+res.ToString();
        }
    }
}
