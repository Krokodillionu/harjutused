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
                string hetkesisestus = ReadAnswer();
                while (hetkesisestus == "")
                {
                foreach (var ks in keelatudSõnad)
                {
                    if (hetkesisestus.Contains(ks))
                    {
                        hetkesisestus = "";
                        Console.WriteLine("On leitud keelatud sõna, sisestus on tühistatud");
                    }
                
                    
                 }
                
                }

                
                
                olemasolevSisu += ReadAnswer();
            }
        }


        public static string ReadAnswer()
        {
            string vastus = "";

            return vastus;
        }
    }
}
