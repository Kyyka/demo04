using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Elevator
    {
        private int minfloor = 1;
        private int maxfloor = 5;
        private int floor = 1;

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value >= minfloor && value <= maxfloor)
                {
                    floor = value;
                }
                   

            }
        }
    }
}
