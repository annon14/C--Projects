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
    public partial class Note : Form
    {
        public Note()
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


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }
        string filename = "";
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


        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveToolStripMenuItem_Click(null, null);
            this.Hide();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        string textStr;
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textStr = richTextBox1.SelectedText;
          
            
        }

        private void chtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textStr = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
       //     openFileDialog1.ShowDialog();
       //     System.IO.File.Delete(openFileDialog1.FileName);//    hazfe yek file 
       //     System.IO.File.Copy(openFileDialog1.FileName, "d:\\" + openFileDialog1.SafeFileName);
            richTextBox1.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now.Date;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
            
        }

        private void bachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += textStr;
        }
    }
}