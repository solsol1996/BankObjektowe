using System;
using System.Collections.Generic;
using System.Text;

namespace BankObjektowe
{
    internal class kontoBankowe
    {
        private decimal _saldo;
        private string _nrKonta;
        private string _właściciel;

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public kontoBankowe()
        {
            _właściciel = "nieznany";
            _nrKonta = "0000000000";
            _saldo = 0;
            Console.WriteLine("Konto puste zostało utworzone.");
        }

        public kontoBankowe(string nowyWłaściciel, string nrKonta, decimal startoweSaldo)
        {
            _właściciel = nowyWłaściciel;
            _nrKonta = nrKonta;
            _saldo = startoweSaldo;
            Console.WriteLine("Konto bankowe zostało utworzone.");
        }

        public void stanKonta()
        {
            Console.WriteLine($"Właściciel: {_właściciel}");
            Console.WriteLine($"Numer konta: {_nrKonta}");
            Console.WriteLine($"Saldo: {_saldo}");
        }


    }
}
