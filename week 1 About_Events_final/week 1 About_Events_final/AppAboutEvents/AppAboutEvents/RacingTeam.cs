using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutEvents
{
    public class RacingTeam
    {
        private String name;
        private List<Motorbike> motorbikes;

        public RacingTeam()
        {
            this.name = "Yahama racing team";
            this.motorbikes = new List<Motorbike>();
            this.motorbikes.Add(new Motorbike("Rossi", 250));
            this.motorbikes.Add(new Motorbike("Vinales", 230));
        }

        public Motorbike GetByName(String nm)
        {
            foreach(Motorbike m in this. motorbikes)
            {
                if (m.NameOfDriver == nm) { return m; }
            }
            return null;
        }

    }
}
