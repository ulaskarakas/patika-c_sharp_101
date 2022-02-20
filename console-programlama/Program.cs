// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using System;

namespace console_programlama // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine("İsminizi giriniz:");
            var name = Console.ReadLine();
            //Console.WriteLine("İsminizi giriniz:");
            var surname = Console.ReadLine();

            //Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
