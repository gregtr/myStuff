using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpQuickReference.src
{
    // great for frameworks - naming should describe concept - abstract concept
    abstract class AbstractClass
    {
        public virtual string Describe()
        {
            return "Just default text";
        }

        public abstract string abstractMethod();
    } 
    // to override inherited method , base method needs to be marked as vitual, abstract, or override
    // to disallov futher overrides - we can use sealed override keyword
    
    // no instance of abstract class can be created
    class ObjClass : AbstractClass
    {
        public override string Describe()
        {
            string result = base.Describe();
            result += " - same but different";
            return result;
        }

        public override string abstractMethod()
        {
            throw new NotImplementedException();
        }
    }
}
