using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppAboutBinaryFiles
{
    [Serializable]
    public class BunchOfThings
    {
        private String name;
        private List<Thing> myList;

        public BunchOfThings(String nm)
        {
            name = nm;
            myList = new List<Thing>();
        }

        public void AddThing(String nm, int n, bool iFr)
        {
            Thing th = new Thing(nm, n, iFr);
            myList.Add(th);
        }

        public String GetName()
        {
            return this.name;
        }

        public int GetNumberOfThings()
        {
            return this.myList.Count;
        }

        public List<Thing> GetAllThings()
        {
            return this.myList;
        }
    }
}
