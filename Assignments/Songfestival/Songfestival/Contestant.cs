using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songfestival
{
    class Contestant
    {
        public String CountryName { get; }
        public List<int> Numbers { get; }

        public Contestant (String countryName)
        {
            this.CountryName = countryName;
            this.Numbers = new List<int>();
        }

        public void AddNumber(int number)
        {
            this.Numbers.Add(number);
        }

        public int getAllScores()
        {
            return Numbers.Sum();
        }
    }
}
