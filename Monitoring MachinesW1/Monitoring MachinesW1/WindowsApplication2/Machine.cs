using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace WindowsApplication2
{
    [Serializable]
    public class Machine
    {
        /************datafields*******************************************/
        private String name;
        private int temperature, pressure; //the current working temperature and the current working pressure

        /************delegates and events***********************************/

        //todo
        
        public delegate void CriticalStateHandler(Machine sender, string reason);
        public event CriticalStateHandler CriticalState;

        /************constructor******************************************/
        public Machine(String name, int temperature, int pressure)
        {
            this.name = name;
            this.temperature = temperature;
            this.pressure = pressure;
        }

        /************property's*********************************************/
        public String Name { get { return this.name; } }
        public int Temperature { get { return this.temperature; } }
        public int Pressure { get { return this.pressure; } }

        /************methods*********************************************/
        public void SetTemperature(int newTemperature)
        {
            this.temperature = newTemperature;
            if(this.temperature < 80)
            {
                CriticalState(this, "Temp is too low" + this.temperature);
            }
            else if(this.temperature > 120) { CriticalState(this, "Temp is too high" + this.temperature); }

        }

        public void SetPressure(int newPressure)
        {
            this.pressure = newPressure;
            if (this.pressure < 60)
            {
                CriticalState(this, "Pressure is too low" + this.pressure);
            }
            else if(this.pressure > 80) { CriticalState(this, "Pressure is too low" + this.pressure); }

        }

        public void removeAllCriticalStateHandlers()
        {
            this.CriticalState = null;
        }


        /// <summary>
        /// returns a string with information about the current temperature and current pressure
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            
            return "name: " + this.name +
                "; currrent temp: " + Convert.ToString(this.temperature) +
                "; current press: " + Convert.ToString(this.pressure) + ".";
        }


        
    }
}