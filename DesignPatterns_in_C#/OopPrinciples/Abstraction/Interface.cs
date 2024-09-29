using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_in_C_.OopPrinciples.Abstraction
{
    // Interface
    interface IAnimal
    {
        //public int v = 9;       // now this interface cannot have properties/fields
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Rooster : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("kukroo karooo");
        }
    }
    internal class Interface
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
        }
    }
}
