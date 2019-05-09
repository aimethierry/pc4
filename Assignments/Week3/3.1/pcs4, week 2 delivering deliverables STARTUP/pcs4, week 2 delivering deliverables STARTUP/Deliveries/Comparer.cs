using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries
{
    class Comparer : IComparer<Deliverable>
    {
        public int Compare(Deliverable x, Deliverable y)
        {
            int streetres = string.Compare(x.Buyer.Street, y.Buyer.Street);
            int result = 0;
            if (streetres == 0)
            {
                result = y.Buyer.Housenumber - x.Buyer.Housenumber;
            }
            else
            {
                result = streetres;
            }





            return result;
        }
    }
}
