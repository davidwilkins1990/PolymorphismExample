using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExamples
{
    class DerivedLabrador : DerivedDog
    {
        string type = "lab";

        public override void getBreed()
        {
            Console.WriteLine("typeC: " + type);

        }

        public void example()
        {
            Console.WriteLine(  "labrador example ");
        }

        //overloading 

        public override string ToString()
        {
            string myString = "this is a labrador";

            return myString;
        }

    }
}
