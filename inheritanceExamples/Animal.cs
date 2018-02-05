using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExamples
{
    abstract class BaseAnimal
    {
        string type = "animal";


        public void setType(string type)
        {
            this.type = type;
        }


        public virtual void getBreed()
        {
            Console.WriteLine("type: "  + type);
        }

    }
}
