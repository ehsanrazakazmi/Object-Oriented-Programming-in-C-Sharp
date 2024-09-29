using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DesignPatterns_in_C_.OopPrinciples.Encapsulation
{
    internal class Car
    {
        public string color = "white";

        private int model = 2023;       // private field is accessible in any method of its own class

        public int Show()
        {
            return this.model;       // which is here...
        }
    }
}
