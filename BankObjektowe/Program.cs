namespace BankObjektowe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            kontoBankowe kontoBankowe = new kontoBankowe();
            Automat automat = new Automat();
            automat.WrzuczMonete(kontoBankowe, "0,5");
            kontoBankowe.stanKonta();
            kontoBankowe.Wplac(100);
            kontoBankowe.stanKonta();
        }
    }
}
