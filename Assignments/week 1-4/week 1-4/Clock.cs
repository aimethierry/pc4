using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1_4
{
    class Clock
    {
        public delegate void AlarmHandler(String s);
        public event AlarmHandler AlarmEvent8;

        private int hour , minute, sethr,setmin;

        public int Hour { get { return this.hour; } }
        public int Minute { get { return this.minute; } }
        public int Sethr { get { return this.sethr; } }
        public int Setmin { get { return this.setmin; } }

        public void incrementHour()
        {
            if (Hour < 23)
            {
                hour++;
                if (Hour == Sethr && Minute ==setmin)
                {
                    AlarmEvent8(("Wake Up! It's " +Sethr+":"+Setmin));
                }
            }
            
           else
            {
                this.hour = 0;
                if (Hour == Sethr && Minute == setmin)
                {
                    AlarmEvent8(("Wake Up! It's " + Sethr + ":" + Setmin));
                }
            }
        }

        public void incrementMinute()
        {
            if (this.minute < 59)
            {
                this.minute++;
                if (Hour == Sethr && Minute == setmin)
                {
                    AlarmEvent8(("Wake Up! It's " + Sethr + ":" + Setmin));
                }
            }
            else
            {

                incrementHour();
                this.minute = 0;
            }
        }

        public Clock(int hour, int minute,int hr,int min)
        {
            this.hour = hour;
            this.minute = minute;
            this.sethr = hr;
            this.setmin = min;
        }

    }
}
