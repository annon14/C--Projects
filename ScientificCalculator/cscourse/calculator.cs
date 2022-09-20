using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cscourse
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }


        private void button29_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        double x;
        char op;
        private void button45_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            op = '+';
            // or 
        //    op = Convert.ToChar(((Button)sender).Text);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            op = '-';
        }

        private void button43_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            op = '/';
        }

        private void button42_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            op = '*';
        }

        private void button47_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            op = '%';
        }
   
        private void button49_Click(object sender, EventArgs e)
        {
           
  if (op == '+')
            {
                textBox1.Text = Convert.ToString(x + Convert.ToDouble(textBox1.Text));
            }
else if (op == '-')
            {
                textBox1.Text = Convert.ToString(x - Convert.ToDouble(textBox1.Text));
            }
else      if (op == '*')
            {
                textBox1.Text = Convert.ToString(x * Convert.ToDouble(textBox1.Text));
            }
else      if (op == '/')
            {
                textBox1.Text = Convert.ToString(x /  Convert.ToDouble(textBox1.Text));
            }
else      if (op == '%')
            {
                textBox1.Text = Convert.ToString(x % Convert.ToDouble(textBox1.Text));
            }
  else if (op == 'r')
  {
      textBox1.Text = Convert.ToString(x);
  }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
                     textBox1.Text = Convert.ToString(1 / x);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
                textBox1.Text="-";
            else   if (textBox1.Text == "-")
                textBox1.Text = "+";
            x = Convert.ToDouble(textBox1.Text);
       
            textBox1.Text = Convert.ToString(-x);
           
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            x = 0;

        }
        double r;
      
        private void button26_Click(object sender, EventArgs e)
        {
               x = Convert.ToDouble(textBox1.Text);
               r = x % 10;
            textBox1.Text = Convert.ToString((x-r)/10);
            }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }
        int n;
        private void button22_Click(object sender, EventArgs e)
        {

            int a = 1;
                if (textBox1.Text== "0")
                    textBox1.Text = "1";

                for (n = Convert.ToInt32(Convert.ToDouble(textBox1.Text)); n > 0; n--)
                {
                    a *= n;
                }
                textBox1.Text = Convert.ToString(a);
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "ln(";


        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            x = Math.Sqrt(x);
           op = 'r';
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

      
    }
}
