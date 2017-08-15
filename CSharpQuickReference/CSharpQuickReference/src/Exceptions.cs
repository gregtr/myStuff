using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpQuickReference.src
{
    class Exceptions
    {
        public static void testException(){
            int[] numbers = new int[2];
            try
            {
                numbers[0] = 12;
                numbers[1] = 124;
                numbers[2] = 1234; // out of the bounds exception ERROR

                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                }
            }// parameters for catch are optional
            catch (IndexOutOfRangeException ex) { Console.WriteLine("Out of the range exception"); }
            catch(Exception ex) { Console.WriteLine("Exception occured " + ex.Message + " - " + ex.GetType().ToString()); }
            finally { Console.WriteLine("This will always show up"); }
        }
    }
}
