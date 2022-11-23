using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    internal class Bed:Furniture
    {
        const double bedFactor = 2.4;
        int l,w;

        public Bed( int l, int w)
        {
            IdNovel();
            this.l = l;
            this.w = w;
        }
        public override double getPrice()
        {
            return base.getPrice() * bedFactor;
        }
        public override string Print()
        {
            return base.Print() + "az ágy hossza: " + this.l +"cm\taz ágy szélessége: "+this.w+ "cm\tÁra: " + getPrice() + "FT";
        }
    }
}
