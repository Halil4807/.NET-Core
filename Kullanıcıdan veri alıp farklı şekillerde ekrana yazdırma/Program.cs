using System;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Age: ");
            string age = Console.ReadLine();

            Console.WriteLine( "My name is " + name + " " + surname+" and I'm "+age+" years old." );
            Console.WriteLine( $"My name is {name} {surname} and I'm {age} years old." );
            Console.WriteLine( string.Format("My name is {0} {1} and I'm {2} years old.",name,surname,age));
        }
    }
}
