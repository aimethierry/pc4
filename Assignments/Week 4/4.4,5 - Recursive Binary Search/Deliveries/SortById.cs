using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries
{
    class SortById : IComparer<Deliverable>
    {
        public int Compare(Deliverable x, Deliverable y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }
}
