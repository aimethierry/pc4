using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliveries
{

    public class Deliverable : IComparable<Deliverable>
    {
        private int id;    //the unique id of a deliverable
        private int weight; //the weight (in grams) of this deliverable
        private Person buyer; //the person who bought this deliverable

        public Deliverable(int id, int weight, Person buyer)
        {
            this.id = id;
            this.weight = weight;
            this.buyer = buyer;
        }

        public int ID { get { return this.id; }  set{ this.id = value;  } }
        public int Weight { get { return this.weight; } set { this.weight = value;  } }
        public Person Buyer { get { return this.buyer; }  }


        public override string ToString()
        {
            string res;
            res = "id : " + ID + " weight: " + this.weight + " to be delivered: " + buyer.Name + " - " + buyer.Street +
                " - " + buyer.Housenumber + " - " + buyer.Postalcode + " - " + buyer.City;
            return res;
        }

        public int CompareTo(Deliverable t)
        {
            return this.weight - t.weight;
        }
    }
}
