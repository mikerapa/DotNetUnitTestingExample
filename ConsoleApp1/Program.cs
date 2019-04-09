using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDisplayName("Mike", "Rapa", "MD"));

            Console.ReadKey();
        }

        public static string GetDisplayName(string firstName, string lastName, string position)
        {
            return $"{lastName}, {firstName} ({position})";
        }
    }
}
