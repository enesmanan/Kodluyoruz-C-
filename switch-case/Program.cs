using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayindasiniz.");
                    break;
                case 2:
                    Console.WriteLine("Subat ayindasiniz.");
                    break;
                case 9:
                    Console.WriteLine("Eylul ayindasiniz.");
                    break;
                case 3:
                    Console.WriteLine("Mart ayindasiniz.");
                    break;


                default:
                    Console.WriteLine("Yanlıs veri girisi!");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis ayindasiniz.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Ilkbahar ayindasiniz.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayindasiniz.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ayindasiniz.");
                    break;



                default:
                    break;
            }

        }
    }
}
