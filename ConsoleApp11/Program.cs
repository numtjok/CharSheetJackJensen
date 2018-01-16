using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            Console.WriteLine("Please enter the first name of your Character:");
            class1.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter the last name of your Character");
            class1.LastName = Console.ReadLine();
            Console.WriteLine("Please enther the age of you Character");
            class1.Age = Int32.Parse(Console.ReadLine());

        }
    }
}
