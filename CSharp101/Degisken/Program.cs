using System;

namespace Degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // DateTime
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            // Object
            object obj1 = 'g';
            object obj2 = "gizem";
            object obj3 = 3;
            object obj4 = 3.4;

            // String İfadeler
            string tamIsim = string.Empty;
            string ad = "Gizem";
            string soyad = "Çimen";
            tamIsim = ad + " " + soyad;
            Console.WriteLine("Merhaba " + tamIsim + " :) ");

            // Integer Tanımlama Şekilleri
            int num16 = 8;
            int num17 = 9;
            int num18 = num16 + num17;
            Console.WriteLine(num18);

            /*
            // Boolean
            bool b1 = 10 < 2;  // false
            bool b2 = 10 > 2;   // true
            */

            // Değişken Dönüşümleri
            string str3 = "20";
            int num19 = 20;

            string yeniDeger1 = str3 + num19.ToString();
            Console.WriteLine("Çıktı: " + yeniDeger1);      // Çıktı: 2020

            int yeniDeger2 = num19 + Convert.ToInt32(str3);
            Console.WriteLine("Çıktı: " + yeniDeger2);      // Çıktı: 40

            int yeniDEger3 = num19 + int.Parse(str3);
            Console.WriteLine("Çıktı: " + yeniDEger3);      // Çıktı: 40

            string dateTime1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime1);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

            Console.ReadLine();


            /*

            // Sayılar
            byte num2 = 5;          // 1byte
            sbyte num3 = 5;         // 1byte

            short num4 = 5;         // 2byte
            ushort num5 = 5;        // 2byte

            Int16 num6 = 5;         // 2byte
            int num7 = 5;           // 4byte
            Int32 num8 = 5;         // 4byte
            Int64 num9 = 5;         // 8byte

            uint num10 = 5;         // 4byte (sadece pozitif)
            long num11 = 5;         // 8byte
            ulong num12 = 5;        // 8byte

            // Reel Sayılar            
            float num13 = 5.5f;      // 4byte
            double num14 = 5.5d;     // 8byte
            decimal num15 = 5.5m;    // 16byte

            // Karakter
            char chr1 = 'g';        // 2byte
            string str2 = "gizem";  // sınırsız

            bool t = true;
            bool f = false;

            */


        }
    }
}
