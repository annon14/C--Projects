using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_pro
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            
        }

        private void button40_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }
        double r;
        double x;
        char op;
        private void buttonbackspace_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            r = x % 10;
            textBox1.Text = Convert.ToString((x - r) / 10);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            x = 0;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "-";
            else if (textBox1.Text == "-")
                textBox1.Text = "+";
            x = Convert.ToDouble(textBox1.Text);

            textBox1.Text = Convert.ToString(-x);

        }

        private void button46_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            x = Math.Sqrt(x);
            op = 'r';
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

        private void button43_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            op = '/';
        }

        private void button48_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(1 / x);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            op = '-';
        }

        private void button45_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            op = '+';
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
  else if (op == 'a')
  {
      if (textBox1.Text != "")
          y = Convert.ToDouble(textBox1.Text);
      y = 1.0 / y;
      ans = Math.Pow(x, y);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'b')
  {
      if (textBox1.Text != "")
          y = Convert.ToDouble(textBox1.Text);
          ans = Math.Pow(x, y);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'c')
  {
   
      y = 1.0 / 3;
      ans = Math.Pow(x, y);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'd')
  {      
      ans = Math.Pow(x, 3);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'e')
  {
      ans = Math.Pow(x, 2);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'f')
  {
      ans = Math.Pow(10, x);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'g')
  {
      ans = Math.Log(x);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'h')
  {
      ans = Math.Log10(x);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'i')
  {
      ans = Math.Exp(x);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'j')
  {
      ans = Math.Sin(x);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'k')
  {
      ans = Math.Cos(x);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'l')
  {
      ans = Math.Tan(x);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'm')
  {
      ans = Math.Sinh(x);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'n')
  {
      ans = Math.Cosh(x);
      textBox1.Text = Convert.ToString(ans);
  }
  else if (op == 'o')
  {
      ans = Math.Tanh(x);
      textBox1.Text = Convert.ToString(ans);
  }
        }
        int n;
        private void button22_Click(object sender, EventArgs e)
        {

            int a = 1;
            if (textBox1.Text == "0")
                textBox1.Text = "1";

            for (n = Convert.ToInt32(Convert.ToDouble(textBox1.Text)); n > 0; n--)
            {
                a *= n;
            }
            textBox1.Text = Convert.ToString(a);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }
        double y;
        double ans;
        private void button23_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
             
            op = 'a';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";

            op = 'b';
        }

        private void button24_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";

            op = 'c';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
           op = 'd';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            op = 'e';
        }

        private void button25_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            op = 'f';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);

            op = 'g';
        }

        private void button20_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);

            op = 'h';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            op = 'i';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            op = 'j';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            op = 'k';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            op = 'l';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            op = 'm';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            op = 'n';
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            x = Convert.ToDouble(textBox1.Text);
            op = 'o';
        }

        private void ClBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
