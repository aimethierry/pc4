using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songfestival
{
    class Songfestival
    {
        private List<Contestant> contestants;

        public Songfestival()
        {
            contestants = new List<Contestant>();
        }

        public void AddContestant(String countryname)
        {
            this.contestants.Add(new Contestant(countryname));
        }

        private Contestant getContestantByName(String countryName)
        {
            foreach (Contestant c in contestants)
            {
                if (c.CountryName == countryName)
                    return c;
            }
            return null;
        }

        public void AddScore(String country, int number)
        {
            Contestant c = getContestantByName(country);
            if (c != null)
                c.AddNumber(number);
        }

        public void CalculateInfo(string countryname, out int score,out int avgscore)
        {
            
            
            Contestant c = getContestantByName(countryname);
            if (c != null)
            {avgscore = 0;
                score = c.getAllScores();
                foreach (Contestant r in contestants)
                {
                    avgscore += r.getAllScores();
                }

                avgscore /= (contestants.Count);
            }
            
            else {score = 0; avgscore = 0;}
        }
    }
}
