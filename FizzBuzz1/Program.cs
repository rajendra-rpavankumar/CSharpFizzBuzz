using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) result = "Fizz";
                if (i % 5 == 0) result = result +"Buzz";
                if (result.Length == 0) result += i;
                Console.WriteLine(result);
            }
        }
    }
}
