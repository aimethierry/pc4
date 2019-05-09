using System;
using System.Collections.Generic;
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
       //public List<int> weightlist;

        public TransportCompany()
        {
            this.myPersons = new List<Person>();
            this.myDeliverables = new List<Deliverable>();
        }



        public void SortByWeight()
        {
            this.myDeliverables.Sort();
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


            FileStream fs = null;
            StreamReader sr = null;
           
            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);



                string s = sr.ReadLine();
                while(s != null)
                {
                    string[] arr = s.Split(' ');
                    int id = Convert.ToInt32(arr[0]);

                    int weight = Convert.ToInt32(arr[1]);
                    int personid = Convert.ToInt32(arr[2]);
                    //foreach(Person p in myPersons)
                    //{
                    //    if(p.ID == personid)
                    //    {

                    //    }
                    //}
                   
                    //this.myDeliverables.Add(new Deliverable(id, weight, this.FindPerson(personid)));
                    this.AddDeliverable(new Deliverable(id, weight, this.FindPerson(personid)));



                    s = sr.ReadLine();
                }



            }
            
            catch(IOException)
            {
                MessageBox.Show("IO exception was thrown");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(fs != null)
                {
                    sr.Close();
                    fs.Close();
                }
            }
           
        }



        /// <summary>
        /// SortByWeight sorts the elements of the deliverables-list from a low weight to a high weight.
        /// </summary>
      

        /// <summary>
        /// SortByName sorts the elements of the deliverables-list alfabetically by buyer's name.
        /// </summary>
        public void SortByName()
        {
            //todo
            for (int i = 0; i < Deliverables.Count; i++)
            {
                int indexmin = i;

                for (int j = 0; j < Deliverables.Count - 1; j++)
                {


                    //if ((Deliverables[indexmin]).Buyer.Name < (Deliverables[j]).Buyer.Name)
                    //{
                    //    Deliverable temp = Deliverables[j];
                    //    Deliverables[j] = Deliverables[indexmin];
                    //    Deliverables[indexmin] = temp;

                    //}

                    int result = string.Compare((Deliverables[indexmin]).Buyer.Name, (Deliverables[j]).Buyer.Name);
                    if(result < 0)
                    {
                        Deliverable temp = Deliverables[j];
                        Deliverables[j] = Deliverables[indexmin];
                        Deliverables[indexmin] = temp;
                    }


                    {

            }
                }


            }



        }

        /// <summary>
        /// SortById sorts the elements of the deliverables-list from a low id to a high id.
        /// </summary>
        public void SortById()
        {
            //todo
            for (int i = 0; i < Deliverables.Count; i++)
            {
                int indexmin = i;

                for (int j = 0; j < Deliverables.Count - 1; j++)
                {
                    if ((Deliverables[indexmin]).ID < (Deliverables[j]).ID)
                    {
                        Deliverable temp = Deliverables[j];
                        Deliverables[j] = Deliverables[indexmin];
                        Deliverables[indexmin] = temp;

                    }


                }


            }



        }

        /// <summary>
        /// SortByAddress sorts the elements of the deliverables-list "alfabetically by street; then by increasing house-number".
        /// So elements with a different street are sorted alfabetically by street.
        /// Elements with the same street are sorted by increasing house-number. 
        /// </summary>
        public void SortByAddress()
        {
            //todo

            this.myDeliverables.Sort(new Comparer());



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


            //use insertion sort for this one
            for (int i = 0; i < Deliverables.Count; i++)
            {
                int indexmin = i;

                for (int j = 0; j < Deliverables.Count - 1; j++)
                {



                    int result = string.Compare((Deliverables[indexmin]).Buyer.Street, (Deliverables[j]).Buyer.Street);
                    if (result < 0)
                    {
                        Deliverable temp = Deliverables[j];
                        Deliverables[j] = Deliverables[indexmin];
                        Deliverables[indexmin] = temp;
                    }
                    else if (result == 0)
                    {
                        //if it's odd

                        int remaindermin = (Deliverables[indexmin]).Buyer.Housenumber % 2;
                        int remainderj = (Deliverables[j]).Buyer.Housenumber % 2;

                        if(remaindermin == 0 && remainderj ==0)
                          {
                            if ((Deliverables[indexmin]).Buyer.Housenumber < (Deliverables[j]).Buyer.Housenumber)
                            {
                                Deliverable temp = Deliverables[j];
                                Deliverables[j] = Deliverables[indexmin];
                                Deliverables[indexmin] = temp;

                            }

                        }
                        else if((remaindermin ==0 && remainderj == 1))
                        {
                            Deliverable temp = Deliverables[j];
                            Deliverables[j] = Deliverables[indexmin];
                            Deliverables[indexmin] = temp;


                        }
                        else if(remaindermin == 1 && remainderj == 0)
                        {

                        }
                        else if (remaindermin == 1 && remainderj == 0)
                        {

                        }
                        //if both are odd
                        // if ((((Deliverables[indexmin]).Buyer.Housenumber < (Deliverables[j]).Buyer.Housenumber)) && remainder1 == 1 && remainder2 == 1)
                        // {
                        //     Deliverable temp = Deliverables[j];
                        //     Deliverables[j] = Deliverables[indexmin];
                        //     Deliverables[indexmin] = temp;

                        // }
                        // //if first one is odd
                        // else if ((((Deliverables[indexmin]).Buyer.Housenumber < (Deliverables[j]).Buyer.Housenumber)) && remainder1 == 1 && remainder2 == 0)
                        // {


                        // }
                        // else if ((((Deliverables[indexmin]).Buyer.Housenumber > (Deliverables[j]).Buyer.Housenumber)) && remainder1 == 1 && remainder2 == 0)
                        // {

                        // }




                        // //if the second one is odd
                        //else if ((((Deliverables[indexmin]).Buyer.Housenumber < (Deliverables[j]).Buyer.Housenumber)) && remainder1 == 0 && remainder2 == 1)
                        // {

                        //     Deliverable temp = Deliverables[j];
                        //     Deliverables[j] = Deliverables[indexmin];
                        //     Deliverables[indexmin] = temp;


                        // }
                        // else if ((((Deliverables[indexmin]).Buyer.Housenumber > (Deliverables[j]).Buyer.Housenumber)) && remainder1 == 0 && remainder2 == 1)
                        // {
                        //     Deliverable temp = Deliverables[j];
                        //     Deliverables[j] = Deliverables[indexmin];
                        //     Deliverables[indexmin] = temp;
                        // }


                        // //if both are even
                        // else if ((((Deliverables[indexmin]).Buyer.Housenumber > (Deliverables[j]).Buyer.Housenumber)) && remainder1 == 0 && remainder2 == 0)
                        // {


                        //     Deliverable temp = Deliverables[j];
                        //     Deliverables[j] = Deliverables[indexmin];
                        //     Deliverables[indexmin] = temp;
                        // }


                    }



                }
            }
        }

    }
}
