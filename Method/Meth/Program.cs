namespace Meth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Programm küsib kasutajalt reahaaval luuletuse ridu, küsitakse 4 korda ja kontrollitakse, kas kasutaja on sisestanud keelatud sõnu, keelatud sõnad ise asuvad loendis, kui kasutaja on sisestanud keelatud sõnu, küsitakse kogu rida kasutajalt uuesti.
            Kui küsimus on lõppend, küsitakse kasutajalt failinime ja luuletus salvestatakse faili.
            */
            int riduOlemas = 0;
            string olemasolevSisu = "";
            while (riduOlemas < 4)
            {
                Console.WriteLine("Luuletuse järgmise rea sisestuseks kirjuta midagi, salvesta see oma faili, ja vaata oma luuletus hiljem üle");
                List<string> keelatudSõnad = new List<string>() { "fuck", "nigger", "faggot", "alkohoolik" };
                string hetkesisestus = "";
                while (hetkesisestus == "")
                {
                foreach (var ks in keelatudSõnad)
                {
                        hetkesisestus = ReadAnswer(); 
                    if (hetkesisestus.Contains(ks))
                    {
                        hetkesisestus = "";
                        Console.WriteLine("On leitud keelatud sõna, sisestus on tühistatud");
                    }
                
                    
                 }
                
                }

                
                
                olemasolevSisu += ReadAnswer();
            }
            Console.WriteLine("Sisesta failinimi, kuhu soovid oma luuletuse salvestada");
            string failinimi = ReadAnswer();
            string filePath ="\"C:\\Users\\opilane\\source\\repos\\IKTpe25_1\\Materjal\\Operation\\" + failinimi + ".txt";
            File.WriteAllText(filePath, olemasolevSisu);
            DisplayLuuletus(filePath);
        }
        public static void DisplayLuuletus(string location)
        {
            using (StreamReader readLuuletus = new StreamReader(location))
            {
                while (readLuuletus.EndOfStream == false)
                {
                    Console.WriteLine(readLuuletus.ReadLine());
                }
                readLuuletus.Close();
            }
        }

        public static string ReadAnswer()
        {
            string vastus = "";
            while (vastus == "")
            {
                Console.WriteLine("Tee vastav sisestus");
                vastus = Console.ReadLine();
            }

            return vastus;
        }
    }
}
