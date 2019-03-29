using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment.
            // Let's get into variables.
            
            // Defining Variables: [Date Type] [Variable Name] [Initializer: = 1 (optional)];
            // Strongly Typed: (int age = 1)
            // var age = 1; // <-- Whole Number, let's make this an Integer

            // Data Types
            // Integers: 
            //  - Whole Numbers: 1, 2345532, -200, 0, 300
            // Strings:
            //  - Any sequence of characters (numbers, letters, symbols, etc), MUST
            //    be surrounded by double quotes.
            // Doubles:
            //  - Decimal numbers 
            int age = 25;
            string name = "TeachMeMobile";
            double money = 1500.15;

            // types: int, string, double
            var yourAge = 30;
            var yourName = "Viewer";
            var yourMoney = 159384859.11;

            Console.WriteLine(money);
            Console.ReadKey();

            age = 26;
            Console.WriteLine("Happy Birthday! You are now " + age);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
