using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2____FiFo_Waiting_List
{
    class Nodes
    {
        //Fields and Properties
        private Visitor theVisitor;
        private Nodes nextNode = null;
        

        public Visitor GetVisitor => theVisitor;
        public Nodes NextNode => nextNode;

        //Constructors
        public Nodes(Visitor v) => theVisitor = v;

        //Methods
        public void SetNext(Nodes n) => nextNode = n;
    }
}
