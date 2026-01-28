namespace FileOterration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

                Programm küsib kasutajalt reahaaval luuletuse ridu, küsitakse 4 korda ja kontrollitakse kas kasutaja on sisestanud
                keelatud sõnu, keelatud sõnad ise asuvad loendis, kui kasutaja on sisestanud keelatud sõnu, küsitakse kogu rida kasutajalt uuesti.
                Kui küsimine on lõppenud, küsitakse kasutajalt failinime, ja luuletus salvestatakse faili
                Pärast salvestust kuvatakse failisisu kasutajale tagasi

                 */

            Console.WriteLine("Sisestams oma luulutes,salvesta see faili ning kuva omaluulutes tagasi");
            int riduOlemas = 0;
            string olemasolevSisu = "";
            while (riduOlemas < 4)
            {
                Console.WriteLine("Sisesta" + (riduOlemas + 1) + "rida");
                List<string> keelatudSõnad = new List<string>() { "nahui", "fuck", "perrse", "joodik" };
                string reasisestus = "";

                while (reasisestus == "")
                {
                    reasisestus = ReadAnswer();
                    foreach (var sõna in keelatudSõnad)
                    {
                        {
                            reasisestus = "";
                            Console.WriteLine("On leitud keelatud sõna, sisestus tähistatud, proovi uuesti");
                        }
                    }
                }
                olemasolevSisu += (reasisestus + "\n");
                riduOlemas++;
            }
            string filePath = "C:\\Users\\opilane\\source\\repos\\IKTpe25_1\\harjutused\\Method\\FileOterration";
            SaveLuuletus(olemasolevSisu, filePath);

        }
        public static void SaveLuuletus(string content, string location)
        {
            Console.WriteLine("Kirjuta failinimi kuhu soovid oma luuletuse salvesada");
            string failinimi = ReadAnswer();
            string combinedPath = location + failinimi + ".txt";
            File.WriteAllText(combinedPath, content);
            Console.WriteLine("Salvestaid fail sellise sinu:");
            DisplayLuuletus(combinedPath);
        }
        public static void DisplayLuuletus(string location)
        {
            using (StreamReader readfile = new StreamReader(location))
            {
                while (readfile.EndOfStream == false)
                {
                    Console.WriteLine(readfile.ReadLine());
                }
                readfile.Close();
            }
        }
        public static string ReadAnswer()
        {
            string answer = "";
            while (answer == "")
            {
                Console.WriteLine("Tee sisestus");
                answer = Console.ReadLine();
            }
            return answer;
        }
    }
}
