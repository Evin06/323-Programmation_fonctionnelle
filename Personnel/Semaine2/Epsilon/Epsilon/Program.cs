namespace Epsilon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char, double> Frequency = new Dictionary<char, double>
        {
            { 'a', 8.15 },
            { 'b', 0.97 },
            { 'c', 3.15 },
            { 'd', 3.55 },
            { 'e', 17.38 },
            { 'f', 1.06 },
            { 'g', 0.97 },
            { 'h', 0.77 },
            { 'i', 7.24 },
            { 'j', 0.61 },
            { 'k', 0.05 },
            { 'l', 5.49 },
            { 'm', 2.96 },
            { 'n', 7.09 },
            { 'o', 5.26 },
            { 'p', 3.01 },
            { 'q', 0.89 },
            { 'r', 6.46 },
            { 's', 7.90 },
            { 't', 7.26 },
            { 'u', 6.24 },
            { 'v', 1.83 },
            { 'w', 0.05 },
            { 'x', 0.45 },
            { 'y', 0.30 },
            { 'z', 0.12 }

        };
            List<string> words = new List<string> { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };



            double CalculateEpsilon(string word)
            {
                return word
                    .GroupBy(c => c)
                    .ToDictionary(g => g.Key, g => g.Count())
                    .Sum(c => c);
            }

        }


    }
}
