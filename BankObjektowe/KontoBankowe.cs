using System;

namespace BankObjektowe
{
    internal class kontoBankowe
    {
        private decimal _saldo;
        private string _nrKonta;

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
            Console.WriteLine("Konto puste zostało utworzone.");
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
            Console.WriteLine("Saldo: " + _saldo);
            Console.WriteLine("Numer: " + _nrKonta);
        }

        public void Wplac(decimal kwota)
        {
            if (kwota > 0)
            {
                _saldo += kwota;
            }
        }
    }
}