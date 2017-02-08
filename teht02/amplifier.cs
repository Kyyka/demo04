using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class amplifier
    {
        private int minamp = 0;
        private int maxamp = 100;
        private int amp = 0;
        
        public int Amp
        {
            get
            {
                return amp;
            }
            set
            {
                if (value >= minamp && value <= maxamp)
                {
                    amp = value;
                }
                else if (value < 0)
                {
                    amp = minamp;
                    Console.WriteLine("Volume is too low. Set to minimum: 0");
                }
                else if (value > 100)
                {
                    amp = maxamp;
                    Console.WriteLine("Volue is too loud. Set to maximum: 100");
                }
            }
        }
    }
}
