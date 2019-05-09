using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppAboutBinaryFiles
{
    [Serializable]
    public class Thing
    {
        private String name;
        private int numberOfCurls;
        private bool isFruity;

        public Thing(String nm, int n, bool iFr)
        {
            this.name = nm;
            this.numberOfCurls = n;
            this.isFruity = iFr;
        }

        public override String ToString()
        {
            String s = "name is: " + name + " with number: " + numberOfCurls;
            if (isFruity)
                return s + " is fruity.";
            else
                return s + " is not fruity.";
        }
    }
}
