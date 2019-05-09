using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songfestival
{
    class Contestant
    {
        private String countryName;
        private List<int> numbers;

        public String CountryName { get { return this.countryName; } }

        public Contestant (String countryName)
        {
            this.countryName = countryName;
            this.numbers = new List<int>();
        }

        public void AddNumber(int number)
        {
            this.numbers.Add(number);
        }

        public int TotalScore()
        {
            int total = 0;
            foreach (var n in numbers)
            {
                total += n;
            }

            return total;
        }
    }
}
