using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(200000, 45, 10) { Passengers = 17, Port = "Севастополь" };
            Console.WriteLine("Цена корабля: {0}, скорость: {1}, год выпуска: {2}, количество пассажиров: {3}, порт приписки: {4}", ship.Price, ship.Speed, ship.Year, ship.Passengers, ship.Port);

            Plane plane = new Plane(800000, 750, 12) { Passengers = 120, High = 8000 };
            Console.WriteLine("Цена самолёта: {0}, скорость: {1}, год выпуска: {2}, количество пассажиров: {3}, высота: {4}", plane.Price, plane.Speed, plane.Year, plane.Passengers, plane.High);


            Console.ReadKey();
        }
    }
}
