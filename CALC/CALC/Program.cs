using System;


namespace CalculatorExample
{
 //this class details the entry into the application
    class Program
    {
        static void Main()
        {
            Calc c = new Calc();
            int ans = c.Add(10, 84);
            Console.WriteLine("10 + 84 is {o}", ans);
            //wait for user to press enter before shutting down
            Console.ReadLine();
        }
    }
}
