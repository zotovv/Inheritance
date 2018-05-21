using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines
{
    class Ship : Vehicle
    {
        public Ship(int xLocation, int yLocation, uint price, uint speed, uint year)
        : base(xLocation, yLocation, price, speed, year)
        {

        }

        public Ship(uint price, uint speed, uint year)
        : base(price, speed, year)
        {

        }

        uint passengers;

        public uint Passengers
        {
            get => passengers;
            set => passengers = value;
        }

        string port;

        public string Port
        {
            get
            {
                if (port == null)
                    return "Порт не задан";
                return port;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Значение пустое.");
                }
                else
                {
                    port = value;
                }
            }
        }
    }
}
