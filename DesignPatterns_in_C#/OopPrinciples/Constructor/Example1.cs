using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_in_C_.OopPrinciples.Constructor
{
    internal class Example1
    {
        public string modelName;
        public string color;
        public string year;

        public Example1(string naam, string rang, string modelYear)       // this is a constructor
        {
            //model = "2001";
            modelName = naam;
            color = rang;
            year = modelYear;      // we can pass the object initialization value here to initialize the class field

        }

        static void Main(string[] args)
        {
            Example1 example1 = new Example1("Toyota", "White" ,"2016");
            Console.WriteLine($"My car is {example1.modelName}, it is of {example1.color} colour and it is {example1.year} model");
        }
    }
}
