namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int vanus = 0;

            //do
            //{
            //    Console.WriteLine("Sisesta sobilik vanus");
            //    vanus = int.Parse(Console.ReadLine());

            //} while (vanus !<= 0);
            //Console.WriteLine($"Okei, sa oled {vanus} aastat vana ");

            int aastaarv = 0;

            do
            {
                Console.WriteLine("Mis aasta on praegu?");
                aastaarv = int.Parse(Console.ReadLine());


            } while (aastaarv <= 2025 && aastaarv! <= 0);
            Console.WriteLine($"Aasta on {aastaarv} ");
        }
    }
}
