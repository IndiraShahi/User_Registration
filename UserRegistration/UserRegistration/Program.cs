using System;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration problem");
            // Creating object
            RegexTest R = new RegexTest();
            Console.WriteLine(R.TestFirstName("Indira"));
            Console.WriteLine(R.TestLastName("Shahi"));
            Console.WriteLine(R.TestEmail("abc+123@gmail.com"));
            Console.WriteLine(R.TestMobileNumber("91 9876543210"));
            Console.WriteLine(R.TestPassword("ABCdefg@567890"));
        }
    }
}
