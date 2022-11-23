using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Furniture[] furnitures= new Furniture[3];

            furnitures[0] = new Table(170);
            furnitures[1] = new Bed(220, 170);
            furnitures[2] = new Chair(4);

            for (int i = 0; i < furnitures.Length; i++)
            {
                Console.WriteLine(furnitures[i].Print());
            }

            Console.ReadKey();
        }
    }
}
