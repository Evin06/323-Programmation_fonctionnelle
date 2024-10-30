using System;

class Program
{
    static void Main()
    {
        int year = "Année de naissance: ".ReadInt();
        $"Vous avez {DateTime.Now.Year - year} ans".Write(ConsoleColor.Green);

        string input = "123";
        int number = input.ToIntSafe();
        Console.WriteLine($"Nombre converti : {number}");
        Console.WriteLine($"Pas un nombre, valeur par défaut : {"notANumber".ToIntSafe()}");
        Console.WriteLine($"Pas un nombre, valeur par défaut spécifique : {"notANumber".ToIntSafe(-1)}");

        var random = new Random();
        string randomStr = random.RandomString(8);
        Console.WriteLine($"Chaîne aléatoire : {randomStr}");
        bool randomBool = random.RandomBool();
        Console.WriteLine($"Booléen aléatoire: {randomBool}");

        double decimalNumber = "Entrez un nombre à virgule: ".ReadDouble();
        Console.WriteLine($"Nombre à virgule saisi : {decimalNumber}");

        DateTime date = "Entrez une date (format : dd/MM/yyyy): ".ReadDate();
        Console.WriteLine($"Date saisie : {date.ToShortDateString()}");
    }
}

public static class WriteExtensions
{
    public static void Write(this string message, ConsoleColor color)
    {
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ForegroundColor = originalColor;
    }
}
