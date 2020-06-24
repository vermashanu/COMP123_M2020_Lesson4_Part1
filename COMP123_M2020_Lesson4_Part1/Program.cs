using System;

namespace COMP123_M2020_Lesson4_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("shivani", 22);

            person.saysHello();

            Console.WriteLine(person.ToString());

            Console.ReadLine();
        }
    }
}
