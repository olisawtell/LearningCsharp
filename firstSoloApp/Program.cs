using System;

namespace firstSoloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output to Console
            Console.WriteLine("Hello World!");
            Console.WriteLine("------------");
            Console.WriteLine("This is the first program I have written in C# without going through the course");
            Console.WriteLine("Lets see what I have learned!");
            Console.WriteLine(" ");
            // Taking user inputs and placing them into variables
            Console.WriteLine("userInputs");
            Console.WriteLine("----------");
            Console.WriteLine("Enter your name: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sex: ");
            string sex1 = Console.ReadLine();
            Console.WriteLine("Enter your Bank Balance: ");
            int bankBal1 = int.Parse(Console.ReadLine());
            //Displaying captured information using concatenation
            Console.WriteLine("Display using concatenation: ");
            Console.WriteLine(name1 + " you are a " + sex1 + " and you are " + age1 + " years old and you have " + bankBal1 + " in your Bank.");
            Console.WriteLine(" ");
            Console.WriteLine("Display using string interpolation: ");
            // Displaying captured information using string interpolation
            Console.WriteLine($"{name1} you are a {sex1} and you are {age1} years old and you have {bankBal1:C} + in your Bank.");
            // Displaying information in a formatted table
            Console.WriteLine(" ");
            Console.WriteLine("Display using a table and string interpolation and formatters");

            string col1Heading = "Name:";
            string col2Heading = "Age:";
            string col3Heading = "Sex:";
            string col4Heading = "Balance:";

            Console.WriteLine($"{col1Heading, -5} {col2Heading, -3} {col3Heading, -6} {col4Heading, 15}");
            Console.WriteLine($"{name1, -5} {age1, -6} {sex1, -6} {bankBal1, 15:C}");

            Console.WriteLine(" ");
            Console.WriteLine("Now enter the details of a second person");
            Console.WriteLine(" ");
            Console.WriteLine("Enter a new Name:");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter a new age: ");
            int age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a new Sex: ");
            string sex2 = Console.ReadLine();
            Console.WriteLine("Enter a new Bank Balance: ");
            int bankBal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Now to display both records in the table:");
            Console.WriteLine(" ");
            Console.WriteLine($"{col1Heading,-5} {col2Heading,-3} {col3Heading,-6} {col4Heading,15}");
            Console.WriteLine($"{name1,-5} {age1,-6} {sex1,-6} {bankBal1,15:C}");
            Console.WriteLine($"{name2,-5} {age2,-6} {sex2,-6} {bankBal2,15:C}");

            Console.ReadKey();

        }
    }
}
