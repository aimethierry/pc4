using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;  //because we are using files

namespace AppAboutTextfiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
           colorDialog1.ShowDialog();
            
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
          if(  openFileDialog1.ShowDialog() == DialogResult.OK )
            {
               this.textBox1.Text =  this.openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("you chose for CANCEL");
            }
        }

        private void btSaveToFile_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("../../myTest.txt", FileMode.OpenOrCreate, FileAccess.Write);
                //try for FileMode : Open, Create, Truncate, Append
                sw = new StreamWriter(fs);
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
               
            }
            catch (IOException)
            {
                listBox1.Items.Add("something went wrong, IOException was thrown");
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }

            listBox1.Items.Add("*************saving is done*********************");
        }

        private void btLoadFromFile_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream("../../myTest.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                String s;
                s = sr.ReadLine();
                while (s != null)
                {
                    listBox1.Items.Add(s);
                    s = sr.ReadLine();
                }
            }
            catch (IOException)
            {
                listBox1.Items.Add("something went wrong, IOException was thrown");
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
            listBox1.Items.Add("*************loading is done*********************");
        }


    }
}
