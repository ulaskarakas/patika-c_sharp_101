using System;

namespace if_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            Console.WriteLine("Saat su an " + time);

            if (time>=6 && time<=11)
                Console.WriteLine("Gunaydin");
            else if(time>=12 && time<=18)
                Console.WriteLine("Iyı gunler");
            else if(time>=19 && time<=23)
                Console.WriteLine("Iyı aksamlar");
            else
                Console.WriteLine("Iyı geceler");

            //string sonuc = time<=18 ? "Iyı gunler" : "Iyı aksamlar";
            string sonuc = time>=6 && time<=11 ? "Gunaydin" : time>=12 && time<=18 ? "Iyı gunler" : time>=19 && time<=23 ? "Iyı aksamlar" : "Iyı geceler";
            Console.WriteLine(sonuc);


        }
    }
}