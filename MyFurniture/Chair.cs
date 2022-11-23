using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    internal class Chair:Furniture
    {
        const double chairFactor =1.2;
        int legs;

        public Chair( int legs)
        {
            IdNovel();
            this.legs = legs;
        }
        public override double getPrice()
        {
            return base.getPrice() * chairFactor;
        }
        public override string Print()
        {
            return base.Print() + "a szék lábainak száma: " + this.legs + "db\tÁra: " + getPrice() + "FT";
        }
    }
}
