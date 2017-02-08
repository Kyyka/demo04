using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new teht04.Bike("Jopo", "Street", 1970, "Green", "");
            Console.WriteLine("Bike info\n" + bike.ToString());

            Boat boat = new teht04.Boat("Suvi", "S900", 1990, "Blue", 3, "Rowboat");
            Console.WriteLine("Boat info\n" + boat.ToString());
        }
    }
}
