
using System;

namespace BankObjektowe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            kontoBankowe k1 = new kontoBankowe();
            Automat automat = new Automat();

            automat.WrzucMonety(k1,"5 2 0.5 abc 3 5 7 2 2 2 1");

            k1.stanKonta();

            k1.Wyplac(20);

            k1.PokazHistorie();

            automat.PokazMonety();
        }
    }
}
