using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpQuickReference {
    class CustomClass1 {
        /*
         public - the member can be reached from anywhere
            Enums and interfaces are - by default - publicly visible

         protected - members can obly be reached from within the same class, 
            or from a class witch inherits from this class
        
         internal - members can be reached from within the same project only

         protected internal - as above + classes which inherits from this class
            can reach it members - even from another project

         private - can only be reached by members from the same class.
            Classes and structs are by default set to private.
        */

        /*private*/ string color; // by default it's private - backing field for property

        // = value - if empty it will take this value
        public CustomClass1(string color = "default") {
            this.color = color;
        }
        //public CustomClass1() :this("none") {
        //    // explictly calling constructor with parameter
        //}

        //public CustomClass1(string parameter, string parameter2) : this() {
        // Code
        //}

        public string Describe() {
            return "This is awesome object of class CustomClass1 - " + this.color;
        }

        // method overloading
        public string Describe(string text) {
            return text + " This is awesome object of class CustomClass1 - " + this.color;
        }
        public string Color // property 
        {
            // autoproperty - shorthand for commented bit of code
            get;//{return this.color;} 
            set;//{ this.color = value; }
        }
    }
}
