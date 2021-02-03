using System;

namespace MyFirstHello
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello HTL-World!");
            Console.WriteLine("These are my known facts...");

            // Ausgabe eines Zeilenumbruchs
            Console.Write("\n");
            // Console.WriteLine() = Console.Write("\n")

            // Jetzt fragst du nach dem Namen
            Console.Write("Please enter your name: ");
            // Ich merke mir den eingegebenen Namen in der Text-Variable myName
            string myName = Console.ReadLine();
            // Console.WriteLine(myName);
            Console.Write("Please enter your phonenumber:");
            string phone = Console.ReadLine();
            Console.WriteLine(" ####################################");
            Console.WriteLine(" #\t" + myName);
            Console.WriteLine(" #\tBahnhofstraße 42");
            Console.WriteLine(" #\t4840 Vöcklabruck");
            Console.WriteLine(" #\t" + phone);
            Console.WriteLine(" #\tpacr@htlvb.at");
            Console.WriteLine(" #\thttps://www.htlvb.at");
            Console.WriteLine(" ####################################");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
