
using System;

namespace BankObjektowe
{
    internal class kontoBankowe
    {
        private decimal _saldo;
        private string _nrKonta;

        // Historia wpłat bez używania List
        private decimal[] historiaWplat = new decimal[100];
        private int liczbaWplat = 0;

        public decimal Saldo
        {
            get { return _saldo; }
        }

        public string NrKonta
        {
            get { return _nrKonta; }
        }

        public kontoBankowe()
        {
            _nrKonta = NumerKonta();
            _saldo = 0;

            Console.WriteLine("Konto zostalo utworzone.");
        }

        private string NumerKonta()
        {
            Random random = new Random();

            string numerKonta = "";

            for (int i = 0; i < 10; i++)
            {
                numerKonta += random.Next(0, 10);
            }

            return numerKonta;
        }

        public void stanKonta()
        {
            Console.WriteLine("Saldo: " + _saldo + " zl");
            Console.WriteLine("Numer: " + _nrKonta);
        }

        public void Wplac(decimal kwota)
        {
            if (kwota > 0 && liczbaWplat < historiaWplat.Length)
            {
                _saldo += kwota;

                historiaWplat[liczbaWplat] = kwota;
                liczbaWplat++;
            }
        }

        public void Wyplac(decimal kwota)
        {
            if (kwota <= 0 || kwota > _saldo)
            {
                Console.WriteLine($"[Konto] Wypłata {kwota} zł nie udała się (brak środków lub zła kwota). Saldo: {_saldo} zł.");
            }
            else
            {
                _saldo -= kwota;
                Console.WriteLine($"[Konto] Wypłacono {kwota} zł. Pozostałe saldo: {_saldo} zł.");
            }
        }

        public void PokazHistorie()
        {
            Console.WriteLine("\nHistoria wplat:");

            Console.WriteLine("Liczba wplat: " + liczbaWplat);

            decimal suma = 0;

            for (int i = 0; i < liczbaWplat; i++)
            {
                Console.WriteLine(
                    (i + 1) + ". " +
                    historiaWplat[i] + " zl"
                );

                suma += historiaWplat[i];
            }

            Console.WriteLine("Suma wplat: " + suma + " zl");
        }
    }
}
