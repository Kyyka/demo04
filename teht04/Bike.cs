using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Bike : Vehicle
    {
        public bool Gearbox { get; set; }
        public string GearModel { get; set; }

        public Bike()
        {

        }

        public Bike(string name, string model, int yearmodel, string color, string gearmodel)
            : base(name, model, yearmodel, color)
        {
            GearModel = gearmodel;
            if (GearModel != "")
            {
                Gearbox = true;
            }
            else
            {
                Gearbox = false;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " -Gearbox: " + Gearbox + " -Gearmodel: " + GearModel;
        }
    }
}
