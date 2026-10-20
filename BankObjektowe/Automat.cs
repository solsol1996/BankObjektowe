using System;
using System.Collections.Generic;
using System.Text;

namespace BankObjektowe
{
    internal class Automat
    {
        private int _iloscMonet;
        private readonly decimal[] _przejmowanyMonety = new decimal[] { 0.1m, 0.2m, 0.5m, 1m, 2m, 5m };

        public void WrzuczMonete(kontoBankowe konto, string moneta)
        {
            bool czyPoprawna = decimal.TryParse(moneta, out decimal wartoscMonet);
            if (!czyPoprawna)
            {
                Console.WriteLine($"Nieudany odrzut monety.");
                return;
            }
            Console.WriteLine($"Wrzucono monetę o wartości {wartoscMonet} zł.");

            foreach (decimal nominal in _przejmowanyMonety)
            {
                if (wartoscMonet == nominal)
                {
                    konto.Saldo += nominal;
                    _iloscMonet++;
                }
            }
        }
    }
}
 