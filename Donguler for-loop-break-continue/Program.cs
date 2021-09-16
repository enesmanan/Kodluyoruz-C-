using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler_for_loop_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrana girilen sayiya kadar olan tek sayilari ekrana yazdir.

            Console.WriteLine("Lutfen bir sayi giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasindaki sayilarin kendi iclerinde toplamlarini ekrana yazdir.

            int tekToplam = 0, ciftToplam = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i; //tekToplam = tekToplam + 1;
                }
                else
                    ciftToplam += i; //tekToplam = tekToplam + 1;
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Cift Toplam: " + ciftToplam);

            //break, continue

            for (int i = 0; i < 10; i++)
            {
                if (i == 8)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
