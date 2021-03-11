﻿using System;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Sanjana";
            string pattern = @"^[A-Z]\w{2,}";
            var result = Regex.IsMatch(firstName, pattern);
            Console.WriteLine("First name result : " + result);

            string lastName = "Karthi";
            result = Regex.IsMatch(lastName, pattern);
            Console.WriteLine("Last name result : " + result);

            string email = "sanju@gmail.com";
            pattern = @"^[\w]+@[a-zA-Z0-9]+.[a-zA-Z0-9]+";
            result = Regex.IsMatch(email, pattern);
            Console.WriteLine("email result is : " + result);







        }
    }
}
