using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace C_BeginnerProject
{
    internal class Program
    {
        // Main method starting point 
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your favorite color?");
            //Console.ReadLine();
            //Console.WriteLine("Me too!");
            //Console.WriteLine();

            // ----- numbers -----
            int i = 1;
            long l = 1;
            float f = 1.0f;
            double d = 1.0;

            // ----- Strings and characters -----
            char c = 'a';
            string name = "Brian";

            // ----- variable type inference -----
            var v = "var";
            var var = 1;

            // ----- Boolean -----
            bool isBool = true;

            // ----- Arithmetic operators -----
            int one = 1;
            int two = 2;
            int three = 3;

            int sum = one + two + three;
            int product = two * two * three;
            int quotient = product / 3;
            int mod = product % 5;

            Console.WriteLine(sum + " | " + product + " | " + quotient + " | " + mod + " | ");


            // ----- Conditional statements -----
            int age = 18;

            if (age >= 18)
            {
                Console.WriteLine("legal adult");
            }
            else if (age < 2)
            {
                Console.WriteLine("infant");
            }
            else
            {
                Console.WriteLine("minor");
            }

            switch (age)
            {
                case 1:
                case 2: // C# does not allow multiple case values on same line
                    Console.WriteLine("infant");
                    break;
                //case 2, 4: // C# does not allow multiple case values on same line
                case 18:
                    Console.WriteLine("18 years old");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }


            // ----- Loops -----
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine(j);
            }

            int x = 100;
            while (x <= 105)
            {
                Console.WriteLine(x++);
            }

            do
            {
                Console.WriteLine(x++);
            } while (x <= 110);
            Console.WriteLine();

            string greet = GreetUser("Brian");
            Console.WriteLine(greet);
            Console.WriteLine();


            // ----- Arrays -----
            int[] odds = new int[5];
            odds[0] = 1;
            odds[1] = 3;
            odds[2] = 5;
            odds[3] = 7;
            odds[4] = 9;

            int[] evens = {2,4,6,8,10};

            Console.WriteLine(evens[0]);
        }

        // ----- Methods -----
        static string GreetUser(string name)
        {
            Console.WriteLine("Hello " + name + "!");
            return "You are learning C#!";
        }
    }
}
