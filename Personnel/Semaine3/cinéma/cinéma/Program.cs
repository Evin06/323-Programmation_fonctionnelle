namespace cinéma
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            List<Movie> frenchMovies = new List<Movie>() {
            new Movie() { Title = "Le fabuleux destin d'Amélie Poulain", Genre = "Comédie", Rating = 8.3, Year = 2001, LanguageOptions = new string[] {"Français", "English"}, StreamingPlatforms = new string[] {"Netflix", "Hulu"} },
            new Movie() { Title = "Intouchables", Genre = "Comédie", Rating = 8.5, Year = 2011, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix", "Amazon"} },
            new Movie() { Title = "The Matrix", Genre = "Science-Fiction", Rating = 8.7, Year = 1999, LanguageOptions = new string[] {"English", "Español"}, StreamingPlatforms = new string[] {"Hulu", "Amazon"} },
            new Movie() { Title = "La Vie est belle", Genre = "Drame", Rating = 8.6, Year = 1946, LanguageOptions = new string[] {"Français", "Italiano"}, StreamingPlatforms = new string[] {"Netflix"} },
            new Movie() { Title = "Gran Torino", Genre = "Drame", Rating = 8.2, Year = 2008, LanguageOptions = new string[] {"English"}, StreamingPlatforms = new string[] {"Hulu"} },
            new Movie() { Title = "La Haine", Genre = "Drame", Rating = 8.1, Year = 1995, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix"} },
            new Movie() { Title = "Oldboy", Genre = "Thriller", Rating = 8.4, Year = 2003, LanguageOptions = new string[] {"Coréen", "English"}, StreamingPlatforms = new string[] {"Amazon"} }
            };
            

            // Version 1
            // 1. Filtrer les films qui ne sont pas du genre "Comédie" or "Drame".
            frenchMovies
                        .Where(g => g.Genre != "Comédie" && g.Genre != "Drame")
                        .ToList()    
                        .ForEach(movie => Console.WriteLine($"{movie.Title}"));
           
            //2. Identifier les films dont le rating est inférieur à 7.
            frenchMovies 
                        .Where(r => r.Rating <= 7)
                        .ToList()
                        .ForEach(movie => Console.WriteLine(movie.Title));

            
            //3. Afficher les films réalisés avant 2000.
            frenchMovies 
                         .Where(a => a.Year <= 2000)
                         .ToList()
                         .ForEach(movie => Console.WriteLine(movie.Title));
            
            //4.Trouver les films qui n'ont pas de doublage en français.
            frenchMovies
                         .Where(d => !d.LanguageOptions.Contains("Français"))
                         .ToList()
                         .ForEach(movie => Console.WriteLine(movie.Title));

            //5.Identifier les films non présents sur netflix
            frenchMovies
                         .Where(n => !n.StreamingPlatforms.Contains("netflix"))
                         .ToList()
                         .ForEach(movie => Console.WriteLine(movie.Title));
            
            //Version 2
            //Réaliser désormais un filtre qui cumule tous les filtres précédents sur le cinéma.
            frenchMovies
                        .Where(c => (c.Genre != "Comédie" && c.Genre != "Drame")
                                && c.Rating >= 7                                  
                                && c.Year <= 2000                                 
                                && !c.LanguageOptions.Contains("Français")        
                                && !c.StreamingPlatforms.Contains("Netflix"))    
                        .ToList()
                        .ForEach(movie => Console.WriteLine(movie.Title));


        }
    }
}
