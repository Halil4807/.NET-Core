using System;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name="Halil";
            string surname="ÖZTÜRK";
            int age=25;
            string str1 = "My name is " + name + " " + surname+" and I'm "+age+" years old.";
            string str2 = $"My name is {name} {surname} and I'm {age} years old.";
            string str3 = string.Format("My name is {0} {1} and I'm {2} years old.",name,surname,age);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        }
    }
}
