using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    internal class Table:Furniture
    {
        const double tableFactor = 0.3;
        int h;


        public Table(int h)
        {
            IdNovel();
            this.h = h;
        }
        public override double getPrice()
        {
            return base.getPrice()*tableFactor;
        }
        public override string Print()
        {
            return base.Print()+ "az asztal magassága: "+this.h+"cm\tÁra: "+getPrice() + "FT";
        }



    }
}
