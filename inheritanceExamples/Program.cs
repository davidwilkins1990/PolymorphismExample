using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExamples
{
    class Program
    {
        static void Main(string[] args)
        {


            //three types of polymorphism*

            //-parametric polymorphism
            //same method names accepting different parameters (arguments)


            //-overloading p...
            //using override 


            //- inclusion p...
            //-using virutal methods. aka runtime p... or late binding
            //virtual is declarded in base clase, and then child classes can override 
            //using the *override* keyword
            //allows you to call a base class method, and run the child class method
            //

            //children can only override parents if the parents is declared virtual or abstract
            //child uses override keyword to explicitly declared. a second *grandchild, also
            //inherits virtual methods, until one is declared "sealed override", which stops the chain

            // child can be cast to parent to use parents methods
            //

            //parametric p..., poly... using same method with different parameters (or arguments)
            DerivedDog dog = new DerivedDog();
            DerivedDog dog1 = new DerivedDog("name");
            DerivedDog dog2 = new DerivedDog("new name", "new id");

            Cat cat = new Cat();


            DerivedLabrador lab = new DerivedLabrador();

            //overriding methods , using virtual and override keyword
            dog.getBreed();
            lab.getBreed();
           
            Console.WriteLine(dog.ToString());
            Console.WriteLine(lab.ToString());
            
            //overloading - unrelated classes have same method names, but do different things
            lab.example();
            cat.example();

            Console.ReadLine();
        }
    }
}
