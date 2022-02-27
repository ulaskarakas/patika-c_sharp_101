using System;

namespace donguler_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * Ekrandan girilen sayiya kadar olan tek sayilari ekrana yazdir * 
            Console.WriteLine("Lutfen bir sayi giriniz: ");
            try
            {
                int sayi = int.Parse(Console.ReadLine());
                for (int i = 1; i<=sayi; i++)
                {
                    if (i%2!=0)
                        Console.WriteLine(i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // * 1 ile 1000 arasindaki tek ve cift sayilarin toplamini ekrana yazdir *
            int toplamTek = 0;
            int toplamCift = 0;
            for (int i = 0; i<= 1000; i++)
            {
                if (i%2==0)
                    toplamCift += i;
                else
                    toplamTek += i;
            }
            Console.WriteLine("Tek sayilar toplami: " + toplamTek);
            Console.WriteLine("Cift sayilar toplami: " + toplamCift);
            

            // * break, continue *

            // * 1 ile 10 arasinda 5'e kadar olan sayilari yazdir *
            for (int i = 1; i<=10; i++)
            {
                if(i>5)
                    break;
                Console.WriteLine(i);
            }

            // * 1 ile 10 arasinda 4 ve 8 hariç tüm sayilari ekrana yazdir * 
            for (int i = 1; i<=10; i++)
            {
                if(i==4 || i==8)
                    continue;
                Console.WriteLine(i);
            }
            
        }
    }
}