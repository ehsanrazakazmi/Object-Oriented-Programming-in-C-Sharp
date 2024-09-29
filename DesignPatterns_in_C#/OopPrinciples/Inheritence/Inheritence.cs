using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_in_C_.OopPrinciples.Inheritence
{
    // if you dont want to let other classes inherit from this class then use sealed with parent class
    class Vehicle       // parent class
    {
        public string brand = "Toyota";     // property of class 'Vehicle'

        public void honk()
        {
            Console.WriteLine("teet teet");
        }
    }

    class Car : Vehicle
    {
        public string modelName = "Corolla";
    }

    class Gaddi
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.honk();

            Console.WriteLine($"{car.modelName} is of {car.brand} company");
        }
    }
}
