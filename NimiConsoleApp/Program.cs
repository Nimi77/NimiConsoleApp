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
            double a = 5.0; 
            bool b = true;
            Console.WriteLine(welcome);
            Console.WriteLine(a);
            Console.WriteLine(b);
            //Console.WriteLine("First C# program...");
            //Console.WriteLine("Wella Backend Dev");


            Console.ReadKey();
        }
    }
}
