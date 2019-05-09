using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Helper : IComparer<Drumble>
    {
        public int Compare(Drumble firstdrumble, Drumble seconddrumble)
        {
            //if (firstdrumble.NrOfCredits<seconddrumble.NrOfCredits)
            //{ return -44; }
            //else
            //{ if (firstdrumble.NrOfCredits == seconddrumble.NrOfCredits)
            //    { return 0; }
            //    else { return 66; }
            //    }
            //}

            //descending sorting
            return -1 * (firstdrumble.NrOfCredits - seconddrumble.NrOfCredits);
        }
    }
    }

