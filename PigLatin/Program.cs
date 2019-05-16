using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();
            /* Translate the word to Pig Latin
            string convertedWord = ToPigLatin_V1(input);
            Console.WriteLine(convertedWord);
            Console.Read();
            */
            ToPigLatin_V2(input);
            Console.Read();
        }

        // ToPigLatin_V1 returns the converted word"
        public static string ToPigLatin_V1(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int firstVowelPosition = word.IndexOfAny(vowels);
            if (firstVowelPosition == -1)  // if there is no vowel in the word
            {
                return (word + "ay");
            }
            else
            {
                char firstLetter = word[0]; // get the first letter of the word
                char lastLetter = word[word.Length - 1]; // get the last letter of the word
                //If a word starts with a vowel and ends in a vowel, 
                //add "yay" to the end. (olive -> oliveyay)
                if (vowels.Contains(firstLetter) && vowels.Contains(lastLetter))
                {
                    return (word + "yay");
                }
                else
                {
                    // either the first letter is not a vowel OR the last letter is not a vowel
                    // split the word into two parts at the first vowel 
                    string firstHalf = word.Substring(0, firstVowelPosition);
                    string secondHalf = word.Substring(firstVowelPosition);
                    return (secondHalf + firstHalf + "ay");
                }

            }

        }
        // End of ToPigLatin_V1

        // ToPigLatin_V2 does not return anything"
        public static void ToPigLatin_V2(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int firstVowelPosition = word.IndexOfAny(vowels);
            if (firstVowelPosition == -1)  // if there is no vowel in the word
            {
                Console.WriteLine(word + "ay");
                // You can also do this
                // Console.WriteLine($"{word}ay");
            }
            else
            {
                char firstLetter = word[0]; // get the first letter of the word
                char lastLetter = word[word.Length - 1]; // get the last letter of the word
                //If a word starts with a vowel and ends in a vowel, 
                //add "yay" to the end. (olive -> oliveyay)
                if (vowels.Contains(firstLetter) && vowels.Contains(lastLetter))
                {
                    Console.WriteLine(word + "yay");
                    // You can also do this
                    // Console.WriteLine($"{word}yay");
                }
                else
                {
                    // either the first letter is not a vowel OR the last letter is not a vowel
                    // split the word into two parts at the first vowel 
                    string firstHalf = word.Substring(0, firstVowelPosition);
                    string secondHalf = word.Substring(firstVowelPosition);
                    Console.WriteLine(secondHalf + firstHalf + "ay");

                    // You can also do this
                    // Console.WriteLine($"{secondHalf}{firstHalf}ay");
                }

            }
        }
        // End of ToPigLatin_V2

    }
}
