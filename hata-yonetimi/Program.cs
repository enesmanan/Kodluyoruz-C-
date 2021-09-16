using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("deneme");
                int a = int.Parse("-13524426355");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Kucuk ya da buyuk deger.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Islem basariyla tamamlanmistir.");
            }
        }
    }
}
