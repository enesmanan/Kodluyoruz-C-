using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >= 5 && time <= 12)
            {
                Console.WriteLine("Gunaydın.");
            }
            else if (time <= 19)
            {
                Console.WriteLine("Iyi gunler.");
            }
            else
            {
                Console.WriteLine("Iyi geceler.");
            }

            string sonuc = time < 19 ? "Iyi gunler." : "Iyi geceler.";

            sonuc = time >= 5 && time <= 12 ? "Günaydın" : time <= 19 ? "Iyi gunler." : "Iyi geceler";

            Console.WriteLine(sonuc);
        }
    }
}
