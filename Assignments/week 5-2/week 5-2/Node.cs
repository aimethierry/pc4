using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_2
{
    class Node
    {
        private Patient patient; //the item it refers to
        private Node next;    // the next node it refers to; null if there does not exist a next node

        public Node(Patient a)
        {
            this.patient = a;
            this.next = null;
        }
        
        public Patient GetPatient() { return this.patient; }

        public Node getNext() { return this.next; }
        public void setNext(Node n) { this.next = n; }
    }
}
