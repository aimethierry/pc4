using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_2
{
    class Patient
    {
        private string name, reasonForVisit, doctor;

        public Patient(string name, string reason, string doctor)
        {
            this.name = name;
            this.doctor = doctor;
            this.reasonForVisit = reason;
        }

        public string Name => name;
        public string Reason => reasonForVisit;
        public string Doctor => doctor;

        public override string ToString()
        {
            return string.Format("Name: " + Name + "; Reason: " + reasonForVisit + "; Doctor: " + doctor);
        }
    }

}
