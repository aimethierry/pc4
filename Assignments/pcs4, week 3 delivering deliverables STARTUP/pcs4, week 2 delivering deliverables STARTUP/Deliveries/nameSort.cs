using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries
{
    class nameSort : IComparer<Deliverable>
    {
        public int Compare(Deliverable x, Deliverable y)
        {

            return string.Compare(x.Buyer.Name, y.Buyer.Name);


        }
    }
}
