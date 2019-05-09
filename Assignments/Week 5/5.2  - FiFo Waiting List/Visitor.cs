using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2____FiFo_Waiting_List
{
    class Visitor
    {
        //Fields and Properties
        private string name; 
        private string reason; 
        private Preference pref;

        public string Name => name;
        public string Reason => reason;
        public Preference Pref => pref;

        //Constructor
        public Visitor(string name,string reason, Preference p)
        {
            this.name = name;
            this.reason = reason;
            this.pref = p;
        }

        //Methods
        public override string ToString()
        {
            return $"{Name} - {Reason} - {Pref}";
        }
        
    }
}
