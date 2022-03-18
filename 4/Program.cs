using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string myZodiakSign;
            string myWork;


            Console.WriteLine("Как Вас зовут");

            myName = Console.ReadLine();

            Console.WriteLine("Какой Ваш знак зодиака?");

            myZodiakSign = Console.ReadLine();

            Console.WriteLine("Где Вы работаете?");

            myWork = Console.ReadLine();

            Console.WriteLine("Вас зовут " + myName + ", ваш знак зодиака " + myZodiakSign + ", вы работаете в " + myWork + ".");
        }
    }
}
