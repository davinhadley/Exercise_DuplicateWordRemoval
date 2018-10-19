using System;
using System.Linq;

namespace Deitel_DuplicateWordRemoval
{
    class DuplicateWordRemoval
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence without any punctuation:");
            string sentence = Console.ReadLine();
            string[] sentenceArray = sentence.Split();

            var sorted =
                from element in sentenceArray
                let lowerCase = element.ToLower()
                orderby lowerCase
                select lowerCase;

            var nonDuplicate =
                sorted.Distinct();

            Console.WriteLine("\nList of non-duplicate words in alphabetical order:");
            foreach (var item in nonDuplicate)
                Console.WriteLine(item);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
