using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Radio
    {
        public bool IsOn { get; set; }
        public double Freq { get; set; }
        public int Volume { get; set; }

        public void Power(bool ison)
        {
            IsOn = ison;
        }

        public void SetFreq(double freq)
        {
            if (freq <= 26000 && freq >= 2000)
            {
                Freq = freq;
            }
        }

        public void SetVolume(int volume)
        {
            if (volume >= 1 && volume <= 9)
            {
                Volume = volume;
            }
        }

        public override string ToString()
        {
            return "Power: " + IsOn + "\nVolume: " + Volume + "\nFrequency: " + Freq + "\n";
        }
    }
}
