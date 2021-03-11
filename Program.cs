using System;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sanjana";
            string pattern = @"[A-Z]\w{2,}";
            var result = Regex.IsMatch(name, pattern);
            Console.WriteLine(result);


        }
    }
}
