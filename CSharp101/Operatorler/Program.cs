using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
                        // Atama ve Islemli Atama

            Console.WriteLine("***** Atama ve Islemli Atama *****");

            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);

            y +=1;
            Console.WriteLine(y);

            y /= x;
            Console.WriteLine(y);

            y *= 2;
            Console.WriteLine(y);

            // Mantiksal Operatorler
            // &&, ||, !

            Console.WriteLine("***** Mantiksal Operatorler *****");

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");
            
            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");
            
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            // Ilıskisel Operatorler
            // ==, !=, <, >, <=, >=

            Console.WriteLine("***** Ilıskısel Operatorler *****");

            int a = 3;
            int b = 4;

            bool sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);



            // Aritmetik Operatorler
            // +, -, *, /

            Console.WriteLine("***** Ilıskısel Operatorler *****");

            int sayi1 = 10;
            int sayi2 = 5;

            int islem = sayi1 / sayi2;
            Console.WriteLine(islem);

            islem = sayi1 * sayi2;
            Console.WriteLine(islem);

            islem = sayi1 + sayi2;
            Console.WriteLine(islem);
            
            islem = sayi1 - sayi2;
            Console.WriteLine(islem);

            
            islem = sayi1++;
            Console.WriteLine(islem);

            
            islem = sayi1--;
            Console.WriteLine(islem);

            

            // %: Mod Alir

            int modSonuc = islem % sayi2;
            Console.WriteLine(modSonuc);



            Console.ReadLine();
        }
    }
}
