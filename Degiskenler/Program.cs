using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 8;     //1 byte
            sbyte c = 8;    //1 byte

            short s = 8;    //5 byte
            ushort us = 8;  //2 byte 

            Int16 i16 = 3;  //2 byte 
            int i = 3;      //4 byte 
            Int32 i32 = 3;  //4 byte
            Int64 i64 = 3;  //8 byte

            uint ui = 8;    //4 byte 
            long l = 4;     //8 byte
            ulong ul = 6;   //8 byte 

            // Reel Sayılar
            float f = 5;    //4 byte 
            double d = 5;   //8 byte 
            decimal de = 5; //16 byte 

            char karakter = '2';    //2 byte 
            string metin = "Enes";  //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 7;
            object o4 = 5.1;

            // String ifadeler 

            string str1 = string.Empty;
            str1 = "Enes Fehmi Manan";
            string ad = "Enes Fehmi";
            string soyad = "Manan";
            string tamİsim = ad + " " + soyad;

            Console.WriteLine(str1 + " " + ad + " " + soyad + " " + tamİsim);
            // integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 - integer2;
            Console.WriteLine("Console View" + integer1 + integer2 + integer3);

            // boolean 
            bool bool1 = 10 > 2;

            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 21;

            string yenideğer = str20 + int20.ToString();
            Console.WriteLine(yenideğer); //Cıktısı 2021 

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //Cıktısı 41

            int int22 = int20 + int.Parse(str20); //Cıktısı 41

            //datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime2);

            //hour
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


            Console.ReadKey();
        }
    }
}
