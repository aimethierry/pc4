using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_5_1
{
    public partial class Form1 : Form
    {
        private nodeList myList;
        public Form1()
        {
            InitializeComponent();
            myList= new nodeList();
            myList.AddName("subhi");
        }

        private void button5_Click(object sender, EventArgs e)
        {listBox1.Items.Clear();
            foreach (var v in myList.GetAllNode())
            {
                if (v != null)
                {
                    listBox1.Items.Add(v.getName());
                }
            }
        }

        private void btnADd_Click(object sender, EventArgs e)
        {
            myList.AddName(textBox1.Text);
            button5.PerformClick();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            myList.RemoveName(textBox1.Text);
            button5.PerformClick();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            node temp = myList.GetNodeByIndex(Convert.ToInt32(textBox1.Text));
            textBox1.Text = temp.getName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = myList.GetNumberOfNames().ToString();
        }
    }
}
