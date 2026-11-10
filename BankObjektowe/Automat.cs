using System;

namespace BankObjektowe
{
    internal class Automat
    {
        private decimal[] nominaly = { 0.1m, 0.2m, 0.5m, 1, 2, 5 };
        private int[] iloscMonet = { 0, 0, 0, 0, 0, 0 };

        public void WrzuczMonete(kontoBankowe konto, string moneta)
        {
            string poprawiona = moneta.Replace('.', ',');

            if (!decimal.TryParse(poprawiona, out decimal wartosc))
            {
                Console.WriteLine("nieudany odczyt");
                return;
            }
              
            bool znaleziono = false;

            for (int i = 0; i < nominaly.Length; i++)
            {
                if (wartosc == nominaly[i])
                {
                    iloscMonet[i]++;       
                    konto.Wplac(wartosc); 
                    Console.WriteLine("moneta dobra");
                    znaleziono = true;
                    break;
                }
            }

            if (!znaleziono)
            {
                Console.WriteLine("zła moneta");
            }
        }

        public void PokazMonety()
        {
            Console.WriteLine("Monety w automacie:");
            for (int i = 0; i < nominaly.Length; i++)
            {
                Console.WriteLine(nominaly[i] + " zł: " + iloscMonet[i]);
            }
        }
    }
}