using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
internal class datatypes
{
static void Main(string[] args)
{

            // datatypes and variables

            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String

            //constants
            const int myNumb = 15;
            //myNumb = 20; // error

            //declaration of multiple variables
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);

            //imp rules:
            /* 
             1. Names can contain letters, digits and the underscore character(_)
             2. Names must begin with a letter or underscore
             3. Names should start with a lowercase letter, and cannot contain whitespace
             4. Names are case -sensitive("myVar" and "myvar" are different variables)
             5. Reserved words(like C# keywords, such as int or double) cannot be used as names
            */

         /* Escape-character  Result  Description
            \'	               '      Single quote
            \"	               "      Double quote
            \\                 \	  Backslash     */
            string txt = "We are the so-called \"Vikings\" from the north.";

            // boolean expression 
            int a = 10;
            int b = 9;
            Console.WriteLine(a > b);

            //Short Hand If...Else (Ternary Operator) - variable = (condition) ? expressionTrue :  expressionFalse;
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            //for-each loop
            /* foreach (type variableName in arrayName)
             {
                 // code block to be executed
             }*/


            //The for loop executes a statement or a block of statements repeatedly until a specified expression evaluates to false. 
            //The foreach statement repeats a group of embedded statements for each element in an array or an object collection.
           
            //array
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Declare an array
            string[] carss;

            // Add values, using new
            cars = new string[] { "Volvo", "BMW", "Ford" };

            // Good to know: The single comma[,] specifies that the array is two - dimensional.
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            // A three - dimensional array would have two commas: int[,,].

            //exception handling 
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }








            checkAge(20);
            MyMethod("sam",21);
            // Outputs "I just got executed!"
        }
        //methods:
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        //using throw keyword
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }


    }
}
