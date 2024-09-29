using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_in_C_.OopPrinciples.Encapsulation
{
    class Properties
    {
        //private string name;      // only required when we write the code inside get and set method

        public string Name      // this is a property
        {
            /*
            get { return name; }        // this is get method will be used to return the value
            set { name = value; }       // this will assign the value to field
            */

            // the above code can also be written as:

            // the differnece will be that class field 'name' will not required in this case
            get;
            set;
        }
    }
    class Property
    {
        static void Main(string[] args)
        {
            Properties properties = new Properties();
            properties.Name = "property";
            Console.WriteLine(properties.Name);
        }
    }
}
