using System;
using System.Collections.Generic;
using System.Text;

namespace BankObjektowe
{
    internal class kontoBankowe
    {
        private decimal _saldo;
        private string _nrKonta;
        private decimal kwota;

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public kontoBankowe()
        {
            _nrKonta = "0000000000";
            _saldo = 0;
            Console.WriteLine("Konto puste zostało utworzone.");
        }

        public kontoBankowe( string nrKonta, decimal startoweSaldo)
        {
            _nrKonta = nrKonta;
            _saldo = startoweSaldo;
            Console.WriteLine("Konto bankowe zostało utworzone.");
        }

        public string NumerKonta()
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
            Console.WriteLine("----------------------");
            Console.WriteLine($"Saldo: {_saldo}");
            Console.WriteLine($"Numer konta: {NumerKonta()}");
            Console.WriteLine("----------------------");
        }

        public void Wplac(decimal kwota)
        {
            if (kwota > 0)
            {
                _saldo += kwota;
                Console.WriteLine($"Wpłacono {kwota} zł na konto.");
            }
            else
            {
                Console.WriteLine("X");
            }
        }
    }
}
