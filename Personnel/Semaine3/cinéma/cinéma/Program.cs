namespace cinéma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'une liste de films avec des informations comme le titre, le genre, la note, l'année, les langues disponibles et les plateformes de streaming
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

            // 1. Filtrer les films qui ne sont pas du genre "Comédie" ou "Drame" et les afficher
            frenchMovies
                        .Where(g => g.Genre != "Comédie" && g.Genre != "Drame") // Condition: exclure les genres "Comédie" et "Drame"
                        .ToList()    // Conversion du résultat en liste
                        .ForEach(movie => Console.WriteLine($"{movie.Title}")); // Affichage du titre de chaque film filtré

            // 2. Identifier et afficher les films dont le rating est inférieur ou égal à 7
            frenchMovies
                        .Where(r => r.Rating <= 7) // Condition: note inférieure ou égale à 7
                        .ToList() // Conversion en liste
                        .ForEach(movie => Console.WriteLine(movie.Title)); // Affichage du titre des films correspondants

            // 3. Afficher les films réalisés avant l'an 2000
            frenchMovies
                         .Where(a => a.Year <= 2000) // Condition: année de sortie inférieure ou égale à 2000
                         .ToList() // Conversion en liste
                         .ForEach(movie => Console.WriteLine(movie.Title)); // Affichage du titre des films correspondants

            // 4. Trouver et afficher les films qui n'ont pas de doublage en français
            frenchMovies
                         .Where(d => !d.LanguageOptions.Contains("Français")) // Condition: exclure les films avec l'option de langue "Français"
                         .ToList() // Conversion en liste
                         .ForEach(movie => Console.WriteLine(movie.Title)); // Affichage du titre des films correspondants

            // 5. Identifier et afficher les films qui ne sont pas disponibles sur Netflix
            frenchMovies
                         .Where(n => !n.StreamingPlatforms.Contains("Netflix")) // Condition: exclure les films disponibles sur Netflix
                         .ToList() // Conversion en liste
                         .ForEach(movie => Console.WriteLine(movie.Title)); // Affichage du titre des films correspondants

            // Version 2

            // Filtrer et afficher les films qui répondent à toutes les conditions suivantes :
            // - Ne sont pas du genre "Comédie" ou "Drame"
            // - Ont une note supérieure ou égale à 7
            // - Ont été réalisés avant 2000
            // - N'ont pas de doublage en français
            // - Ne sont pas disponibles sur Netflix
            frenchMovies
                        .Where(c => (c.Genre != "Comédie" && c.Genre != "Drame") // Exclure "Comédie" et "Drame"
                                && c.Rating >= 7 // Note supérieure ou égale à 7
                                && c.Year <= 2000 // Films réalisés avant 2000
                                && !c.LanguageOptions.Contains("Français") // Pas de langue "Français" disponible
                                && !c.StreamingPlatforms.Contains("Netflix")) // Pas disponibles sur Netflix
                        .ToList() // Conversion en liste
                        .ForEach(movie => Console.WriteLine(movie.Title)); // Affichage du titre des films correspondants
        }
    }
}
