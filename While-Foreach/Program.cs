using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While");
            //While
            //1 den baslayarak girilen sayiya kadar(sayi dahil) ortalama hesaplayarak console'a yazdiran program:

            Console.WriteLine("Lutfen bir sayi giriniz.");

            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            //A dan Z ye kadar tum harfleri yazdiran program:
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine("Foreach");
            //Foreach
            string[] arabalar = { "Mitsubishi", "Subaru", "Mazda", "Nissan" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
