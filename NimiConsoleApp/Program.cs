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


            Console.ReadKey();
        }
    }
}
