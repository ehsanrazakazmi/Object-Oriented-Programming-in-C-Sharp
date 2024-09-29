using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns_in_C_.OopPrinciples.Encapsulation;

namespace DesignPatterns_in_C_
{
    internal class CarObj
    {
        static void Main(string[] args)
        {
            Car carobj = new();

            int year = carobj.Show();

            Console.WriteLine(year);

        }
    }
}
