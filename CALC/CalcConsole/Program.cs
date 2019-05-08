using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorExample
{
    //this class details the entry into the application
    class Program
    {
        static void Main()
        {
            Calc c = new Calc();
            int ans = c.Add(10, 84);
            Console.WriteLine("10 + 84 is {0}", ans);
            //wait for user to press enter before shutting down
            Console.ReadLine();
        }
    }
    class Calc
    {
        public int Add(int X, int Y)

        { return X + Y; }
    }
}
