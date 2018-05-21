using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines
{
    class Plane : Vehicle
    {
        public Plane(int xLocation, int yLocation, uint price, uint speed, uint year)
        : base(xLocation, yLocation, price, speed, year)
        {

        }

        public Plane(uint price, uint speed, uint year)
        : base(price, speed, year)
        {

        }

        public uint High { get; set; }

        uint passengers;

        public uint Passengers
        {
            get => passengers;
            set => passengers = value;
        }
    }
}
