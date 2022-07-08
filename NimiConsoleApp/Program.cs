using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week1 Assignment
            var myName = "Oladejo Abimbola";
            string Track = "Backend Dev Track";
            Console.WriteLine("Hello, my name is " + myName +" I am in "+ Track +" of Wella Schools.");
            var R = "My reason for learning Backend Development is because I will like be a software dev and " +
                    " also gain more knowlege in programmming. Hopefully someday I get to develop my own website.";
            Console.WriteLine(R);

            //Assignment 2
            string welcome = "Welcome to my first C# program";
            char letStart = 'S';
            bool isCSharpEasy = true;
            bool a = 111 >= 101;
            int myFavouriteNumber = 31;
            float b = 119/4;
            float b1 = 100e3F;
            long  b2 = 143508600000;
            double c = 12e24;
            char end = 'E';

            Console.WriteLine(welcome);
            Console.WriteLine(letStart);
          
            Console.WriteLine(isCSharpEasy);
            Console.WriteLine(a);
            Console.WriteLine(myFavouriteNumber);
            Console.WriteLine(b);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(c);
            Console.WriteLine(end);

            //implicit and explicit
            int myLevel = 4;
            char myLevelChar = (char)myLevel;  //explicit

            float myCpga = 4.98F;
            double m = myCpga;

            int courses =  11;
            float n = courses;
            long l = courses;

            Console.WriteLine(myLevel);
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(l);
            
            //Week 3
            int myAge = 20;
            Console.WriteLine(myAge);
            myAge += 2;
            Console.WriteLine(myAge);
            int firstRemainder = 88 % 5;
            Console.WriteLine(firstRemainder);

            Console.WriteLine("This is a Calculator App");
            Console.Write("Type in your first number: ");
            string firstNumber = Console.ReadLine();
            //int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Type in your second number: ");
            string secondNumber = Console.ReadLine();
            string result = firstNumber + secondNumber;

            Console.WriteLine("The answer is " + result);

            //Week4
            //<<<Decision making/Conditionals>>
            if (false)
            {
                Console.WriteLine("The statement is true");
            }
            else if (true)
            {
                Console.WriteLine("The second statement is false");
            }
            else
            {
                Console.WriteLine("The statement is false");
            }

            //<Realtional Operators>>
            if (2 == 5)
            {
                Console.WriteLine("They are equal");
            }
            else if (2 > 1)
            {
                Console.WriteLine("Two is greater than 1");
            }
            else if (5 >= 5)
            {
                Console.WriteLine("5 is greater than or equal to 5");

            }
            else
            {
                Console.WriteLine("They are not equal");
            }

            //<<<Logical operator>>>
            if (true && true)
            {
                Console.WriteLine("AND operator is true");
            }
            if (false || false)
            {
                Console.WriteLine("OR operator is false");
            }

            if (true && true)
            {
                Console.WriteLine("1 is true");
            }
            else
            {
                Console.WriteLine("1 is false");
            }

            //A Simple App
            Console.WriteLine("Welcome to Veepay");
            Console.Write("Will you like to sign up: ");
            string signup = Console.ReadLine();
            if (signup == "Yes")
            {
                Console.WriteLine("Click the button below to create an account.");
                Console.WriteLine("Input your information.");

                Console.Write("Name:  ");
                string name = Console.ReadLine();

                Console.Write("How old are you? ");
                int age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.Write("Phone Number:  ");
                    string phoneNumber = Console.ReadLine();
                }
                else
                {
                    Console.Write("You are not allowed to create an account.");
                }
                Console.Write("Account Number: ");
                string acctNo = Console.ReadLine();
                Console.Write("Create a password: ");
                string password = Console.ReadLine();
                Console.WriteLine("Account created, login to your account");
            }
            else
            {
                Console.WriteLine("Already have an account?, then Sign in now.");
                Console.Write("Email Address or Mobile Number:  ");
                string emailAddress = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                Console.WriteLine("Sign in");
            }


            Console.ReadKey();
        }
    }
}
