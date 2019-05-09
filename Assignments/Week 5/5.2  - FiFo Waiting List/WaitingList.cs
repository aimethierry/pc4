using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2____FiFo_Waiting_List
{
    class WaitingList
    {
        //Fields and Properties
        private string name;
        private Nodes first = null;
        private Nodes last = null;
        private static int count = 0;
        private static int[] precount = new int[3];
        public string Name => name;
        public int Count => count;
        public int[] PrefCount => precount;

        public Nodes Head
        {
            get => first;
            set => first = value;
        }

        public Nodes Tail
        {
            get => last;
            set => last = value;
        }

        //Constructors
        public WaitingList(string name) => this.name = name;

        //Methods
        
        public Nodes FindNodeAt(int i)
        {
            var temp = first;
            int counter = 1;
            if (first == null)
            {
                return null;
            }
            else
            {
                if (i == 1)
                {
                    return first;
                }
                else
                {
                    do
                    {
                        temp = temp.NextNode;
                        counter++;
                    } while (counter != i && temp != null);

                    return temp;
                }
            }
        }
        public Nodes FindNodeBefore(Nodes n)
        {
            var temp = first;
            if (n == first)
            {
                return null;
            }
            else
            {
                while (temp.NextNode != n)
                {
                    temp = temp.NextNode;
                }

                return temp;
            }
        }
        public Nodes FindNextJohn()
        {
            var temp = first;
            while (temp != null)
            {

                if (temp.GetVisitor.Pref == Preference.DrJohn || temp.GetVisitor.Pref == Preference.Nothing)
                {
                    temp = RemoveNode(temp);
                    break;
                }

                temp = temp.NextNode;
            }

            return temp;
        }
        public Nodes FindNextCarla()
        {
            var temp = first;
            while (temp != null)
            {

                if (temp.GetVisitor.Pref == Preference.DrCarla || temp.GetVisitor.Pref == Preference.Nothing)
                {
                    temp = RemoveNode(temp);
                    break;
                }

                temp = temp.NextNode;
            }

            return temp;
        }

        public Nodes RemoveNode(Nodes n)
        {
            var tempPre = FindNodeBefore(n);
            if (first != null)
            {
                
                if (tempPre == null)
                {
                    //Node before first node was requested which means
                    //User want to remove first node in the linked list
                    var temp = RemoveFromFront();
                    if (temp != null)
                    {
                        count--;
                        if (temp.GetVisitor.Pref == Preference.DrJohn)
                        {
                            PrefCount[0]--;
                        }
                        else if (temp.GetVisitor.Pref == Preference.DrCarla)
                        {
                            PrefCount[1]--;
                        }
                        else
                        {
                            PrefCount[2]--;
                        }
                    }
                    return temp;
                }
                else
                {
                    tempPre.SetNext(n.NextNode);
                    n.SetNext(null);
                    count--;
                    if (n.GetVisitor.Pref == Preference.DrJohn)
                    {
                        PrefCount[0]--;
                    }
                    else if (n.GetVisitor.Pref == Preference.DrCarla)
                    {
                        PrefCount[1]--;
                    }
                    else
                    {
                        PrefCount[2]--;
                    }
                    return n;
                }
            }
            else
            {
                return null;
            }
        }
        public Nodes RemoveFromFront()
        {
             
            if (first == null)
            {
                return null;
            }
            else if(first.NextNode==null)
            {
                Nodes temp = first;
                first = null;
                last = null;
                return temp;
            }
            else
            {
                Nodes temp = first;
                first = first.NextNode;
                return temp;
            }
        }


        public void InsertAtEnd(Visitor v)
        {
            var temp = new Nodes(v);
            if (first == null)
            {
                //There is no node in the list
                first = temp;
                last = temp;
            }
            else
            {
                last.SetNext(temp);
                last = temp;
            }

            count++;
            if (v.Pref == Preference.DrJohn)
            {
                PrefCount[0]++;
            }
            else if(v.Pref == Preference.DrCarla)
            {
                PrefCount[1]++;
            }
            else
            {
                PrefCount[2]++;
            }

            
        }
        

    }
}
