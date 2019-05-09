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
        int new_first_index;
        bool samestreet = false;
        private List<Person> myPersons;
        private List<Deliverable> myDeliverables;

        public TransportCompany()
        {
            this.myPersons = new List<Person>();
            this.myDeliverables = new List<Deliverable>();
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
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
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

                            id = Convert.ToInt32(input.Substring(0, input.IndexOf(" ")));
                            input = input.Remove(0, input.IndexOf(" ") + 1);
                            weight = Convert.ToInt32(input.Substring(0, input.IndexOf(" ")));
                            input = input.Remove(0, input.IndexOf(" ") + 1);
                            pid = Convert.ToInt32(input);
                            temp = FindPerson(pid);
                            if (temp != null)
                            {
                               
                                    myDeliverables.Add(new Deliverable(id, weight, temp));
                            }
                            else
                            {
                                myDeliverables.Insert(-1 ,new Deliverable(00000, 0000, temp));
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



        /// <summary>
        /// SortByWeight sorts the elements of the deliverables-list from a low weight to a high weight.
        /// </summary>
        public void SortByWeight()
        {
            for(int firstindex = 0; firstindex < myDeliverables.Count; firstindex++)
            {
                int indexMinOfRest = GetIndexOfMinimumOfTheRest(firstindex);
                swap(firstindex, indexMinOfRest);
            }

        }

        public Deliverable[] deliverables()
        {
            return myDeliverables.ToArray();
        }

     

        private void swap(int i, int j)
        {
            Deliverable temp = myDeliverables[i];
            myDeliverables[i] = myDeliverables[j];
            myDeliverables[j] = temp;
        }


        

        public int GetIndexOfMinimumOfTheRest(int startingIndex)
        {
            int indexMin = startingIndex;
            for (int i = startingIndex + 1; i < myDeliverables.Count; i++)
            {
                if (myDeliverables[i].Weight < myDeliverables[indexMin].Weight)
                {
                    indexMin = i;
                }
            }
            return indexMin;
        }


        public Deliverable[] GetDeliverables()
        {
            return myDeliverables.ToArray();
        }

        /// <summary>
        /// SortByName sorts the elements of the deliverables-list alfabetically by buyer's name.
        /// </summary>
        public void SortByName()
        {
            for (int firstindex = 0; firstindex < myDeliverables.Count; firstindex++)
            {
                int indexMinOfRest = GetIndexOfMinimumOfTheRestName(firstindex);
                swap(firstindex, indexMinOfRest);
            }

        }

      

        public int GetIndexOfMinimumOfTheRestName(int startingIndex)
        {
            int indexMin = startingIndex;
            for (int i = startingIndex + 1; i < myDeliverables.Count; i++)
            {
                if ( String.Compare(myDeliverables[i].Buyer.Name, myDeliverables[indexMin].Buyer.Name) < 0)
                {
                    indexMin = i;
                }
            }
            return indexMin;
        }

        /// <summary>
        /// SortById sorts the elements of the deliverables-list from a low id to a high id.
        /// </summary>
        public void SortById()
        {
            for (int firstindex = 0; firstindex < myDeliverables.Count; firstindex++)
            {
                int indexMinOfRest = GetIndexOfMinimumOfTheRestId(firstindex);
                swap(firstindex, indexMinOfRest);
            }
        }

        public int GetIndexOfMinimumOfTheRestId(int startingIndex)
        {
            int indexMin = startingIndex;
            for (int i = startingIndex + 1; i < myDeliverables.Count; i++)
            {
                if (myDeliverables[i].ID < myDeliverables[indexMin].ID)
                {
                    indexMin = i;
                }
            }
            return indexMin;
        }

        /// <summary>
        /// SortByAddress sorts the elements of the deliverables-list "alfabetically by street; then by increasing house-number".
        /// So elements with a different street are sorted alfabetically by street.
        /// Elements with the same street are sorted by increasing house-number. 
        /// </summary>
        public void SortByAddress()
        {
            for (int firstindex = 0; firstindex < myDeliverables.Count; firstindex++)
            {
                int indexMinOfRest = GetIndexOfMinimumOfTheRestad(firstindex);
                swap(firstindex, indexMinOfRest);
            }

        }

        public int GetIndexOfMinimumOfTheRestad(int firstindex)
        {
            int indexmin = firstindex;
            if (samestreet == false)
            {
                for (int i = firstindex + 1; i < myDeliverables.Count; i++)
                {

                    if (string.Compare(myDeliverables[i].Buyer.Street, myDeliverables[indexmin].Buyer.Street) < 0)
                    {
                        indexmin = i;
                        
                    }
                    else if (string.Compare(myDeliverables[i].Buyer.Street, myDeliverables[indexmin].Buyer.Street) == 0)
                    {
                        if(myDeliverables[i].Buyer.Housenumber < myDeliverables[indexmin].Buyer.Housenumber)
                        {
                            indexmin = i;
                        }
                    }
                }
            }
            return indexmin;
        }

        /// <summary>
        /// SortForPostman sorts the elements of the deliverables-list alfabetically by street,
        /// then by postman-ordered house-numbers.
        /// The postman walks along the street, first the side of the street with the odd numbers (in an increasing order),
        /// then back on the other side of the street for the even house-numbers (in a decreasing order). 
        /// </summary>
        /// 
        public void sortByHouse()
        {
            for (int firstindex = 0; firstindex < myDeliverables.Count; firstindex++)
            {
                int indexMinOfRest = GetIndexOfMinimumOfTheResthou(firstindex);
                swap(firstindex, indexMinOfRest);
            }
        }

        public int GetIndexOfMinimumOfTheResthou(int firstindex)
        {
            int indexmin = firstindex;
            for(int i = firstindex + 1; i < myDeliverables.Count; i++)
            {
                if(myDeliverables[i].Buyer.Housenumber < myDeliverables[indexmin].Buyer.Housenumber)
                {
                    indexmin = i;
                }
            }

            return indexmin;
        }

        public void SortForPostman()
        {
            for (int firstindex = 0; firstindex < myDeliverables.Count; firstindex++)
            {
                int indexMinOfRest = GetIndexOfMinimumOfTheRestpost(firstindex);
                swap(firstindex, indexMinOfRest);
            }

        }

        public int GetIndexOfMinimumOfTheRestpost(int firstindex)
        {
            int indexmin = firstindex;
            int indexmax = firstindex;
            for (int i= firstindex+1; i < myDeliverables.Count; i++)
            {
                if(string.Compare(myDeliverables[i].Buyer.Street, myDeliverables[indexmin].Buyer.Street) < 0)
                {
                    indexmin = i;
                }

                else if (string.Compare(myDeliverables[i].Buyer.Street, myDeliverables[indexmin].Buyer.Street) == 0)
                {
                    if((myDeliverables[i].Buyer.Housenumber % 2) == 1)
                    {
                        if(myDeliverables[i].Buyer.Housenumber < myDeliverables[indexmin].Buyer.Housenumber)
                        {
                            indexmin = i;
                        }
                    }
                   
                }
            }
            return indexmin;
        }




        public Person[] GetallPerson()
        {
            return myPersons.ToArray();
        }

    }
}
