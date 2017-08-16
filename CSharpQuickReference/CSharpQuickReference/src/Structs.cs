using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpQuickReference.src
{
    // struct is lightweight alternative to a class

        // new instances of the class are placed on the heap , 
        // new instances of the struct are placed on the stack

    // we're not working with references like with class but working directly with the struct instance
        // that means when we pass struct to function it's passed by value not by refrence

    // we use structs when we want to represent more simple data structures - and especially if we  know that we will be instatiating lots of them
    // Point, Rectangle, Color structs are only few Microsoft have in store for us
    class Structs
    {
        public static structEntity  newStruct = new structEntity("red");
        public structEntity newstr2 = new structEntity("blue");
        public CustomClass1 neo = new CustomClass1();
        public string majento;
        public static void getDefStructor()
        {
            // can use static fields in static method
           // newstr2.Describe(); // object reference is required for non static method , field or property
            Console.WriteLine(newStruct.Describe()); 
        }
    }
    // interfaces can be applied to struct
    struct structEntity
    {
        // we cant initialize fields on the beginnign
        // no inheritance from class or structs
        private string color;

        public structEntity(string color)
        {
            this.color = color;
            this.Color = color;
        }

        public string Describe()
        {
            return " textstring ";
        }

        public string Color
        {
            get;
            set;
        }
    }
}
