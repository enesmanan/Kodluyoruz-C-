using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminiz Lutfen!");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınız Lutfen!");
            string surname = Console.ReadLine();
            Console.WriteLine("Yasınız Lutfen!");
            string yas = Console.ReadLine();

            Console.WriteLine("Hosgeldin!" + " " + name + " " + surname + " " + yas);
            Console.ReadKey();
        }
    }
}
