using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Boat : Vehicle
    {
        public int Seats { get; set; }
        public string Boattype { get; set; }

        public Boat()
        {

        }

        public Boat(string name, string model, int yearmodel, string color, int seats, string boattype)
            : base(name, model, yearmodel, color)
        {
            Seats = seats;
            Boattype = boattype;
        }

        public override string ToString()
        {
            return base.ToString() + " -Seats: " + Seats + " -Boat type: " + Boattype;
        }
    }
}
