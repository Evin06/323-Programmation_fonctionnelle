using System;
using System.Linq;
using System.Collections.Generic;

namespace Marcher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> Product = new List<Product>
            {
            new Product { Location = 1, Producer = "Bornand", ProductName = "Pommes", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 1, Producer = "Bornand", ProductName = "Poires", Quantity = 16,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 1, Producer = "Bornand", ProductName = "Pastèques", Quantity = 14,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 1, Producer = "Bornand", ProductName = "Melons", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 2, Producer = "Dumont", ProductName = "Noix", Quantity = 20,Unit = "sac", PricePerUnit = 5.50 },
            new Product { Location = 2, Producer = "Dumont", ProductName = "Raisin", Quantity = 6,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 2, Producer = "Dumont", ProductName = "Pruneaux", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 2, Producer = "Dumont", ProductName = "Myrtilles", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 2, Producer = "Dumont", ProductName = "Groseilles", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Pêches", Quantity = 8,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Haricots", Quantity = 6,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Courges", Quantity = 18,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Tomates", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Pommes", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 4, Producer = "Barizzi", ProductName = "Poires", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 4, Producer = "Barizzi", ProductName = "Pastèques", Quantity = 6,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 4, Producer = "Barizzi", ProductName = "Melons", Quantity = 14,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 4, Producer = "Barizzi", ProductName = "Noix", Quantity = 20,Unit = "sac", PricePerUnit = 5.50 },
            new Product { Location = 4, Producer = "Barizzi", ProductName = "Raisin", Quantity = 15,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 5, Producer = "Blanc", ProductName = "Pruneaux", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 5, Producer = "Blanc", ProductName = "Myrtilles", Quantity = 18,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 5, Producer = "Blanc", ProductName = "Groseilles", Quantity = 10,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 5, Producer = "Blanc", ProductName = "Pêches", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 5, Producer = "Blanc", ProductName = "Haricots", Quantity = 9,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 6, Producer = "Repond", ProductName = "Courges", Quantity = 12,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 6, Producer = "Repond", ProductName = "Tomates", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 6, Producer = "Repond", ProductName = "Pommes", Quantity = 15,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 6, Producer = "Repond", ProductName = "Poires", Quantity = 18,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 6, Producer = "Repond", ProductName = "Pastèques", Quantity = 7,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 7, Producer = "Mancini", ProductName = "Pêches", Quantity = 10,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 7, Producer = "Mancini", ProductName = "Haricots", Quantity = 11,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 7, Producer = "Mancini", ProductName = "Courges", Quantity = 10,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 7, Producer = "Mancini", ProductName = "Tomates", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 7, Producer = "Mancini", ProductName = "Pommes", Quantity = 14,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 8, Producer = "Favre", ProductName = "Poires", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 8, Producer = "Favre", ProductName = "Pastèques", Quantity = 5,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 8, Producer = "Favre", ProductName = "Haricots", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 8, Producer = "Favre", ProductName = "Courges", Quantity = 17,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 8, Producer = "Favre", ProductName = "Tomates", Quantity = 9,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 9, Producer = "Bovay", ProductName = "Pommes", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 9, Producer = "Bovay", ProductName = "Poires", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 9, Producer = "Bovay", ProductName = "Pastèques", Quantity = 20,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 9, Producer = "Bovay", ProductName = "Melons", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 9, Producer = "Bovay", ProductName = "Noix", Quantity = 13,Unit = "sac", PricePerUnit = 5.50 },
            new Product { Location = 10, Producer = "Cherix", ProductName = "Raisin", Quantity = 8,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 10, Producer = "Cherix", ProductName = "Pruneaux", Quantity = 19,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 10, Producer = "Cherix", ProductName = "Myrtilles", Quantity = 9,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 10, Producer = "Cherix", ProductName = "Groseilles", Quantity = 10,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 10, Producer = "Cherix", ProductName = "Pêches", Quantity = 9,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 11, Producer = "Beaud", ProductName = "Haricots", Quantity = 19,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 11, Producer = "Beaud", ProductName = "Courges", Quantity = 16,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 11, Producer = "Beaud", ProductName = "Tomates", Quantity = 18,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 11, Producer = "Beaud", ProductName = "Pommes", Quantity = 8,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 11, Producer = "Beaud", ProductName = "Poires", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 12, Producer = "Corbaz", ProductName = "Pastèques", Quantity = 15,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 12, Producer = "Corbaz", ProductName = "Melons", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 12, Producer = "Corbaz", ProductName = "Noix", Quantity = 11,Unit = "sac", PricePerUnit = 5.50 },
            new Product { Location = 12, Producer = "Corbaz", ProductName = "Raisin", Quantity = 16,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 12, Producer = "Corbaz", ProductName = "Pruneaux", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 13, Producer = "Amaudruz", ProductName = "Myrtilles", Quantity = 18,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 13, Producer = "Amaudruz", ProductName = "Groseilles", Quantity = 19,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 13, Producer = "Amaudruz", ProductName = "Pêches", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 13, Producer = "Amaudruz", ProductName = "Haricots", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 13, Producer = "Amaudruz", ProductName = "Courges", Quantity = 7,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 14, Producer = "Bühlmann", ProductName = "Tomates", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 14, Producer = "Bühlmann", ProductName = "Pommes", Quantity = 17,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 14, Producer = "Bühlmann", ProductName = "Poires", Quantity = 7,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 14, Producer = "Bühlmann", ProductName = "Pastèques", Quantity = 11,Unit = "pièce", PricePerUnit = 5.50 },
            new Product { Location = 14, Producer = "Bühlmann", ProductName = "Melons", Quantity = 7,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 15, Producer = "Crizzi", ProductName = "Noix", Quantity = 10,Unit = "sac", PricePerUnit = 5.50 },
            new Product { Location = 15, Producer = "Crizzi", ProductName = "Raisin", Quantity = 17,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 15, Producer = "Crizzi", ProductName = "Pruneaux", Quantity = 18,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 15, Producer = "Crizzi", ProductName = "Myrtilles", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
            new Product { Location = 15, Producer = "Crizzi", ProductName = "Groseilles", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 }
            };

            var i18n = new Dictionary<string, string>()
            {
                { "Pommes","Apples"},
                { "Poires","Pears"},
                { "Pastèques","Watermelons"},
                { "Melons","Melons"},
                { "Noix","Nuts"},
                { "Raisin","Grapes"},
                { "Pruneaux","Plums"},
                { "Myrtilles","Blueberries"},
                { "Groseilles","Berries"},
                { "Tomates","Tomatoes"},
                { "Courges","Pumpkins"},
                { "Pêches","Peaches"},
                { "Haricots","Beans"}
            };

            //Exercice 1 Chiffre d’affaire international anonyme

            IEnumerable<(string produc, string Product, double CA)> transformedProducts = Product.Select(p => (
               produc: $"{p.Producer.Substring(0, 3)}...{p.Producer.Last()}",
               Product: i18n[p.ProductName],
               CA: p.Quantity * p.PricePerUnit
           ));
            Console.WriteLine("\nExercice 1");
            Console.WriteLine("Seller\tProduct\tCA");
            foreach (var item in transformedProducts)
            {
                Console.WriteLine($"{item.produc},{item.Product},{item.CA}");
            }

            //Exercice 2: À partir du résultat précédent, déterminer et afficher, à l’aide d’aggrégateurs:
            //Exercice 2.0: La quantité de groseilles disponibles sur le marché
            int totalBerries = Product
                            .Where(p => p.ProductName == "Groseilles")
                            .Sum(p => p.Quantity);

            Console.WriteLine("\nExercice 2.0:");
            Console.WriteLine($"Totale de groseilles : {totalBerries} kg");

            //Exercice 2.1: Le chiffre d’affaire possible total pour chaque marchand (tout produit confondu)
            var totalCAByProducer = Product
                            .GroupBy(p => p.Producer)  
                            .Select(g => new
                            {
                                Producer = g.Key,
                                TotalCA = g.Sum(p => p.Quantity * p.PricePerUnit) 
                            });

            Console.WriteLine("\nExercice 2.1: ");
            foreach (var item in totalCAByProducer)
            {
                Console.WriteLine($"{item.Producer}, CA total: {item.TotalCA} CHF");
            }

            //Exercice 2.2: Le plus grand, le plus petit et la moyenne de ces chiffres d’affaire
            var totalCAProducer = Product
                .GroupBy(p => p.Producer)
                .Select(g => new
                {
                    Producer = g.Key,
                    TotalCA = g.Sum(p => p.Quantity * p.PricePerUnit)
                });

            double maxCA = totalCAProducer.Max(p => p.TotalCA);
            double minCA = totalCAProducer.Min(p => p.TotalCA);
            double avgCA = totalCAProducer.Average(p => p.TotalCA);

            Console.WriteLine("\nExercice 2.2:");
            Console.WriteLine($"CA maximum : {maxCA} CHF");
            Console.WriteLine($"CA minimum : {minCA} CHF");
            Console.WriteLine($"CA moyen : {avgCA} CHF");


            //Exercice 2.3:Le marchand ayant le plus de noix à vendre
            // Exercice 2.3: Le marchand ayant le plus de noix à vendre

            var topNutSeller = Product
                .Where(p => p.ProductName == "Noix") 
                .OrderByDescending(p => p.Quantity)  
                .FirstOrDefault();

            Console.WriteLine("\nExercice 2.3:");
            Console.WriteLine($"Le marchant ayent le plus de noix {topNutSeller} CHF");

        }

    }
}