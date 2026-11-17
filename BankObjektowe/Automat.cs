using System;

namespace BankObjektowe
{
    internal class Automat
    {
        private decimal[] nominaly = { 0.1m, 0.2m, 0.5m, 1.0m, 2.0m, 5.0m };
        private int[] iloscMonet = { 0, 0, 0, 0, 0, 0 };
        private int[] pojemnosc = { 2, 2, 2, 2, 2, 2 };

        public void WrzucMonety(kontoBankowe konto, string monety)
        {
            string[] listaMonet = monety.Split(' ');

            int przyjete = 0;
            int zwrocone = 0;

            foreach (string moneta in listaMonet)
            {
                if (moneta != "")
                {
                    if (!decimal.TryParse(moneta.Replace('.', ','), out decimal wartosc))
                    {
                        Console.WriteLine(moneta + " - nieudany odczyt");
                        zwrocone++;
                    }
                    else
                    {
                        int indeks = -1;

                        for (int i = 0; i < nominaly.Length; i++)
                        {
                            if (wartosc == nominaly[i])
                            {
                                indeks = i;
                                break;
                            }
                        }

                        if (indeks == -1)
                        {
                            Console.WriteLine(moneta + " - zly nominal");
                            zwrocone++;
                        }
                        else if (iloscMonet[indeks] >= pojemnosc[indeks])
                        {
                            Console.WriteLine(moneta + " - brak miejsca, moneta zwrocona");
                            zwrocone++;
                        }
                        else
                        {
                            iloscMonet[indeks]++;
                            konto.Wplac(wartosc);

                            Console.WriteLine(moneta + " - moneta przyjeta");
                            przyjete++;
                        }
                    }
                }
            }

            Console.WriteLine("\nPodsumowanie:");
            Console.WriteLine("Przyjete monety: " + przyjete);
            Console.WriteLine("Zwrocone monety: " + zwrocone);
        }

        public void PokazMonety()
        {
            Console.WriteLine("\nMonety w automacie:");

            for (int i = 0; i < nominaly.Length; i++)
            {
                Console.WriteLine(
                    nominaly[i] + " zl: " +
                    iloscMonet[i] + "/" + pojemnosc[i]
                );
            }
        }
    }
}