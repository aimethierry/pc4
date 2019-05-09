using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveries
{
    public partial class Form1 : Form
    {
        TransportCompany tc;
        private Stopwatch watch;
        private List<Deliverable> list1, list2;
        public Form1()
        {
            InitializeComponent();
            tc = new TransportCompany();
        }

        private void ShowInfo()
        {
            listBox1.Items.Clear();
            foreach (var d in tc.Deliverables)
            {
                listBox1.Items.Add(d.ToString());
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd;
            try
            {
                using (ofd = new OpenFileDialog())
                {
                    ofd.Title = "Select your person file.";
                    ofd.Filter = "Text Files (*.txt)|*.txt";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string path = ofd.FileName;
                        tc.LoadPersonsFromFile(path);
                    }
                }

                using (ofd = new OpenFileDialog())
                {
                    ofd.Title = "Select your deliverables file.";
                    ofd.Filter = "Text Files (*.txt)|*.txt";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string path = ofd.FileName;
                        tc.LoadDeliverablesFromFile(path);
                        tc.LoadNormal();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            ShowInfo();

            MessageBox.Show("Import Is done!");

        }

        private void btSortByWeight_Click(object sender, EventArgs e)
        {
            watch = new Stopwatch();
            double timeelapsed1,timeelapsed2;

            watch.Reset();
            watch.Start();
            tc.SortByWeightLINQ();
            watch.Stop();
            timeelapsed1 = watch.ElapsedMilliseconds / 1000.0;
            listBox1.Items.Clear();
            foreach (var d in tc.Deliverables)
            {
                listBox1.Items.Add(d.ToString());
            }
            listBox1.Items.Add($"Own Sorting :{timeelapsed1:F10}");
            /*
            watch.Reset();
            watch.Start();
            tc.SortByWeightInsertion();
            watch.Stop();
            timeelapsed2 = watch.ElapsedMilliseconds / 1000.0;

            listBox1.Items.Clear();
            foreach (var d in tc.Deliverables)
            {
                listBox1.Items.Add(d.ToString());
            }

            listBox1.Items.Add($"Own Sorting :{timeelapsed1:F10}");
            listBox1.Items.Add($"Insertion Sorting :{timeelapsed2:F10}");
            */
        }

        private void btSortByName_Click(object sender, EventArgs e)
        {
            tc.SortByName();
            ShowInfo();
        }

        private void btSortById_Click(object sender, EventArgs e)
        {
            tc.SortById();
            ShowInfo();
        }

        private void btSortByAddress_Click(object sender, EventArgs e)
        {
            tc.SortByAddressLINQ();
            tc.Deliverables.ForEach(x=>listBox2.Items.Add(x));
            tc.SortByAddressOwn();
            ShowInfo();
        }

        private void btSortForPostman_Click(object sender, EventArgs e)
        {
            tc.SortByPostmanComparison();
            tc.Deliverables.ForEach(x=>listBox2.Items.Add(x));
            tc.SortForPostmanOwn();
            ShowInfo();
        }


        ///Merge Sorting by comparing first elements of both list and add the least
        /// to the merged list and remove that from it coming list.
        private void button2_Click(object sender, EventArgs e)
        {
            List<Deliverable> list3 = new List<Deliverable>();
            int a1, a2;

            void NumberOfElements()
            {
                a1 = list1.Count;
                a2 = list2.Count;
            }
            NumberOfElements();


            while (a1!=0 && a2!=0 )
            {
               if (list1[0].Buyer.Street.CompareTo(list2[0].Buyer.Street)==0)
                {
                    if (list1[0].Buyer.Housenumber <= list2[0].Buyer.Housenumber)
                    {
                        list3.Add(list1[0]);
                        list1.RemoveAt(0);
                    }
                    else
                    {
                        list3.Add(list2[0]);
                        list2.RemoveAt(0);
                    }
                    
                }else if (list1[0].Buyer.Street.CompareTo(list2[0].Buyer.Street) > 0)
                {
                    list3.Add(list2[0]);
                    list2.RemoveAt(0);
                }
                else
                {
                    list3.Add(list1[0]);
                    list1.RemoveAt(0);
                }
                NumberOfElements();
            }

            if (a1 == 0)
            {
                foreach (var a in list2)
                {
                    Deliverable temp =null;
                    for(int k = 0; k < list3.Count; k++) { 
                        if (a.Buyer.Street.CompareTo(list3[k].Buyer.Street) == 0)
                        {
                            if (a.Buyer.Housenumber <= list3[k].Buyer.Housenumber)
                            {
                                temp = list3[k];
                                break;
                            }
                            
                        }else if(a.Buyer.Street.CompareTo(list3[k].Buyer.Street) < 0)
                        {
                            temp = list3[k];
                            break;
                        }
                    }

                    if (temp != null)
                    {
                        list3.Insert(list3.IndexOf(temp), a);
                    }
                    else
                    {
                        list3.Add(a);
                    }
                    
                    

                }
                list2.Clear();
            }else if (a2 == 0)
            {
                foreach (var a in list1)
                {
                    Deliverable temp = null;
                    for (int k = 0; k < list3.Count; k++)
                    {
                        if (a.Buyer.Street.CompareTo(list3[k].Buyer.Street) == 0)
                        {
                            if (a.Buyer.Housenumber <= list3[k].Buyer.Housenumber)
                            {
                                temp = list3[k];
                                break;
                            }
                            else
                            {
                                temp = list3[k];
                                break;
                            }

                        }
                        else if (a.Buyer.Street.CompareTo(list3[k].Buyer.Street) < 0)
                        {
                            temp = list3[k];
                            break;
                        }
                    }

                    if (temp != null)
                    {
                        list3.Insert(list3.IndexOf(temp), a);
                    }
                    else
                    {
                        list3.Add(a);
                    }



                }
                list1.Clear();
            }



            listBox1.Items.Clear();
            listBox2.Items.Clear();

            tc.SortByAddressOwn();
            foreach (var v in tc.Deliverables)
            {
                listBox1.Items.Add(v);
            }

            //listBox2.Items.Add($"{list1.Count}");
            //listBox2.Items.Add($"{list2.Count}");
            foreach (var v in list3)
            {
                listBox2.Items.Add(v);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
           List<Deliverable> temp = new List<Deliverable>();
           tc.SortByAddressOwn();
           temp.AddRange(tc.Deliverables);
           list1 = new List<Deliverable>();
           list2 = new List<Deliverable>();

           Random rand = new Random();
           int a = rand.Next(0, 15);
           int b = rand.Next(1, 15 - a);
           var OneSplit = temp.GetRange(a, b);
           list1.AddRange(OneSplit);

            foreach (var d in OneSplit)
            {
                temp.Remove(d);
            }
            list2.AddRange(temp);
            
            
            ShowSplitMembers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list1 = new List<Deliverable>();
            list2 = new List<Deliverable>();
            tc.SortByAddressOwn();
            list1.AddRange(tc.Deliverables.GetRange(0,7));
            
            list2.AddRange(tc.Deliverables.GetRange(7,8));
            
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            ShowSplitMembers();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd;
            try
            {
                
                   string path = "../../../data/persons.txt";
                   tc.LoadPersonsFromFile(path);
                   path = "../../../data/deliverables.txt";
                   tc.LoadDeliverablesFromFile(path);
                   tc.LoadNormal();
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            ShowInfo();

            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            List<Deliverable> list3 = new List<Deliverable>();
            int a1, a2;

            void NumberOfElements()
            {
                a1 = list1.Count;
                a2 = list2.Count;
            }
            NumberOfElements();
            int i1 = 0;
            int i2 = 0;
            while (i1 !=a1 || i2!= a2)
            {
                if (list1[i1].Buyer.Street.CompareTo(list2[i2].Buyer.Street) == 0)
                {
                    if (list1[i1].Buyer.Housenumber <= list2[i2].Buyer.Housenumber)
                    {
                        list3.Add(list1[i1]);
                        i1++;
                    }
                    else
                    {
                        list3.Add(list2[i2]);
                        i2++;
                    }
                }else if (list1[i1].Buyer.Street.CompareTo(list2[i2].Buyer.Street) < 0)
                {
                    list3.Add(list2[i2]);
                    i2++;
                }
                else
                {
                    list3.Add(list1[i1]);
                    i1++;
                }

                if (i1 == a1)
                {
                    i1--;
                }else if (i2 == a2)
                {
                    i2--;
                }
            }




            listBox1.Items.Clear();
            listBox2.Items.Clear();

            tc.SortByAddressOwn();
            foreach (var v in tc.Deliverables)
            {
                listBox1.Items.Add(v);
            }

            //listBox2.Items.Add($"{list1.Count}");
            //listBox2.Items.Add($"{list2.Count}");
            foreach (var v in list3)
            {
                listBox2.Items.Add(v);
            }
        }

        private void ShowSplitMembers()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            listBox1.Items.Add($"Number of elements in List 1: {list1.Count}");
            foreach (var v in list1)
            {
                listBox1.Items.Add(v);
            }

            listBox2.Items.Add($"Number of elements in List 2: {list2.Count}");
            foreach (var v in list2)
            {
                listBox2.Items.Add(v);
            }
            {

            }
        }
    }
}
