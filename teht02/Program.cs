using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            amplifier amplifier = new amplifier();
            bool result;
            do
            {
                Console.Write("Give a new volume value (0-100): ");
                string line = Console.ReadLine();
                int number;
                result = int.TryParse(line, out number);
                amplifier.Amp = number;
                Console.WriteLine("Amplifier volume is now se to: " + amplifier.Amp);
            } while (result == true);

        }
    }
}
