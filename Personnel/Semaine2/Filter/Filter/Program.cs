namespace Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };
            words
                .Where(w => !w
                .Contains("o"))
                .ToList()
                .ForEach(w1 => Console
                .Write($"{w1}, "));

            Console.WriteLine();

            words.Where(w => w.Length >= 6).ToList().ForEach(w1 => Console.Write($"{w1}, "));
            Console.WriteLine();

            words.Where(w => w.Length == words.Average(w1 => w1.Length)).ToList().ForEach(w1 => Console.Write($"{w1}, "));

            Console.Read();
        }
    }
}
