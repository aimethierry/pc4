using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveries
{
    public partial class Form1 : Form
    {
        TransportCompany tc = new TransportCompany();
        public Form1()
        {
            InitializeComponent();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            tc.LoadPersonsFromFile("..\\..\\..\\data\\persons.txt");
            tc.LoadDeliverablesFromFile("..\\..\\..\\data\\deliverables.txt");
            

            foreach (Deliverable d in tc.Deliverables)
            {

                listBox1.Items.Add(d.ToString());

            }
            //for checking if persons works
            //foreach (Person p in tc.Persons)
            //{

            //    listBox1.Items.Add(p.ToString());
            //}







        }

        private void btSortByWeight_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            tc.SortByWeight();
            foreach (Deliverable d in tc.Deliverables)
            {
                listBox1.Items.Add(d);
            }
        }

        private void btSortByName_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            tc.SortByName();
            foreach (Deliverable d in tc.Deliverables)
            {
                listBox1.Items.Add(d);
            }
        }

        private void btSortById_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            tc.SortById();
            foreach (Deliverable d in tc.Deliverables)
            {
                listBox1.Items.Add(d);
            }
        }

        private void btSortByAddress_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            tc.SortByAddress();
            foreach (Deliverable d in tc.Deliverables)
            {
                listBox1.Items.Add(d);
            }
        }

        private void btSortForPostman_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            tc.SortForPostman();
            foreach (Deliverable d in tc.Deliverables)
            {
                listBox1.Items.Add(d);
            }
        }
    }
}
