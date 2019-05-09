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

        #region BinarySearch Section

        private void BtnSearchByName_Click_1(object sender, EventArgs e)
        {
            int Nr =0;
            string SearchKey = TbSearch.Text;
            tc.SortByName();
            ShowInfo();
            Deliverable d = RecursiveBinarySearchByName(tc.Deliverables, 0, tc.Deliverables.Count-1, SearchKey,ref Nr);
            listBox2.Items.Clear();
            if (d != null)
            {
                listBox2.Items.Add(d);
            }
            else
            {
                listBox2.Items.Add($"There is no Deliverable with given Name of {SearchKey}");
            }
            listBox2.Items.Add($"Number of Recursive Calls : {Nr}");
        }
        private void BtnNameAll_Click(object sender, EventArgs e)
        {
            string SearchKey = TbSearch.Text;
            tc.SortByName();
            ShowInfo();
            var tempList = AllDeliverablesOfName(tc.Deliverables, SearchKey);

            listBox2.Items.Clear();
            if (tempList.Count != 0)
            {
                foreach (var d in tempList)
                {
                    listBox2.Items.Add(d);
                }
            }
            else
            {
                listBox2.Items.Add($"There is no Deliverable with given Name of {SearchKey}");
            }

        }
        private void BtnSearchById_Click_1(object sender, EventArgs e)
        {
            int Nr=0;
            int SearchKey = Convert.ToInt32(TbSearch.Text);
            SortById sortId = new SortById();
            tc.Deliverables.Sort(sortId);
            ShowInfo();
            Deliverable d = RecursiveBinarySearchById(tc.Deliverables, 0, tc.Deliverables.Count - 1, SearchKey,ref Nr);

            listBox2.Items.Clear();
            if (d != null)
            {
                listBox2.Items.Add(d);
            }
            else
            {
                listBox2.Items.Add($"There is no Deliverable with given Id of {SearchKey}");
            }
            listBox2.Items.Add($"Number of Recursive Calls : {Nr}");
        }


        private Deliverable RecursiveBinarySearchById(List<Deliverable> list, int min, int max, int searchKey, ref int Nr)
        {
            int mid = (min + max) / 2;
            if (min > max)
            {
                return null;
            }

            Nr++;
            if (list[mid].ID == searchKey)
            {
                return list[mid];
            }
            else if (list[mid].ID > searchKey)
            {
                return RecursiveBinarySearchById(list, min, mid - 1, searchKey,ref Nr);
            }
            else if (list[mid].ID < searchKey)
            {
                return RecursiveBinarySearchById(list, mid + 1, max, searchKey,ref Nr);
            }

            return null;
        }
        private Deliverable RecursiveBinarySearchByName(List<Deliverable> list, int min, int max, string searchKey, ref int Nr)
        {
            int mid = (min + max) / 2;
            if (min > max)
            {
                
                return null;
            }
            ++Nr;
            if (list[mid].Buyer.Name == searchKey)
            {            
                return list[mid];
            }
            else if (list[mid].Buyer.Name.CompareTo(searchKey) > 0)
            {
                return RecursiveBinarySearchByName(list, min, mid - 1, searchKey, ref Nr);
            }
            else if (list[mid].Buyer.Name.CompareTo(searchKey) < 0)
            {
                return RecursiveBinarySearchByName(list, mid + 1, max, searchKey, ref Nr);
            }
            return null;
        }
        private List<Deliverable> AllDeliverablesOfName(List<Deliverable> list, string searchKey)
        {
            int firstIndex = FirstIndexOfDeliverableByName(list, searchKey);
            int lastIndex = LastIndexOfDeliverableByName(list, searchKey);
            int count = (lastIndex - firstIndex) + 1;

            if (firstIndex != -1 && lastIndex != -1)
            {
                var temp = list.GetRange(firstIndex, count);
                return temp;
            }
            else
            {
                return null;
            }
            
        }
        private int FirstIndexOfDeliverableByName(List<Deliverable> list, string searchKey)
        {
            int result = -1;
            int min = 0;
            int max = list.Count - 1;
            

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (list[mid].Buyer.Name == searchKey)
                {
                    result = mid;
                    max = mid - 1;
                }
                else if (list[mid].Buyer.Name.CompareTo(searchKey) > 0)
                {
                    max = mid - 1;
                }
                else if (list[mid].Buyer.Name.CompareTo(searchKey) < 0)
                {
                    min = mid + 1;
                }
            }

            return result;
        }
        private int LastIndexOfDeliverableByName(List<Deliverable> list, string searchKey)
        {
            int result = -1;
            int min = 0;
            int max = list.Count - 1;
            

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (list[mid].Buyer.Name == searchKey)
                {
                    result = mid;
                    min = mid + 1;
                }
                else if (list[mid].Buyer.Name.CompareTo(searchKey) > 0)
                {
                    max = mid - 1;
                }
                else if (list[mid].Buyer.Name.CompareTo(searchKey) < 0)
                {
                    min = mid + 1;
                }
            }

            return result;
        }

        #endregion


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
