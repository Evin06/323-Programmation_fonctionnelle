using System;
using System.Linq;
using System.Collections.Generic;

namespace Marcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };
            List<string> wordList = words.Where(w => !w.Contains('x')).ToList();
            Console.WriteLine(wordList);

        }
    }
}