using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpQuickReference.src
{
    // interface same as abstract class cant have instances of them 
    // Properties, indexers , events and virtual methods are allowed 
    // It's a set of "rules" that class needs to implement
    // C# disalloves multiple inheritence but allows multiple interfaces
    interface Interface1
    {
        string Describe();
        string Name
        {
            get;
            set;
        }
    }
    // in the interface access modifiers are not allowed - all is by default public
    class TempClass : Interface1, IComparable
    {
        // by promissin that we will implement CompareTo method - list of this objects can sort it - by comparing elements
        private string name;

        public TempClass(string name)
        {
            this.Name = name;
        }

        public string Describe()
        {
            return " Some string " + this.Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is Interface1)
                return this.Name.CompareTo((obj as Interface1).Name);
            return 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
