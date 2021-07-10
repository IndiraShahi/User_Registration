using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration problem");
            // Creating object
            RegexTest R = new RegexTest();
            Console.WriteLine(R.TestFirstName("Indira"));
        }
    }
}
