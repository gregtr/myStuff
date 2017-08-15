using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpQuickReference.src
{
    class Enumerations
    {
        public enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        public Enumerations(int day)
        {
            Days eDay = (Days) day;
            Console.WriteLine(eDay);

            string[] values = Enum.GetNames(typeof(Days));
            foreach (string s in values)
            {
                Console.WriteLine(s);
            }
        }
    }
}
