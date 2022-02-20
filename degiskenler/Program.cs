// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace degiskenler // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * veri_tipi degisken_ismi = deger; seklinde tanimlanir *
            int deger = 2;

            // * Buyuk kucuk harf duyarlidir *
            string degisken = null;
            string Degisken = null;

            // * Iki kelimeden oluşan bir değişken ismi kullanmak için " _ " isareti ile birlestirme yapilabilir *
            string degisken_veri = null;
        
            // *Asagıdaki sekillerde tanimlanamaz *
            // string degisken+veri = null;
            // string degisken veri = null;
            // string class = "";

            // * Aynı isimle ikinci bir degisken tanimlanamaz *
            // string degisken = " "; 

            // * White space *
            string deg = " "; 

            // * byte 0 ile 255 arasi deger alabilir / bellekte 1 byte yer kaplar *
            byte b = 5;
            // * sbyte -128 ile 127 arasi deger alabilir / bellekte 1 byte yer kaplar *
            sbyte c = 5;

            // * short -327648 ile 327648 arasi deger alabilir / bellekte 2 byte yer kaplar *
            short s = 5;
            // * unsigned short 0 ile 65365 arasi deger alabilir / bellekte 2 byte yer kaplar *
            ushort us = 5; 

            // * int / bellekte 4 byte yer kaplar *
            int i = 2;
            // * int16 / bellekte 2 byte yer kaplar *
            Int16 i16 = 2;
            // * int32 / bellekte 4 byte yer kaplar *
            Int32 i32 = 2;
            // * int64 / bellekte 8 byte yer kaplar *
            Int32 i64 = 2;
            // * unsigned int / bellekte 4 byte yer kaplar *
            uint ui = 2;

            // * long / bellekte 8 byte yer kaplar *
            long l = 4;
            // * unsigned long / bellekte 8 byte yer kaplar *
            ulong ul = 4;

            // * Asagidaki degisken türleri reel sayilar icin kullanilir * 
            // * float / bellekte 4 byte yer kaplar *
            float f = 5;
            // * double / bellekte 8 byte yer kaplar *
            double d = 5;
            // * decimal / bellekte 16 byte yer kaplar *
            decimal de = 5;

            // * char / bellekte 16 byte yer kaplar * 
            char ch = '2';
            // * string / bellekte sinirsiz yer kaplar *
            string str = "string";

            // * bool true/false degeri tutar *
            bool b1 = true;
            bool b2 = false;

            // * datetime tarih ve saat degerlerini tutar *
            DateTime dt = DateTime.Now;
            //Console.WriteLine(dt);

            // * object tür bagımsız tanımlama yapılabilir -
            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // * string ifadeler *
            //string str1 = "";
            //string str1 = null;
            string str1 = string.Empty;
            str1 = "Ulas Karakas";

            string ad = "Ulas";
            string soyad = "Karakas";
            string ad_soyad = ad + " " + soyad;

            // * integer ifadeler *
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // * bool ifadeler *
            bool bool1 = 10>2;

            // * degisken donusumleri *
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            //Console.WriteLine(yeniDeger); // * Ciktisi 2020 *

            int int21 = int20 + Convert.ToInt32(str20);
            //Console.WriteLine(int21); // * Ciktisi 40 *

            int int22 = int20 + int.Parse(str20);
            //Console.WriteLine(int22); // * Ciktisi 40 *

            // * datetime *
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime); // * Ciktisi 20.02.2022 *
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2); // * Ciktisi 20/02/2022 *
            string hour= DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour); // * Ciktisi 02:34 *

        }
    }
}
