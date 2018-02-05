using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExamples
{
    class DerivedDog : BaseAnimal
    {
        string name = "";
        string id = "";
        string type = "";


        public override void getBreed()
        {
            Console.WriteLine("typeB " + type);
        }


        public DerivedDog()
        {

        }

        public DerivedDog(string name)
        {
            this.name = name;
        }

        public DerivedDog(string name, string id)
        {
            this.name = name;
            this.id = id;
        }


        public override string ToString()
        {
            string myString = "this is  a dog";

            return myString;
        }

    }
}
