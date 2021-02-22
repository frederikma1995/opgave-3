using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace øvelse_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the principal amount? ");
            int pricipalAmount = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the rate? ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the number of years? ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the number of times the interest is compounded per year ? ");
            int numberOfTimesAYear = Convert.ToInt32(Console.ReadLine());

            var A = pricipalAmount * Math.Pow(( 1 + ( rate / numberOfTimesAYear)), year);
            Console.WriteLine("${0} invested at {1}% for {2} years compounded {3} times per year is ${4}.", pricipalAmount, rate, year, numberOfTimesAYear,A);
            Console.ReadLine();
        }
    }
}
