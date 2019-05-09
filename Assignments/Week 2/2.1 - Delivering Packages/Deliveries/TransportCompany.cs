using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Deliveries
{
    class TransportCompany
    {
        private List<Person> myPersons;
        private List<Deliverable> myDeliverables;
        private List<Deliverable> Normal;

        public TransportCompany()
        {
            this.myPersons = new List<Person>();
            this.myDeliverables = new List<Deliverable>();
            this.Normal = new List<Deliverable>();
        }

        public List<Person> Persons { get { return this.myPersons; } }
        public List<Deliverable> Deliverables { get { return this.myDeliverables; } }


        public Person FindPerson(int id)
        {
            foreach (Person p in this.myPersons)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }
            return null;
        }

        public void AddPerson(Person p)
        {
            if (this.FindPerson(p.ID) == null)
            {
                this.myPersons.Add(p);
            }
            else
            {
                throw new Exception("Person not added, since there is already a person with id " + p.ID.ToString());
            }
        }

        public Deliverable FindDeliverable(int id)
        {
            foreach (Deliverable d in this.myDeliverables)
            {
                if (d.ID == id)
                {
                    return d;
                }
            }
            return null;
        }

        public void AddDeliverable(Deliverable d)
        {
            if (FindDeliverable(d.ID) == null)
            {
                myDeliverables.Add(d);
            }
            else
            {
                throw new Exception("Person not added, since there is already a deliverable with id " + d.ID.ToString());
            }
        }

        public void LoadPersonsFromFile(String filename)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
                this.myPersons.Clear();
                String name, street, postalcode, city;
                int id, housenr;
                name = sr.ReadLine();
                while (name != null)
                {
                    street = sr.ReadLine();
                    housenr = Convert.ToInt32(sr.ReadLine());
                    postalcode = sr.ReadLine();
                    city = sr.ReadLine();
                    id = Convert.ToInt32(sr.ReadLine());
                    this.myPersons.Add(new Person(id, name, street, housenr, postalcode, city));
                    name = sr.ReadLine();
                    name = sr.ReadLine(); //and again read a line, because of the delimiter between persons(line with the stars)
                }
            }
            catch (IOException e)
            {
                throw new Exception("Input/Output exception with message \"" + e.Message + "\" occurred", e);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        public void LoadDeliverablesFromFile(String filename)
        {  //todo
            using (FileStream fs = new FileStream(filename,FileMode.Open,FileAccess.Read))
            {
                using (StreamReader sw = new StreamReader(fs))
                {
                    
                    try
                    {
                        int id, weight, pid;
                        string input;
                        Person temp;
                        myDeliverables.Clear();
                        input = sw.ReadLine();
                        while (input != null)
                        {

                            string sub = input.Substring(0, input.IndexOf(" "));
                            id = Convert.ToInt32(sub);
                            sub = input.Remove(0, (input.IndexOf(" ") + 1));
                            sub = input.Substring(0, (input.IndexOf(" ")));
                            weight = Convert.ToInt32(sub);
                            sub = input.Remove(0, (input.IndexOf(" ") + 1));
                            sub = input.Substring(0, (input.IndexOf(" ")));

                            pid = Convert.ToInt32(sub);
                            temp = FindPerson(pid);
                            if (temp != null)
                            {
                                int diff = 0;
                                int index = 0;
                                if (myDeliverables.Count != 0)
                                {
                                    index = -1;
                                    for (int i = 0; i < myDeliverables.Count; i++)
                                    {
                                        if (myDeliverables[i].Weight > weight)
                                        {
                                            index = i;
                                            break;
                                        }

                                    }


                                    if (index != -1)
                                    {
                                        myDeliverables.Insert(index, new Deliverable(id, weight, temp));
                                    }
                                    else
                                    {
                                        myDeliverables.Add(new Deliverable(id, weight, temp));
                                    }

                                }
                                else
                                {
                                    myDeliverables.Add(new Deliverable(id, weight, temp));
                                }
                               

                            }
                            

                            input = sw.ReadLine();
                        }
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Input/Output exception with message \"" + e.Message + "\" occurred", e);
                    }
                    
                }
            }
        }

        public void LoadNormal()
        {
            this.Normal = this.myDeliverables;
        }

        public Deliverable[] BubbleArraySwap(Deliverable[] tempArray, int a)
        {
            Deliverable temp = tempArray[a];
            tempArray[a] = tempArray[a + 1];
            tempArray[a + 1] = temp;
            return tempArray;

        }

        public Deliverable[] ArraySwap(Deliverable[] tempArray, int a, int b)
        {
            Deliverable temp = tempArray[a];
            tempArray[a] = tempArray[b];
            tempArray[b] = temp;
            return tempArray;
        }

        /// <summary>
        /// SortByWeightOwn sorts the elements of the deliverables-list from a low weight to a high weight.
        /// </summary>

        //Sort the list using my own created sorting Algorithm 
        public void SortByWeightOwn()
        {
            
            Deliverable[] tempArray = myDeliverables.ToArray();
            for (int i = 0; i < tempArray.Length; i++)
            {
                Deliverable a = tempArray[i];
                if (i + 1 != tempArray.Length)
                {
                    Deliverable b = tempArray[i + 1];
                    if (b.Weight < a.Weight)
                    {
                        tempArray = BubbleArraySwap(tempArray, i);
                        i = -1;
                    }
                }
                else
                {
                    break; ;
                }
                
            }

            myDeliverables = tempArray.ToList();
        }


        //Sort the list using Inserstion sorting Algorithm 
        public void SortByWeightInsertion()
        {
            myDeliverables = Normal;
            Deliverable[] tempArray = Normal.ToArray();
            int i,k;
            int N = Normal.Count;
            for (i = 1; i < N; i++)
            {
                for (k = i; k > 0 && tempArray[k].Weight < tempArray[k - 1].Weight; k--)
                {
                    tempArray = ArraySwap(tempArray, k, k - 1);
                }
            }

            myDeliverables = tempArray.ToList();

        }
        /// <summary>
        /// SortByName sorts the elements of the deliverables-list alfabetically by buyer's name.
        /// </summary>
        public void SortByName()
        {
            //todo
            Deliverable[] tempArray = myDeliverables.ToArray();
            for (int i = 0; i < tempArray.Length; i++)
            {
                Deliverable a = tempArray[i];
                if (i + 1 < tempArray.Length)
                {
                    Deliverable b = tempArray[i + 1];
                    int result = String.Compare(a.Buyer.Name, b.Buyer.Name);
                    if (result>0)
                    {
                        tempArray = BubbleArraySwap(tempArray, i);
                        i = -1;
                    }
                }
                else
                {
                    break;
                }
            }

            myDeliverables = tempArray.ToList();
        }

        /// <summary>
        /// SortById sorts the elements of the deliverables-list from a low id to a high id.
        /// </summary>
        public void SortById()
        {

            Deliverable[] tempArray = myDeliverables.ToArray();
            for (int i = 0; i < tempArray.Length; i++)
            {
                Deliverable a = tempArray[i];
                if (i + 1 != tempArray.Length)
                {
                    Deliverable b = tempArray[i + 1];
                    if (b.ID < a.ID)
                    {
                        tempArray = BubbleArraySwap(tempArray, i);
                        i = -1;
                    }
                }
                else
                {
                    break; ;
                }

            }

            myDeliverables = tempArray.ToList();
        }

        /// <summary>
        /// SortByAddress sorts the elements of the deliverables-list "alfabetically by street; then by increasing house-number".
        /// So elements with a different street are sorted alfabetically by street.
        /// Elements with the same street are sorted by increasing house-number. 
        /// </summary>
        public void SortByAddress()
        {
            //todo
            Deliverable[] tempArray = myDeliverables.ToArray();
            for (int i = 0; i < tempArray.Length; i++)
            {
                Deliverable a = tempArray[i];
                if (i + 1 != tempArray.Length)
                {
                    Deliverable b = tempArray[i + 1];
                    int result = String.Compare(a.Buyer.Street, b.Buyer.Street);
                    if (result > 0)
                    {
                        tempArray = BubbleArraySwap(tempArray, i);
                        i = -1;
                    }
                    else if(result==0)
                    {
                        if (a.Buyer.Housenumber > b.Buyer.Housenumber)
                        {
                            tempArray = BubbleArraySwap(tempArray, i);
                            i=-1;
                        }
                    }
                }
                else
                {
                    break; ;
                }

            }

            myDeliverables = tempArray.ToList();

        }

        /// <summary>
        /// SortForPostman sorts the elements of the deliverables-list alfabetically by street,
        /// then by postman-ordered house-numbers.
        /// The postman walks along the street, first the side of the street with the odd numbers (in an increasing order),
        /// then back on the other side of the street for the even house-numbers (in a decreasing order). 
        /// </summary>
        public void SortForPostman()
        {

            //todo
            Deliverable[] tempArray = myDeliverables.ToArray();
            for (int i = 0; i < tempArray.Length; i++)
            {
                Deliverable a = tempArray[i];
                if (i + 1 != tempArray.Length)
                {
                    Deliverable b = tempArray[i + 1];
                    int result = String.Compare(a.Buyer.Street, b.Buyer.Street);
                    //Intially sort by street
                    if (result > 0)
                    {
                        tempArray = BubbleArraySwap(tempArray, i);
                        i = -1;
                    }
                    else if (result == 0)
                    {
                        //First Sort Odd first then Even for same street
                        if ( (a.Buyer.Housenumber%2==0) && (b.Buyer.Housenumber%2!=0) )
                        {
                            tempArray = BubbleArraySwap(tempArray, i);
                            i = -1;
                        }
                        //Second if two house numbers being odd, from small to large
                        else if((a.Buyer.Housenumber % 2 != 0 && b.Buyer.Housenumber % 2 != 0))
                        {
                            if (a.Buyer.Housenumber > b.Buyer.Housenumber)
                            {
                                tempArray = BubbleArraySwap(tempArray, i);
                                i = -1;
                            }
                        //Third if two house numbers being even, from large to small
                        }else if ((a.Buyer.Housenumber % 2 == 0 && b.Buyer.Housenumber % 2 == 0))
                        {
                            if (a.Buyer.Housenumber < b.Buyer.Housenumber)
                            {
                                tempArray = BubbleArraySwap(tempArray, i);
                                i = -1;
                            }
                        }
                        
                    }
                }
                else
                {
                    break; ;
                }

            }

            myDeliverables = tempArray.ToList();

        }
    }
}
