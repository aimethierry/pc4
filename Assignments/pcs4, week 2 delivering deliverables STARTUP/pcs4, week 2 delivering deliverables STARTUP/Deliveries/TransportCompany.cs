using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Deliveries
{
    class TransportCompany
    {
        private List<Person> myPersons;
        private List<Deliverable> myDeliverables;
        private List<Deliverable> sortedlist, sortedlist1,sortedlist2;
        private List<Deliverable> oddsortedlist, evensortedlist;


        public TransportCompany()
        {
            this.myPersons = new List<Person>();
            this.myDeliverables = new List<Deliverable>();
        }

        public List<Person> Persons { get { return this.myPersons; } }
        public List<Deliverable> Deliverables { get { return this.myDeliverables; } }
        public List<Deliverable> SortedList { get { return this.sortedlist; } }

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
                throw new Exception("deliverable not added, since there is already a deliverable with id " + d.ID.ToString());
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

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
                this.myDeliverables.Clear();
                int id, weight, personID;
                String deliverable;
                deliverable = sr.ReadLine();
                while (deliverable != null)
                {


                    string[] tokens = deliverable.Split(' ');
                    id = Convert.ToInt32(tokens[0]);
                    weight = Convert.ToInt32(tokens[1]);
                    personID = Convert.ToInt32(tokens[2]);

                    myDeliverables.Add(new Deliverable(id, weight, FindPerson(personID)));

                    deliverable = sr.ReadLine();

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



        /// <summary>
        /// SortByWeight sorts the elements of the deliverables-list from a low weight to a high weight.
        /// </summary>
        public void SortByWeight()
        {
            sortedlist = Deliverables;

            int x, j;

            int N = sortedlist.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (x = 0; x < j; x++)
                {
                    if (sortedlist[x].Weight > sortedlist[x + 1].Weight
                       )
                        swapdeliverable(x, x + 1);
                }
            }


        }

        /// <summary>
        /// SortByName sorts the elements of the deliverables-list alfabetically by buyer's name.
        /// </summary>
        public void SortByName()
        {
            sortedlist = Deliverables;

            int x, j;

            int N = sortedlist.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (x = 0; x < j; x++)
                {
                    if (string.Compare((sortedlist[x].Buyer.Name), (sortedlist[x + 1].Buyer.Name)) > 0)
                    {

                        swapdeliverable(x, x + 1);
                    }
                }
            }

        }

        /// <summary>
        /// SortById sorts the elements of the deliverables-list from a low id to a high id.
        /// </summary>
        public void SortById()
        {
            sortedlist = Deliverables;

            int x, j;

            int N = sortedlist.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (x = 0; x < j; x++)
                {
                    if (sortedlist[x].ID > sortedlist[x + 1].ID
                       )
                        swapdeliverable(x, x + 1);
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
            sortedlist = Deliverables;
            
            int x, j;

            int N = sortedlist.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (x = 0; x < j; x++)
                {
                    if (string.Compare((sortedlist[x].Buyer.Street), (sortedlist[x + 1].Buyer.Street)) == 0)
                    {
                        if (sortedlist[x].Buyer.Housenumber > sortedlist[x + 1].Buyer.Housenumber)

                        {
                            swapdeliverable(x, x + 1);
                        }
                    }
                    else if (string.Compare((sortedlist[x].Buyer.Street), (sortedlist[x + 1].Buyer.Street)) > 0)
                    {
                        swapdeliverable(x, x + 1);
                    }
                }
            }

        }

        /// <summary>
        /// SortForPostman sorts the elements of the deliverables-list alfabetically by street,
        /// then by postman-ordered house-numbers.
        /// The postman walks along the street, first the side of the street with the odd numbers (in an increasing order),
        /// then back on the other side of the street for the even house-numbers (in a decreasing order). 
        /// </summary>
        public void SortForPostman()
        {

            sortedlist = Deliverables.ToList();
            sortedlist1 = Deliverables.ToList();



            int N = sortedlist.Count;


            foreach (Deliverable s in sortedlist.ToList())
            {
                if (s.Buyer.Housenumber % 2 == 0)
                {
                    sortedlist.Remove(s);
                   
                }
            }
             oddsortedlist= sortedlist;

            
      
            foreach (Deliverable s in sortedlist1.ToList())
            {
                if (s.Buyer.Housenumber % 2 != 0)
                {
                    sortedlist1.Remove(s);
                    
                }
            }

            evensortedlist = sortedlist1;

            int f, d;

            N = oddsortedlist.Count;

            for (d = N - 1; d > 0; d--)
            {
                for (f = 0; f < d; f++)
                {
                    if (string.Compare((oddsortedlist[f].Buyer.Street), (oddsortedlist[f + 1].Buyer.Street)) == 0)
                    {
                        if (oddsortedlist[f].Buyer.Housenumber > oddsortedlist[f + 1].Buyer.Housenumber)

                        {
                            swapodd(f, f + 1);
                        }
                    }
                    else if (string.Compare((oddsortedlist[f].Buyer.Street), (oddsortedlist[f + 1].Buyer.Street)) > 0)
                    {
                             swapodd(f, f + 1);
                    }
                }
            }                                           

            int q, w;
            N = evensortedlist.Count;

            for (w = N - 1; w > 0; w--)
            {
                for (q = 0; q < w; q++)
                {
                    if (string.Compare((evensortedlist[q].Buyer.Street), (evensortedlist[q + 1].Buyer.Street)) == 0)
                    {
                        if (evensortedlist[q].Buyer.Housenumber < evensortedlist[q + 1].Buyer.Housenumber)

                        {
                            swapeven(q, q + 1);
                        }
                    }
                    else if (string.Compare((evensortedlist[q].Buyer.Street), (evensortedlist[q + 1].Buyer.Street)) > 0)
                    {
                        swapeven(q, q + 1);
                    }
                }
            }
             sortedlist = oddsortedlist.ToList();
            sortedlist.AddRange(evensortedlist.ToList());


            int x, j;

            N = sortedlist.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (x = 0; x < j; x++)
                {
                  if (string.Compare((sortedlist[x].Buyer.Street), (sortedlist[x + 1].Buyer.Street)) > 0)
                    {
                        swapdeliverable(x, x + 1);
                    }
                }
            }


        }

        public void swapdeliverable(int m, int n)
        {
            Deliverable temporary;

            temporary = sortedlist[m];
            sortedlist[m] = sortedlist[n];
            sortedlist[n] = temporary;
        }

        public void swapodd(int m, int n)
        {
            Deliverable temporary;

            temporary = oddsortedlist[m];
            oddsortedlist[m] = oddsortedlist[n];
            oddsortedlist[n] = temporary;
        }
        public void swapeven(int m, int n)
        {
            Deliverable temporary;

            temporary = evensortedlist[m];
            evensortedlist[m] = evensortedlist[n];
            evensortedlist[n] = temporary;
        }

    }
}
