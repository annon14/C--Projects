using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace final_pro
{
    public partial class Smart : Form
    {
        public Smart()
        {
            InitializeComponent();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
        }
        int dsec=0;
        int sec = 0;
        int min = 0;
        int hour = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            dsec++;
            if (dsec == 10)
            {
                sec++;
                dsec = 0;
                if (sec == 60)
                {
                    min++;
                    sec = 0;
                    if (min == 60)
                    {
                        hour++;
                        min = 0;
                    }
                }
            }
            mSlb.Text = dsec.ToString();
            Slb.Text = sec.ToString();
            Mlb.Text = min.ToString();
            Hlb.Text = hour.ToString();
        }
        
      
        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep(3000, 100);
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            timer2.Stop();
            Console.Beep(1000, 300);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            SecLb.Text = DateTime.Now.Second.ToString();
            MinLb.Text = DateTime.Now.Minute.ToString();
            HourLb.Text = DateTime.Now.Hour.ToString();
            DayOfWeekLb.Text = DateTime.Now.DayOfWeek.ToString();
            DayLb.Text = DateTime.Now.Day.ToString();
            MonthLb.Text = DateTime.Now.Month.ToString();
            YearLb.Text = DateTime.Now.Year.ToString();
        
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void StartButton_Click_1(object sender, EventArgs e)
        {
            Console.Beep(2000, 100);
            timer1.Start();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {     
            timer1.Stop();
            Console.Beep(1000, 100);
        }

        private void LapBtn_Click(object sender, EventArgs e)
        {
            Console.Beep(1500, 200);
            richTextBox1.Text +=" Lap : " +Hlb.Text + " : " + Mlb.Text + " : " + Slb.Text + " : " + mSlb.Text + "\n";
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            dsec = 0;
            sec = 0;
            min = 0;
            hour = 0;
            mSlb.Text = dsec.ToString();
            Slb.Text = sec.ToString();
            Mlb.Text = min.ToString();
            Hlb.Text = hour.ToString();
            timer1.Stop();
            richTextBox1.Text = "";
            Console.Beep(500, 100);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void StrBtn_Click(object sender, EventArgs e)
        {
            Analog1.Text = "Analog";
            Analog1.Show();
           
            
            
        }
         private void StpBtn_Click(object sender, EventArgs e)
        {
            Analog1.Hide();
          
        }

         private void PlayerBtn_Click(object sender, EventArgs e)
         {
             Console.Beep(2000, 200);
             DialogResult Dr;
             Dr=MessageBox.Show( " Do you want to play default file ? "," Play file : ", MessageBoxButtons.YesNoCancel);
             if (Dr == System.Windows.Forms.DialogResult.No)
             {
                 openFileDialog1.Title = " Choose your file : ";
                 openFileDialog1.Filter = "mp3 files(*.mp3)|*.mp3|mp4 files(*.mp4)| *.mp4 |all Files(*.*)|*.*";
                 openFileDialog1.ShowDialog();
                       Console.Beep(3000, 100);

                       axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
           
             }
             if (Dr == System.Windows.Forms.DialogResult.Yes)
             {
                 Console.Beep(3000, 100);
                 MessageBox.Show("Click play to play file");
                axWindowsMediaPlayer1.URL = "01. Che Zibaa Bood.mp3";
            //     axWindowsMediaPlayer1.URL = "  ThemeFromRomeoandJuliet(ATimeForUs).mp3";
                
             }
             axWindowsMediaPlayer1.Ctlcontrols.play();
             axWindowsMediaPlayer1.Ctlcontrols.pause();
             axWindowsMediaPlayer1.Ctlcontrols.next();
             axWindowsMediaPlayer1.Ctlcontrols.previous();
             axWindowsMediaPlayer1.Ctlcontrols.stop();
             axWindowsMediaPlayer1.Ctlcontrols.fastForward();
          
             axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
           
             MessageBox.Show(axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString);
         }

         private void label10_Click(object sender, EventArgs e)
         {

         }
         Note no = new Note();
         private void button1_Click_1(object sender, EventArgs e)
         {
             no.Show();
         }

         private void button2_Click_1(object sender, EventArgs e)
         {
             Calculator cal = new Calculator();
             cal.Show();
         }

         private void YearTB_TextChanged(object sender, EventArgs e)
         {
            
         }

         private void MonthTB_TextChanged(object sender, EventArgs e)
         {
         
         }

         private void DayTB_TextChanged(object sender, EventArgs e)
         {
       

         }

         private void textBox3_TextChanged(object sender, EventArgs e)
         {
         
         }

         private void MinTB_TextChanged(object sender, EventArgs e)
         {
             
         }

         private void SecondTB_TextChanged(object sender, EventArgs e)
         {
          
         }

         private void tabPage1_Paint(object sender, PaintEventArgs e)
         {
           
         }

         private void SetTimeBt_Click(object sender, EventArgs e)
         {

             if (YearTB.Text != "")
             {
                 if (Convert.ToDouble(YearTB.Text) <= 2400)
                     YL.Text = YearTB.Text;
                 else
                     YL.Text = DateTime.Now.Year.ToString();
             }
             else if (YearTB.Text == "")
                 YL.Text = DateTime.Now.Year.ToString();
             if (MonthTB.Text != "")
             {
                 if (Convert.ToDouble(MonthTB.Text) <= 12)
                     ML.Text = MonthTB.Text;
                 else
                     ML.Text = DateTime.Now.Month.ToString();
             }
             else if (MonthTB.Text == "")
                 ML.Text = DateTime.Now.Month.ToString();
             if (DayTB.Text != "")
             {
                 if (Convert.ToDouble(DayTB.Text) <= 31)
                     DL.Text = DayTB.Text;
                 else
                     DL.Text = DateTime.Now.Day.ToString();
             }
             else if (DayTB.Text == "")
                 DL.Text = DateTime.Now.Day.ToString();
             if (textBox3.Text != "")
             {
                 if (Convert.ToDouble(textBox3.Text) <= 12){
                     h=Convert.ToInt32(textBox3.Text);
                     HL.Text = h.ToString();
                 }
                 else{
                     h = DateTime.Now.Hour;
                     HL.Text = h.ToString();
                 }
             }
             else if (textBox3.Text == "")
             {
                 h = DateTime.Now.Hour;
                 HL.Text = h.ToString();
             }
             if (MinTB.Text != "")
             {
                 if (Convert.ToDouble(MinTB.Text) <= 60)
                 {
                     m=Convert.ToInt32(MinTB.Text);
                     MiL.Text = MinTB.Text;
                 }
                 else {
                     m =DateTime.Now.Minute;
                     MiL.Text =m.ToString();
                 }
             }
             else if (MinTB.Text == ""){
                    m =DateTime.Now.Minute;
                     MiL.Text =m.ToString();
             }

             if (SecondTB.Text != "")
             {
                 if (Convert.ToDouble(SecondTB.Text) <= 60)
                 {
                     s = Convert.ToInt32(SecondTB.Text);
                     SL.Text = s.ToString();
                 }

                 else
                 {
                     s = DateTime.Now.Second;
                     SL.Text = s.ToString();
                 }

             }
             else if (SecondTB.Text == "")
             {
                 s = DateTime.Now.Second;
                 SL.Text = s.ToString();
             }
             
             timer3.Start();
             Console.Beep(1500, 200);
             }
        int s;
        int m;
        int h;
         private void timer3_Tick(object sender, EventArgs e)
         {
             s++;
                if (s == 60)
                {
                    m++;
                    s = 0;
                    if (m == 60)
                    {
                        h++;
                        m = 0;
                    }
                }
                SL.Text = s.ToString();
                MiL.Text = m.ToString();
                HL.Text = h.ToString();
            }
         

         Analog Analog1 = new Analog();
         private void AnalogClockBt_Click(object sender, EventArgs e)
         {
             Analog1.Text = "Analog";
             Analog1.Show();
         }
         }
}
