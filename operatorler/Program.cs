using System;

namespace operatorler // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * Atama ve islemli atama operatorlari (=, +=, -=, *=, /=) *
            Console.WriteLine("\n* Atama ve islemli atama operatorlari (=, +=, -=, *=, /=) * ");

            int x = 3;
            int y = 3;

            y+=3; // * y = y+3; *
            Console.WriteLine("y+=3 => " + y); // * Ciktisi 6 *
            y/=2; // * y = y/2; *
            Console.WriteLine("y/=2 => " + y); // * Ciktisi 3 *
            x-=1; // * x = x-1; *
            Console.WriteLine("x-=1 => " + x); // * Ciktisi 2 *
            x*=2; // * x = x*2; *
            Console.WriteLine("x*=2 => " + x); // * Ciktisi 4 *

            // * Mantıksal operatorler ( || , && , ! ) *
            Console.WriteLine("\n* Mantıksal operatorler ( || , && , ! ) * ");

            bool success = true;
            bool completed = false;

            if(success && completed)
                Console.WriteLine("Perfect"); // * Bunu yazdirmaz cunku kosul gerceklesmemistir *

            if(success || completed)
                Console.WriteLine("Good"); // * Bunu yazdirir kosul gerceklesmistir * 

            if(success || completed)
            {
                if(success && !completed)
                {
                    Console.WriteLine("Success but not completed"); // * Bunu yazdirir kosul gerceklesmistir *
                }
                else if(!success && completed)
                {
                    Console.WriteLine("Completed but not success"); // * Bunu yazdirmaz cunku kosul gerceklesmemistir *
                }
            }

            // * Iliskisel operatorler (==,!=, <, >, >=,<=) *
            Console.WriteLine("\n* Iliskisel operatorler (==,!=, <, >, >=,<=) * ");

            int k = 2;
            int l = 3;
            int m = 4;
            int n = 2;

            if(k==n)
                Console.WriteLine("k = n"); // * Bunu yazdirir kosul gerceklesmistir *

            if(k!=l)
                Console.WriteLine("k != l"); // * Bunu yazdirir kosul gerceklesmistir *
            
            if(k<=n)
                Console.WriteLine("k <= n"); // * Bunu yazdirir kosul gerceklesmistir *

            if(k<=l)
                Console.WriteLine("k <= l"); // * Bunu yazdirir kosul gerceklesmistir *

            if(m>=k)
                Console.WriteLine("m >= k"); // * Bunu yazdirir kosul gerceklesmistir *
            
            if(k<l)
                Console.WriteLine("k < l"); // * Bunu yazdirir kosul gerceklesmistir *
            
            if(m>l)
                Console.WriteLine("m > l"); // * Bunu yazdirir kosul gerceklesmistir *

            // * Aritmetik operatorler (+, -, *, /, %, ++, --)  *
            Console.WriteLine("\n* Aritmetik operatorler (+, -, *, /, %, ++, --) * ");
            int a = 3;
            int b = 3;
            int c = 0;
            c = a+b;
            Console.WriteLine("a+b = " + c); // * Ciktisi 6 *
            c = a-b;
            Console.WriteLine("a-b = " + c); // * Ciktisi 0 *
            c = a*b;
            Console.WriteLine("a*b = " + c); // * Ciktisi 9 *
            c = a/b;
            Console.WriteLine("a/b = " + c); // * Ciktisi 1 *
            c=a%b;
            Console.WriteLine("a%b = " + c); // * Ciktisi 0 *
            c=++a;
            Console.WriteLine("a++ = " + c); // * Ciktisi 4 *
            c=--b;
            Console.WriteLine("b-- = " + c); // * Ciktisi 2 *
            
        }
    }
}
