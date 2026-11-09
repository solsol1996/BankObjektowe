using System;

namespace BankObjektowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tworzenie konta i wrzucanie monet:");
            kontoBankowe k1 = new kontoBankowe();
            Automat auto = new Automat();

            auto.WrzuczMonete(k1, "0.5");
            auto.WrzuczMonete(k1, "2");
            auto.WrzuczMonete(k1, "3");   
            auto.WrzuczMonete(k1, "abc"); 
            auto.WrzuczMonete(k1, "5");

            Console.WriteLine("\nStan pierwszego konta:");
            k1.stanKonta();

            Console.WriteLine("\nZawartost automatu:");
            auto.PokazMonety();

            Console.WriteLine("\nTworzenie drugiego konta:");
            kontoBankowe k2 = new kontoBankowe();
            k2.stanKonta();
        }
    }
}