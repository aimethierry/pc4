using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveries
{
    public partial class Form1 : Form
    {
        TransportCompany ts;
       
        public Form1()
        {
            InitializeComponent();
            ts = new TransportCompany();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OFDPersons.Filter = "Text Files (*.txt)|*.txt";
            OFDPersons.DefaultExt = "txt";
            OFDPersons.AddExtension = true;
            OFDPersons.Title = "Select Persons List";

            OFDDeliverables.Filter = "Text Files (*.txt)|*.txt";
            OFDDeliverables.DefaultExt = "txt";
            OFDDeliverables.AddExtension = true;
            OFDDeliverables.Title = "Select deliverables List";
            try
            {
                if (OFDPersons.ShowDialog() == DialogResult.OK)
                {
                    ts.LoadPersonsFromFile(OFDPersons.FileName);

                }

                if (OFDDeliverables.ShowDialog() == DialogResult.OK)
                {
                    ts.LoadDeliverablesFromFile(OFDDeliverables.FileName);

                }

                foreach(Deliverable d in ts.Deliverables)
                {
                    listBox1.Items.Add(d.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }

        private void btSortByWeight_Click(object sender, EventArgs e)
        {
            ts.SortByWeight();
            listBox1.Items.Clear();
            foreach (Deliverable d in ts.SortedList)
            {
                listBox1.Items.Add(d.ToString());
            }
        }

        private void btSortByName_Click(object sender, EventArgs e)
        {
            ts.SortByName();
            listBox1.Items.Clear();
            foreach (Deliverable d in ts.SortedList)
            {
                listBox1.Items.Add(d.ToString());
            }

        }

        private void btSortById_Click(object sender, EventArgs e)
        {
            ts.SortById();
            listBox1.Items.Clear();
            foreach (Deliverable d in ts.SortedList)
            {
                listBox1.Items.Add(d.ToString());
            }
        }

        private void btSortByAddress_Click(object sender, EventArgs e)
        {
            ts.SortByAddress();
            listBox1.Items.Clear();
            foreach (Deliverable d in ts.SortedList)
            {
                listBox1.Items.Add(d.ToString());
            }
        }

        private void btSortForPostman_Click(object sender, EventArgs e)
        {
            ts.SortForPostman();
            listBox1.Items.Clear();
            foreach (Deliverable d in ts.SortedList)
            {
                listBox1.Items.Add(d.ToString());
            }
        }

        private void btnsearchbinary_Click(object sender, EventArgs e)
        {
           ts.SortById();
                Deliverable d = ts.BinarySearchById(Convert.ToInt32(tbid.Text), 0, ts.SortedList.Count-1);
                if (d != null)
                {
                    MessageBox.Show(d.ToString());
                }
                else
                {
                    MessageBox.Show("Delivarable not found");
                }
            }

        private void btnnamesearch_Click(object sender, EventArgs e)
        {
            ts.SortByName();
            Deliverable d = ts.BinarySearchByName((tbname.Text), 0, ts.SortedList.Count-1);
            MessageBox.Show(d != null ? d.ToString() : "Delivarable not found");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Deliverable d in ts.FindAllDeliverables(tbname.Text))
            {
                listBox1.Items.Add(d);
            }

            

        }
    }
    }

