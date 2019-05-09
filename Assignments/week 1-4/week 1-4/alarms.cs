using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1_4
{
    class alarms
    {
        private string alarmname;
        private List<Person> MyAlarms;
        
       public alarms(String name)
        {
            this.alarmname = name;
            MyAlarms = new List<Person>();
        }

        public void AddAlarm(Person p)
        {
            MyAlarms.Add(p);
        }

        public List<Person> GetAllAlarms()
        {
            return MyAlarms;
        }

       

    }
}
