using System;

namespace DataTypes_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.Write("Type your firstname: ");
            string MyFirstName;
            MyFirstName = Console.ReadLine();


            /*
            Console.Write("Type your lastname: ");
            string MyLastName;
            MyLastName = Console.ReadLine();
            */

            Console.Write("Type your last name:");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + MyFirstName + " " + myLastName + "!");

        }
    }
}
