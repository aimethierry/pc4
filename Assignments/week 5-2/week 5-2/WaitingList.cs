using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_2
{
    class WaitingList
    {
        private Node first;
        private Node last;


        public WaitingList()
        {
            this.first = null;
            this.last = null;
        }
        public void AddPatient(Patient i)
        {
            if (this.last != null)
            {
                //there are at least 1 nodes in the linked list
                var temp = new Node(i);
                this.last.setNext(temp);
                this.last = temp;
            }
            else
            {
                //the linked list is empty
                var temp = new Node(i);
                this.last = temp;
                this.first = temp;
            }

        }
        public bool RemoveName(Patient z)
        {
            Patient Patient;
            if (this.first == null)
                //there are no items in the list
            {
                return false;
            }

            if (this.first.getNext() == null)
                //there is exactly 1 item
            {
                Patient = this.first.GetPatient();
                if (Patient == z)
                {
                    first = first.getNext();
                    this.last = null;
                    return true;
                }
            }

            //there are at least 2 items in the linked list
        
            Patient = this.first.GetPatient();
            
            if (Patient == z)
            {
                  
                first = first.getNext();
                return true;
            }
            var i = first;
            while (i.getNext() != null)
            {
                if (i.getNext().GetPatient() == z)
                {
                    i.setNext(i.getNext().getNext());
                    return true;
                }
                i = i.getNext();
            }

            return false;
        }

        public Patient GetPatient(string doctor)
        {
            if (first == null) return null;
            var i = first;
            while (i != null)
            {
                if (first.GetPatient().Doctor == "Any" || i.GetPatient().Doctor == doctor  )
                {
                   
                    return i.GetPatient();
                }
                i = i.getNext();
            }

            return null;
        }
    
    
        public List<Node> GetAllNode()
        {
            List<Node> temp = new List<Node>();
            var i = first;
            if (i == null)
            {
                return null;
            }

            if (i.getNext() == null)
            {
                temp.Add(i);
                return temp;

            }

            temp.Add(i);
           

            while (i.getNext()!=null)
            {
                temp.Add(i.getNext());
                i = i.getNext();
            }
            return temp;

        }

    }
}
