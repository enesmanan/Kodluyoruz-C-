using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   Atama ve Islemli Atama");
            //Atama ve Islemli Atama
            int x = 8;
            int y = 3;

            y = y + 1;
            Console.WriteLine(y);

            x /= 2;
            Console.WriteLine(x);

            y += 2;
            Console.WriteLine(y);

            x *= 4;
            Console.WriteLine(x);

            Console.WriteLine("   Mantiksal Operatorler ||, &&, !");
            //Mantiksal Operatorler ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }
            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great!");
            }
            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }
            Console.WriteLine("   Iliskisel Operatorler <, >, <=, >=, ==, !=");
            // Iliskisel Operatorler
            // <, >, <=, >=, ==, !=

            int a = 2;
            int b = 19;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("   Aritmetik Operatorler +, -, *, /");
            //Aritmetik Operatorler +, -, *, /

            int sayi1 = 15;
            int sayi2 = 5; 

            int islem = sayi1 / sayi2;
            Console.WriteLine(islem);
            islem = sayi1 * sayi2;
            Console.WriteLine(islem);
            islem = sayi1 + sayi2;
            Console.WriteLine(islem);
            islem = sayi1 - sayi2;
            Console.WriteLine(islem);
            islem = sayi2++;
            Console.WriteLine(sayi2);

            //Mod islemi
            int islem2 = 12 % 5;
            Console.WriteLine(islem2);


            Console.ReadKey();
        }
    }
}
