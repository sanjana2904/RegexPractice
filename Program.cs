using System;
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

            string phoneNumber = "91 9900776633";
            pattern = @"^\d{2}\s\d{10}$";
            result = Regex.IsMatch(phoneNumber, pattern);
            Console.WriteLine("phoneNumber result is : " + result);


            string password = "sanjanaks";
            pattern = @"/^.{8,}$";
            result = Regex.IsMatch(password, pattern);
            Console.WriteLine("password result is : " + result);





        }
    }
}
