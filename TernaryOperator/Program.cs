using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how long your peppers are: ");

            double pepperLength = Convert.ToDouble(Console.ReadLine());
            string message = (pepperLength >= 3.5) ? "They are ready!" : "Wait a little longer";
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
