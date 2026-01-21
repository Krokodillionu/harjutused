namespace Meetodi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                * kirjuta programm mis
                * küsib kasutajalt tema lemmikfilme, küsimine ise on meetodiga, meetodi tulemus tagastatakse muutujasse
                * küsib kasutajalt pealse seda tema lemmikfilmi, vastus hoitakse muutujas
                * programm kontrollib meetodiga, kas lemmikfilm asub kasutaja poolt sisestatud filmide hulgas
                * kui ei ole, siis küsitakse, kus sinu lemmikfilm?
                * kui on siis öeldakse Näe mäletasid ikka!
                * programm küsib kasutajalt kas talle meeldib film X (programmeerija otsustab)
                * Kui jah siis, lisatakse film järjendisse
                * kui ei vingub programm vastu "aga see on ju hea film?"
                * on olemas kindlate filmide tuvastusmeetod, mis otsib, kas järjendis on "Terminator", "Vanamehe Film" või "Kratt"
                * Erinevate filmide kohta esitab meetod erineva sõnumi
                *Terminaatori kohta "Ill be back"
                *Vanamehe Filmi kohta "šnikurs"
                *Krati kohta "Vaata et ta sul tehisplära ajama ei hakka"
                */
            List<string> movies = GetMovies();
       
            
                foreach (var movie in movies)
            { 
                Console.WriteLine(movie);
            }

            Console.WriteLine("Milline on sinu lemikfilm");
            string lemmikfilm = Console.ReadLine();

            DoesFavoriteMovieExist(lemmikfilm,movies);

            Console.WriteLine("Aga kas sulle meeldiks äkki `Saw 7'");
            string lisafilm =Console.ReadLine();
            if(lisafilm == "jah")
            {
                movies.Add("Saw 7");
            }
            else
            {
                Console.WriteLine("Aga miks, see on ju hea film ???");
            }
            string message = FindFilmis(movies);
        }
        private static string FindFilmis(List<string> movies)
        {
            string foundmovies = "";

            foreach (var movie in movies)
            {
                if (movie == "Terminator")
                {
                    foundmovies += "Ill be back. \n";
                }
                if (movie == "Vanamehe Film")
                {
                    foundmovies += "Šnikurš!!";
                }
                if (movie == "Kratt \n")
                {
                    foundmovies += "Vaasta et tehisplära ajama eri hakka...";
                }
                return foundmovies;
            }

            return foundmovies;
        }
        private static void DoesFavoriteMovieExist(string? lemmikfilm, List<string> movies)
        {
            bool doesItExistInList = false;
            for (int i = 0; i < movies.Count; i++)
            {
                if (lemmikfilm == movies[i])
                {
                    doesItExistInList = true;
                    break;
                }
                if (doesItExistInList == true)
                {
                    Console.WriteLine("Näe mäletsid ikka!");
                }
                else
                {
                    Console.WriteLine("Aga kus sinu lemmikfilm?");
                }
            }
        }
        


        public static List<string> GetMovies()
        {
            var movies = new List<string>();

            string sisestus = "";
            while (sisestus != "ei ole")
            {
                Console.WriteLine("Palun sisesta järgmine film, kui rohkem ei ole, siis kirujata \"ei ole\"");
                sisestus = Console.ReadLine();
                if (sisestus != "ei ole")
                {
                    movies.Add(sisestus);
                }
                
            }
            return movies;
        }
    }
}
