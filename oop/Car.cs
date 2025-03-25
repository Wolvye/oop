using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

        public Car(string brand, string model, int year)
        {
            Brand = brand; // Das Erste ist die Property der Klasse(wird großgeschrieben) und das zweite ist der Übergabeparameter, der vom Konstruktor kommt(deshalb auch kleingeschrieben)
            Model = model;
            Year = year;
        }

        public void Honk()
        {
            Console.WriteLine("HOOOONK!");
        }
    }
}
