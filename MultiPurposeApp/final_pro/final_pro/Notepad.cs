using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace note_pad
{
    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();
        }
     
     
        bool saved = true; 
         private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saved == true)
            {
                richTextBox1.Text = "";
                saved = true;
            }
            else
            {
                DialogResult dr;
                dr = MessageBox.Show("Do you want to save", "warning", MessageBoxButtons.YesNoCancel);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                    richTextBox1.Text = "";
                    saved = true;
                }
                else if (dr == System.Windows.Forms.DialogResult.No)
                {
                    richTextBox1.Text = "";
                    saved = true;
                }


            }
    //        richTextBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
                saved = false;

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == true)
            {
                openFileDialog1.Title = "choose your file,please.";
                openFileDialog1.Filter = "text Documents(*.txt)|*.txt|all Files(*.*)|*.*";
                openFileDialog1.ShowDialog();
                richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                filename = openFileDialog1.FileName; 
                saved = true;
            }
            else
            {
                DialogResult dr;
                dr = MessageBox.Show("Do you want to save", "warning", MessageBoxButtons.YesNoCancel);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                    openFileDialog1.Title = "choose your file,please.";
                    openFileDialog1.Filter = "text Documents(*.txt)|*.txt|all Files(*.*)|*.*";
                    openFileDialog1.ShowDialog();
                    richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                    filename = openFileDialog1.FileName; 
                    saved = true;
                }
                else if (dr == System.Windows.Forms.DialogResult.No)
                {

                    openFileDialog1.Title = "choose your file,please.";
                    openFileDialog1.Filter = "text Documents(*.txt)|*.txt|all Files(*.*)|*.*";
                    openFileDialog1.ShowDialog();
                    richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                    filename = openFileDialog1.FileName; 
                    saved = true;
                }
            }
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "text Documents(*.txt)|*.txt|all Files(*.*)|*.*";
            saveFileDialog1.ShowDialog();
            System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            filename = saveFileDialog1.FileName;
            saved = true; 
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(null, null);
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Show();
         
        }

        private void statusBarToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
    
        }
    //    bool x;
        private void frmNotepad_Load(object sender, EventArgs e)
        {
           
      //      System.IO.File.CreateText("d:\\note.txt");
          
    //       System.IO.File.Copy("d:\\note.txt", "e:\\note_2.txt");
            //or
            //( @"d:\note.txt") dagigan haman neveshte estefade mishavad.
  //    using System.IO;     choon namespace hastand,
  //   mitavan az neveshtan aan dar ebtedaye barname be onvan ketabkhane estefade kard.        
// taa niyazi be farakhani dobare nabashad.
   //         System.IO.File.Delete(@"d:\note");
      //      System.Diagnostics.Process.Start("d:\\note"); //baraye ejraaye yek file 
        /*   x= System.IO.File.Exists("d:\\note.txt");
           if (x == true)
               MessageBox.Show(" Exists!");
         else 
                  MessageBox.Show("Not Exists!"); */
           //   System.IO.Directory     dastresi be addres file 
                
  //          System.IO.File.Move(@"e:\note2.txt", "d:\note_2.txt");
        
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
       //     openFileDialog1.ShowDialog();
      //      System.IO.File.Delete(openFileDialog1.FileName);    hazfe yek file 
       //     System.IO.File.Copy(openFileDialog1.FileName, "d:\\" + openFileDialog1.SafeFileName);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        string filename="" ;
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                saveFileDialog1.Filter = "text Documents(*.txt)|*.txt|all Files(*.*)|*.*";
                saveFileDialog1.ShowDialog();
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                filename = saveFileDialog1.FileName;
            }
            else
            {
                System.IO.File.WriteAllText(filename, richTextBox1.Text);
            }
            saved = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void chtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.Date.ToString();
            }
    }
}
