using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_1
{
    class nodeList
    {
        private node first;
        private node last;


        public nodeList()
        {
            this.first = null;
            this.last = null;
        }


        public void AddName(String i)
        {
            if (this.last != null)
            {
                //there are at least 1 nodes in the linked list
                node temp;
                temp = new node(i);
                this.last.setNext(temp);
                this.last = temp;
            }
            else
            {
                //the linked list is empty
                node temp;
                temp = new node(i);
                this.last = temp;
                this.first = temp;
            }

        }

        public bool RemoveName(string name)
        {
            String NameToReturn;
            if (this.first == null)
                //there are no items in the list
            {
                return false;
            }

            if (this.first.getNext() == null)
                //there is exactly 1 item
            {
                NameToReturn = this.first.getName();
                if (NameToReturn == name)
                {
                    first = first.getNext();
                    this.last = null;
                    return true;
                }
            }

            //there are at least 2 items in the linked list
        
                NameToReturn = this.first.getName();
            
                if (NameToReturn == name)
                {
                  
                    first = first.getNext();
                    return true;
                }
                var i = first;
                while (i.getNext() != null)
                {
                    if (i.getNext().getName() == name)
                    {
                        i.setNext(i.getNext().getNext());
                        return true;
                    }
                    i = i.getNext();
                }

                return false;
        }


        public int GetNumberOfNames()
        {
            String NameToReturn;
            if (this.first == null)
                //there are no items in the list
            {
                return 0;
            }

            if (this.first.getNext() == null)
                //there is exactly 1 item
            { 
                    return 1;
            }

            int number = 1;
            var i = first;
            while (i.getNext() != null)
            {
                number++;
                i = i.getNext();
            }

            return number;
        }

        public node GetNodeByIndex(int n)
        {
            var xNode = first;
            for (int i = 0; i <= n; i++)
            {
                if (i == n)
                {
                    return xNode;
                }
                xNode = xNode.getNext();
            }

            return null;
        }

        public List<node> GetAllNode()
        {
            List<node> temp = new List<node>();
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
