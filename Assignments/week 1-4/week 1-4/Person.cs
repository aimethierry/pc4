using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_1_4
{
    class Person
    {
        private String name;
  

        public Person(String name,Clock c)
        {
            this.name = name;
            c.AlarmEvent8 += new Clock.AlarmHandler(ActivateAlarm);

        }

       public string Info { get { return string.Format(this.name); } }
        public void ActivateAlarm(String s)
        {
          
            MessageBox.Show(this.name+", "+s);
        }
    }
}
