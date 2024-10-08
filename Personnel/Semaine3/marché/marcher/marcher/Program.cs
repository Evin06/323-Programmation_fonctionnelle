using System;  // Importation de l'espace de noms pour l'utilisation des classes de base comme Console
using System.Linq;  // Importation de LINQ pour les opérations de filtrage et d'agrégation
using System.Collections.Generic;  // Importation de l'espace de noms pour utiliser les listes et dictionnaires

namespace Marcher  // Déclaration du namespace du programme
{
    class Program  // Déclaration de la classe principale Program
    {
        static void Main(string[] args)  // Point d'entrée du programme
        {
            // Déclaration et initialisation d'une liste de produits avec leurs caractéristiques (lieu, producteur, nom, quantité, unité, prix par unité)
            List<Product> Product = new List<Product>
            {
                new Product { Location = 1, Producer = "Bornand", ProductName = "Pommes", Quantity = 20, Unit = "kg", PricePerUnit = 5.50 },
                // Suite de l'initialisation de la liste avec différents produits
            };

            // Création d'un dictionnaire pour traduire les noms de produits en anglais
            var i18n = new Dictionary<string, string>()
            {
                { "Pommes", "Apples" },
                { "Poires", "Pears" },
                { "Pastèques", "Watermelons" },
                // Suite de l'initialisation du dictionnaire de traduction
            };

            // Exercice 1: Transformation des données pour anonymiser les noms des producteurs, traduire les produits, et calculer le chiffre d'affaires (CA)
            IEnumerable<(string produc, string Product, double CA)> transformedProducts = Product.Select(p => (
               produc: $"{p.Producer.Substring(0, 3)}...{p.Producer.Last()}",  // Anonymisation du nom du producteur (3 premières lettres et dernière lettre)
               Product: i18n[p.ProductName],  // Traduction du nom du produit en anglais grâce au dictionnaire i18n
               CA: p.Quantity * p.PricePerUnit  // Calcul du chiffre d'affaires (CA) pour chaque produit
           ));

            // Affichage du résultat de l'Exercice 1
            Console.WriteLine("\nExercice 1");
            Console.WriteLine("Seller\tProduct\tCA");
            foreach (var item in transformedProducts)  // Boucle sur les résultats transformés
            {
                Console.WriteLine($"{item.produc},{item.Product},{item.CA}");  // Affichage de chaque produit avec le producteur anonymisé, le produit traduit et le CA
            }

            // Exercice 2.0: Calcul de la quantité totale de groseilles disponibles
            int totalBerries = Product
                            .Where(p => p.ProductName == "Groseilles")  // Filtrer uniquement les produits "Groseilles"
                            .Sum(p => p.Quantity);  // Calculer la somme des quantités de groseilles

            // Affichage du total de groseilles
            Console.WriteLine("\nExercice 2.0:");
            Console.WriteLine($"Totale de groseilles : {totalBerries} kg");

            // Exercice 2.1: Calcul du chiffre d'affaires total pour chaque marchand
            var totalCAByProducer = Product
                            .GroupBy(p => p.Producer)  // Regrouper les produits par producteur
                            .Select(g => new  // Sélectionner pour chaque producteur le nom et le CA total
                            {
                                Producer = g.Key,  // Nom du producteur
                                TotalCA = g.Sum(p => p.Quantity * p.PricePerUnit)  // Somme des CA pour tous les produits du producteur
                            });

            // Affichage du CA total par producteur
            Console.WriteLine("\nExercice 2.1: ");
            foreach (var item in totalCAByProducer)  // Boucle sur les résultats
            {
                Console.WriteLine($"{item.Producer}, CA total: {item.TotalCA} CHF");  // Affichage du producteur et de son CA total
            }

            // Exercice 2.2: Calcul du CA maximum, minimum et moyen parmi tous les producteurs
            var totalCAProducer = Product
                .GroupBy(p => p.Producer)  // Regrouper les produits par producteur
                .Select(g => new  // Sélectionner le nom du producteur et son CA total
                {
                    Producer = g.Key,
                    TotalCA = g.Sum(p => p.Quantity * p.PricePerUnit)
                });

            // Calcul du CA maximum
            double maxCA = totalCAProducer.Max(p => p.TotalCA);
            // Calcul du CA minimum
            double minCA = totalCAProducer.Min(p => p.TotalCA);
            // Calcul du CA moyen
            double avgCA = totalCAProducer.Average(p => p.TotalCA);

            // Affichage des résultats (CA max, min, et moyen)
            Console.WriteLine("\nExercice 2.2:");
            Console.WriteLine($"CA maximum : {maxCA} CHF");
            Console.WriteLine($"CA minimum : {minCA} CHF");
            Console.WriteLine($"CA moyen : {avgCA} CHF");

            // Exercice 2.3: Trouver le marchand ayant le plus de noix à vendre
            var topNutSeller = Product
                .Where(p => p.ProductName == "Noix")  // Filtrer les produits "Noix"
                .OrderByDescending(p => p.Quantity)  // Trier les résultats par quantité de manière décroissante
                .FirstOrDefault();  // Sélectionner le premier résultat, qui sera celui avec la plus grande quantité de noix

            // Affichage du producteur avec le plus de noix
            Console.WriteLine("\nExercice 2.3:");
            Console.WriteLine($"Le marchant ayent le plus de noix {topNutSeller} CHF");  // Affichage du producteur et son CA
        }

    }
}
