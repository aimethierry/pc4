using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_1
{
    class node
    {
        private String theName; //the item it refers to
        private node next;    // the next node it refers to; null if there does not exist a next node

        public node(String aName)
        {
            this.theName = aName;
            this.next = null;
        }
        
        public String getName() { return this.theName; }

        public node getNext() { return this.next; }
        public void setNext(node n) { this.next = n; }
    }
}
