using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    abstract class Furniture
    {
        const double basePrice = 25000;
        static uint idcounter = 0;
        protected uint id;
        protected void IdNovel() { id = ++idcounter; }

        public virtual double getPrice() { return basePrice; }

        public uint getId() { return id; }

        public virtual string Print()
        {
            return getId()+".\t";
        }
    }
}
