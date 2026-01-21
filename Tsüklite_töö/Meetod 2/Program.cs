using System.Diagnostics;

namespace Meetod_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float arv1 = 0;
            float arv2 = 0;
            string tehtetüüp = "";
            string uusTehe = "jah";
            while (uusTehe == "jah")
            {
                GetUserData (arv1, arv2, tehtetüüp);
                switch (tehtetüüp)
                {
                    case "+":
                        Liida(arv1, arv2);
                        break;
                    case "-":
                        Lahuta(arv1, arv2);
                        break;
                    case "*":
                        Korrutta(arv1, arv2);
                        break;
                    case "/":
                        Jaga(arv1, arv2);
                        break;
                    default:
                        Console.WriteLine("Ei tunne tehtetüüpi");
                        break;

                }
            }
        }
        private static double Liida (float arv1, float arv2)
        {
            return arv1 + arv2;
        }
        private static double Lahuta(float arv1, float arv2)
        {
            return arv1 - arv2;
        }
        private static double Korrutta(float arv1, float arv2)
        {
            return arv1 * arv2;
        }
        private static double Jaga(float arv1, float arv2)
        {
            return arv1 / arv2;
        }
        private static void GetUserData(float arv1, float arv2, string tehtetüüp)
        {
            while (arv1 == 0)
            {
                Console.WriteLine("Palun sisessta esimine arv");
                arv1 = int.Parse(Console.ReadLine());
            }
            while (arv2 == 0)
            {
                Console.WriteLine("Palun sisesta teine arv");
                    arv2 == float.Parse(Console.ReadLine());
            }
        }

    }
}
