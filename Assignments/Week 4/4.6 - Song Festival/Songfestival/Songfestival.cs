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

        public void CalculateInfo(string countryName, out int scoreCountry, out double averageScoreAllCountries)
        {
            scoreCountry = 0;
            var tempCountry = getContestantByName(countryName);
            if (tempCountry != null)
            {
                scoreCountry = tempCountry.TotalScore();
                
            }

            int TotalScoreOfAllCountries = 0 ;
            foreach (var c in contestants)
            {
                TotalScoreOfAllCountries += c.TotalScore();
            }

            averageScoreAllCountries = TotalScoreOfAllCountries / contestants.Count;
        }
    }
}
