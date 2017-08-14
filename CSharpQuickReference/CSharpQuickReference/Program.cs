using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpQuickReference
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /**********************************************
             * Variables
             *  <data type> <name>;
             *  <visibility> <data tyoe> <name> = <value>;
             ***********************************************/
            string firstName = "Name";
            string lastName = "LastName";

            Console.WriteLine("Name : " + firstName + " - LastName : " + lastName);
            Console.WriteLine("Changing firstName :");
            firstName = "NewName"; // Console.ReadLine();
            Console.WriteLine("Name : " + firstName + " - LastName : " + lastName);

            int number1, number2;
            // Console.WriteLine(number1 + number2); ERROR - always assign value before the use
            number1 = number2 = 1;
            Console.WriteLine(number1.ToString() + " " + number2.ToString() + " " + (number1+number2));
            
            /**********************************************
             * Loops
             *  
             *  #IF
             *  if(condition) { <code> } else [if(condition)] { <code> }
             *  
             *  #Switch
             *  switch(string/number) {
             *      case <value>:
             *          <code>
             *          [break;]
             *      [default]:
             *          <code>
             *          [break;]
             *   }
             *   
             *   #Do-While
             *   do { <code> }while(condition);
             *   
             *   #While   
             *   while(condition){ <code> }
             *   
             *   #For
             *   for(variable;condition;incrementation) { <code> }
             *   
             *   #Foreach
             *   foreach(var value in EnumerableObject) { <code> }
             *   
             ***********************************************/
            if (number1 > 100)
                number2 = 100;
            else
                number1 = 100;

            switch(number1) {
                case 0:
                    // code
                    break;
                case 1:
                    // code
                    break;
                default:
                    // code
                    break;
            }

            while(number1 < 1000) {
                Console.Write(".");
                number1++;
            }
            
            for(var i = 0; i < 10; i++) {
                // code
            }

            int[] nArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 };
            foreach(int i in nArray) {
                Console.Write(i);
            }

            /******************
             * Functions
             ******************/

            foo();

            string foo1Text = foo1(10, "text");

            int number3 = 10;
            AddOne(ref number3);
            
            string newString;
            WelcomeFunction(out newString);

            ArrayDisplayer(new string[] { "A", "B", "C" });

            ArrayDisplayer2();
            ArrayDisplayer2("A");
            ArrayDisplayer2("D","Z");
            ArrayDisplayer2(new string[] { "F", "G" });

            /**********************************************
             * Arrays
             *  <data type>[] <name>;
             *  <data type>[] <name> = new <data type>[number];
             ***********************************************/

            string[] names;
            string[] names2 = new string[10];
            string[] names3 = new string[4] { "a", "b", "c", "d" };
            string[] names4 = { "a", "b" };

            names = new string[1];
            names[0] = "TestString";

            /**********************************************
             * Classes
             ***********************************************/
            CustomClass1 classObject = new CustomClass1();
            Console.WriteLine(classObject.Describe());
            Console.WriteLine(classObject.Color); //// TODO - read bout this
            string tempString = classObject.Color = "test";
            Console.WriteLine(tempString);

            // TODO - check all major classes and functions - like class Object and just do some random stuff with it
            Console.ReadLine();
        }

        /**********************************************
        * Functions
        *  <visibility> <return type> <name>(<parameters>) { 
        *       <code> 
        *  } 
        ***********************************************/
        public static void foo() {
            Console.WriteLine("Foo function...");
        }
        public static string foo1(int number, string text) {
            return number.ToString() + "-" + text;
        }

        // Passing value by reference - must be initialized 
        static void AddOne(ref int number) { number++; }

        // Passing value by reference - can be unitialized but new value must be assigned before return
        static void WelcomeFunction(out string name) {
            name = "newName";
        }

        static void ArrayDisplayer(string[] array) {
            foreach(string str in array) {
                Console.WriteLine(str.ToString());
            }
        }

        // only one params in parametersr + can be used with other parameter types but <params> must be the last parameter
        static void ArrayDisplayer2(params string[] array) {
            foreach(string str in array) {
                Console.WriteLine(str.ToString());
            }
        }
    }
}
