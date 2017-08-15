using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpQuickReference.src
{
    class CustomChildClass1 : CustomClass1
    {
        string color;

        public string Describe()
        {
            return "This is awesome object of class CustomChildClass1 - ";
        }

        public string Describe(string text)
        {
            base.Describe(text);
            return "";
        }
    }
}
