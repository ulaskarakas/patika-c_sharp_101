using System;

namespace tip_donusumleri // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * Implicit Conversion *
            Console.WriteLine("\n* Implicit Conversion *");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d=" + d);

            long h = d;
            Console.WriteLine("h=" + h);

            float i = h;
            Console.WriteLine("i=" + i);

            string e = "ulas";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g=" + g);

            // * Explicit Conversion *
            Console.WriteLine("\n* Explicit Conversion *");

            int x = 3;
            byte y = (byte)x;
            Console.WriteLine("y=" + y);

            float w = 8.3f;
            int z = (int)w;
            Console.WriteLine("w=" + w);

            // -- ToString Metodu --
            Console.WriteLine("\n-- ToString Metodu --");

            int xx = 12;
            int yy = 14;
            string zz = xx.ToString() + yy;
            Console.WriteLine("zz=" + zz);
            string kk = "Dev Adam";
            string mm = xx.ToString() + " " + kk;
            Console.WriteLine("mm=" + mm);

            // -- System.Convert Sinifi --
            Console.WriteLine("\n-- System.Convert Sinifi --");
            
            string s1="10", s2="20";
            int sayi1, sayi2;
            int toplam;

            sayi1=Convert.ToInt32(s1);
            sayi2=Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("sayi1=" + sayi1); 
            Console.WriteLine("sayi2=" + sayi2); 
            Console.WriteLine("toplam=" + toplam); 

            // -- Parse Metodu --
            Console.WriteLine("\n-- Parse Metodu --");

            ParseMethod();

        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam1=" + rakam1); 
            Console.WriteLine("double1=" + double1); 

        }
    }
}