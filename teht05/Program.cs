using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new teht05.Radio();
            radio.Power(true);
            radio.SetFreq(5000.6);
            radio.SetFreq(1999);
            radio.SetFreq(26666);
            radio.SetVolume(6);
            radio.SetVolume(11);
            radio.SetVolume(-2);
            Console.WriteLine(radio.ToString());
        }
    }
}
