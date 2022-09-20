using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace final_pro
{
    public partial class Analog : Form
    {
        // baraye ejraa shodane theme 
        bool sq;
        bool cir;
        // zaaviyehaa 
        double alphas;
        double alpham;
        double alphah;
        // zamane vared shode va yaa gerefte shode az system
     static   int minute;
        static int hours;
         static int second;
        //toole aghrabehaa
        static int LS = 50;
        static int LM = 40;
        static int LH = 30;
        // vasate saate analog
        static int x1 = 135;
        static int y1 = 135;

        //makane badi aghrabeha.
        float xs2;
        float ys2;
        float xm2;
        float ym2;
        float xh2;
        float yh2;
        // shomarandeha.
        double  countm = 0.0;
    //    double  counth = 0.0;
        // brush haaye morede niaz baraye noghtehaa va adade bar roye saat
        SolidBrush Dot_Br = new SolidBrush(Color.White);
        SolidBrush Num_br = new SolidBrush(Color.White);
        // Font haaye morede niaz baraye noghtehaa va adade bar roye saat
        Font  Dot_Font = new Font("Verdana", 8);
        Font Num_Font = new Font("Verdana", 7);
        // brush marboot be pas zamine saat
        SolidBrush br1 = new SolidBrush(Color.Black);
        // Pen marboot be aghrabehaa
        Pen SecPen = new Pen(Color.Red, 1);
        Pen MinPen = new Pen(Color.Green, 2);
        Pen HourPen = new Pen(Color.Blue, 1);
        // shoae  daayere va faasele az markaze saat
      static int R = 80;
        // size chand zelye ya daayere
        static Size size = new Size(2*R, 2*R);
  
        Graphics g1;
        // noghte vasat 
        static Point Cpnt = new Point(x1 - R, y1 - R);
        Point pnt1 = new Point(x1, y1);
        Point pnt2 = new Point(x1 + LS, y1);
        Point pnt3 = new Point(x1 + LM, y1 + LM);
        Point pnt4 = new Point(x1, y1 + LH);
        Rectangle rec1 ;

        public Analog()
        {

            InitializeComponent();
        }
        
        private void Form2_Load_1(object sender, EventArgs e)
        {
            // zamaan ra az system migirad va zaaviye har khat raa be dast miavarad
            minute = System.DateTime.Now.Minute;
            alpham = (minute * Math.PI / 30) + 30;

            second = (System.DateTime.Now.Second) +3;
            alphas = (second * Math.PI / 30) + 30;

            hours = System.DateTime.Now.Hour;
            alphah = (hours * Math.PI / 6) + 30;
            
            timer1.Start();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {


          y1 = 135;
           x1=135;

            //set kardan meghdar baray markaz circle & ebteday  aghrabeha.


            //.............set kardan makan badi bary tarsim aghrabeha.


            double xs = x1 + (LS * Math.Cos(alphas));
            double ys = y1 + (LS * Math.Sin(alphas));
            xs2 = float.Parse(xs.ToString());
            ys2 = float.Parse(ys.ToString());


            double xm = x1 + (LM * Math.Cos(alpham));
            double ym = y1 + (LM * Math.Sin(alpham));
            xm2 = float.Parse(xm.ToString());
            ym2 = float.Parse(ym.ToString());

            double xh = x1 + (LH * Math.Cos(alphah));
            double yh = y1 + (LH * Math.Sin(alphah));
            xh2 = float.Parse(xh.ToString());
            yh2 = float.Parse(yh.ToString());
          
            SecPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            MinPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            HourPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
         
            g1 = this.CreateGraphics();
            // chand zelye marboot be paszamine saat
            rec1 = new Rectangle(Cpnt, size);
            g1.FillEllipse(br1, rec1);
           if (sq == true  )
            {
                SolidBrush br2 = new SolidBrush(Color.White);
           //     this.BackgroundImage = final_pro.Properties.Resources.stop_watches_latest_hd_wallpapers_free_download;
               
                g1.FillEllipse(br2, rec1);
                g1.FillRectangle(br1, rec1);
            }
           else   if (cir == true)
             {
                 SolidBrush br2 = new SolidBrush(Color.White);
       //          this.BackgroundImage = final_pro.Properties.Resources.stop_watches_latest_hd_wallpapers_free_download;
              
                 g1.FillRectangle(br2, rec1);
                 g1.FillEllipse(br1, rec1);
             }
          
            g1.DrawLine(HourPen, x1, y1, xh2, yh2);
            g1.DrawLine(MinPen, x1, y1, xm2, ym2);
            g1.DrawLine(SecPen, x1, y1, xs2, ys2);
           
            set();
        }
     /******************************************************************************************************************************/
        private void set()
        {
            y1 = 135;
            x1 = 135;
            //set kardan zavieh avalie.  
            double alphaset = 274.97;
            float xset2, yset2;
      
            float xdset2, ydset2;
            //tarif brush & font 
          
            //tarsim 12 adad bar roy circle.
            for (int i = 1; i <= 60; i++)
            {
                double xdset = x1-4  + ((R - 5) * Math.Cos(alphaset));
                double ydset = y1 -9+ ((R -5) * Math.Sin(alphaset));
                double xset = x1-5 + ((R-16) * Math.Cos(alphaset));
                double yset = y1-7 + ((R-16 )* Math.Sin(alphaset));
                xset2 = float.Parse(xset.ToString());
                yset2 = float.Parse(yset.ToString());
                xdset2 = float.Parse(xdset.ToString());
                ydset2 = float.Parse(ydset.ToString());
                
            g1.DrawString(".", Dot_Font, Dot_Br, xdset2, ydset2);
              if(i%5==0)
                g1.DrawString((i / 5).ToString(), Num_Font, Num_br, xset2, yset2);
                alphaset += Math.PI / 30;



            }
        }
        /*****************************************************************************************************************************/
     int  cntplus=1;
        double alphasPlus=Math.PI/30;
        double alphamPlus=Math.PI/30;
        double alphahPlus = Math.PI / 3600;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
         y1 = 135;
         x1 = 135;
            Pen SecPen2 = new Pen(br1.Color,SecPen.Width);
            SecPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            g1.DrawLine(SecPen2, x1, y1, xs2, ys2);
            countm +=cntplus;
   //         counth+=1;
            alphas +=alphasPlus;
            double xs = x1 + (LS * Math.Cos(alphas));
            double ys = y1 + (LS * Math.Sin(alphas));
            xs2 = float.Parse(xs.ToString());
            ys2 = float.Parse(ys.ToString());       
       //     g1.DrawLine(SecPen, x1, y1, xs2, ys2);
            MinPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            g1.DrawLine(MinPen, x1, y1, xm2, ym2);
            HourPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            g1.DrawLine(HourPen, x1, y1, xh2, yh2);
            SecPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;       
            g1.DrawLine(SecPen, x1, y1, xs2, ys2);
            //delet harche ke tarsim kardim baray dadan meghdar jadid.
       //     g1.Clear(this.BackColor);
            //set kardan meghdar baray aghrabe daghighehshomar.
            if (countm == 60.00)
            {
              
                Pen MinPen2 = new Pen(br1.Color, MinPen.Width);
                MinPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                g1.DrawLine(MinPen2, x1, y1, xm2, ym2);
                alpham +=alphamPlus;
                double xm = x1 + (LM * Math.Cos(alpham));
                double ym = y1 + (LM * Math.Sin(alpham));
                xm2 = float.Parse(xm.ToString());
                ym2 = float.Parse(ym.ToString());

                 Pen HourPen2 = new Pen(br1.Color, HourPen.Width);
                HourPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                g1.DrawLine(HourPen2, x1, y1, xh2, yh2);
                alphah += alphahPlus;
                double xh = x1 + (LH * Math.Cos(alphah));
                double yh = y1 + (LH * Math.Sin(alphah));
                xh2 = float.Parse(xh.ToString());
                yh2 = float.Parse(yh.ToString());
            /*  ************************************************************************************************
                HourPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                g1.DrawLine(HourPen, x1, y1, xh2, yh2);
                SecPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;       
                g1.DrawLine(SecPen, x1, y1, xs2, ys2);
             ********************************************************************************* */
                countm = 0;
               alphas += alphasPlus ;


               MinPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
               g1.DrawLine(MinPen, x1, y1, xm2, ym2);
               HourPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
               g1.DrawLine(HourPen, x1, y1, xh2, yh2);

            }
            // set kardan meghdar baray tarsim aghrabe saat shomar.
            /********************************************************************
           if (counth == 3600.00)
            {
                Pen HourPen2 = new Pen(br1.Color, HourPen.Width);
                HourPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                g1.DrawLine(HourPen2, x1, y1, xh2, yh2);
                alphah += Math.PI / 6;
                double xh = x1 + (LH * Math.Cos(alphah));
                double yh = y1 + (LH * Math.Sin(alphah));
                xh2 = float.Parse(xh.ToString());
                yh2 = float.Parse(yh.ToString());
       //       MinPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
          //      g1.DrawLine(MinPen, x1, y1, xm2, ym2);
            //    HourPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
      //          g1.DrawLine(HourPen, x1, y1, xh2, yh2);
       //         g1.DrawLine(SecPen, x1, y1, xs2, ys2);
              
                counth = 0;
               alphas += (Math.PI / 30) / 10;
             }
       ************************************************************************/
            //tarsim aghrabeha & circle.  
      //     g1.FillEllipse(br1, rec1);
      //      SecPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;       
    //        g1.DrawLine(SecPen, x1, y1, xs2, ys2);
           
           set();

        }

  /********************************************************************************************************************************/   

        private void SecHandColorBt_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            SecPen.Color = colorDialog1.Color;
           
        }

        private void BackColorBt_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            br1.Color = colorDialog1.Color;
            
        }

        private void MinHandColorBt_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            MinPen.Color = colorDialog1.Color;
        }

        private void HourHandColorBt_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            HourPen.Color = colorDialog1.Color;
        }

    

        private void NumberFontBt_Click(object sender, EventArgs e)
        {
    //        fontDialog1.ShowApply = true;
      //     fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowDialog();
            Num_Font = fontDialog1.Font;
           ;
       
        }

        private void DotColorBt_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Dot_Br.Color = colorDialog1.Color;
        }

        private void NumerColorBt_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Num_br.Color = colorDialog1.Color;
        }

        private void DotFontBt_Click(object sender, EventArgs e)
        {

       //    fontDialog1.ShowApply = true;
        //    fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowDialog();
            Dot_Font = fontDialog1.Font;
            

        }


        private void CircleThemeBt_Click_1(object sender, EventArgs e)
        {
            sq = false;
            cir = true;
        }

        private void SquareThemeBt_Click(object sender, EventArgs e)
        {
            sq = true;
            cir = false;
        }
       
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PauseBt_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Console.Beep(2000, 100);
        }

        private void ResumeBt_Click(object sender, EventArgs e)
        {
            
           
            if (HourTB.Text == "")
                hours = DateTime.Now.Hour;
            else if (HourTB.Text != "")
            {
                if(Convert.ToInt32(HourTB.Text)<=12)
                hours = Convert.ToInt32(HourTB.Text);
                else
                    hours = DateTime.Now.Hour;
            }
            alphah = (hours * Math.PI / 6) + 30;
            /****************************/
            if (MinTB.Text == "")
                minute = DateTime.Now.Minute;
            else if (MinTB.Text != "")
            {
                if(Convert.ToInt32(MinTB.Text)<=60)
                minute = Convert.ToInt32(MinTB.Text);
                else
                    minute = DateTime.Now.Minute;
                }
            alpham = (minute * Math.PI / 30) + 30;
            /***************************/
            if (SecondTB.Text == "")
                second = DateTime.Now.Second;
            else if (SecondTB.Text != "")
            {
                if (Convert.ToInt32(SecondTB.Text) <= 60)
                    second = Convert.ToInt32(SecondTB.Text);
                else
                    second = DateTime.Now.Second;
            }
            alphas = (second * Math.PI / 30) + 30;
            timer1.Start();
            Console.Beep(1000, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           second++;
            if (second == 30)
                alphasPlus = -alphasPlus;
        }  
    }
}
