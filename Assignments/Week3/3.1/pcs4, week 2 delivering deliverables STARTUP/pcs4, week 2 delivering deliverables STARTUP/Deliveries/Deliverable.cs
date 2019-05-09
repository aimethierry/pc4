using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliveries
{

    public class Deliverable:IComparable<Deliverable>
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

        public int ID { get { return this.id; } }
        public int Weight { get { return this.weight; } }
        public Person Buyer { get { return this.buyer; } }

        

        public int CompareTo(Deliverable other)
        {
            return this.weight - other.weight;
        }

        public override string ToString()
        {
            string info = string.Format("id:{0} weight:{1} buyer ID:{2} buyer Name:{3} to be delivered at: {4}, {5}, {6}, {7}",id,weight,buyer.ID,buyer.Name,buyer.Street,buyer.Housenumber,buyer.Postalcode,buyer.City); //todo
            
            return info;
        }

    }
}
