namespace TsükliteTöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ter. Kirjuta sinu nimi?");
            string nimi = "";
            do
            {
                Console.WriteLine("Sinu nimi on:");
                nimi = Console.ReadLine();
            } while (nimi == "");

            Console.WriteLine("Sisesta parool");
            int pass = int.Parse(Console.ReadLine());

            while (pass < 1000 || pass > 9999)
            {
                Console.Write("Parol on vale, proovi uuesti: ");
                pass = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Parool on reegistreritud");

            string[] puuvilja = { "kaplsas", "porgant", "ploom", "maasikas", "banaan" };
            for (int i = 0; i < puuvilja.Length; i++) 
            {
                Console.Write((i + 1) + " " + puuvilja[i]);
            }

            Console.WriteLine("\nSee on massiiv");
            int[] arv = { 1, 2, 3, 4, 5 };
            foreach (var i in arv)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < arv.Length; i++);
            

        }
    }
}
