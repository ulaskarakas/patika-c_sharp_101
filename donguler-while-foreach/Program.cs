using System;

namespace donguler_while_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * While *
            //1'den başlayarak consoldan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console'a yazdıran program
            Console.WriteLine("* While *");
            Console.Write("Lutfen bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //'a' dan 'z' ye kadar tüm harfleri console'a yazdıran program
            char c = 'a';
            while (c <= 'z')
            {
                Console.WriteLine(c);
                c++;
            }

            // * Foreach * 
            Console.WriteLine("* Foreach *");
            string[] arabalar = {"Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}