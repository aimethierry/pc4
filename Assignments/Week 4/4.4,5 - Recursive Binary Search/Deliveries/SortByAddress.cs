using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries
{
    class SortByAddress:IComparer<Deliverable>
    {
        public int Compare(Deliverable d1, Deliverable d2)
        {
            
            if (d1.Buyer.Street != d2.Buyer.Street)
            {
                return d1.Buyer.Street.CompareTo(d2.Buyer.Street);
            }
            else
            {
                return d1.Buyer.Housenumber.CompareTo(d2.Buyer.Housenumber);
            }
            
        }
    }
}
