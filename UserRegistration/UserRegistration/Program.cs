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
            Console.WriteLine(R.TestLastName("Shahi"));
            Console.WriteLine(R.TestEmail("abc.xyz@bl.co.in"));
        }
    }
}
