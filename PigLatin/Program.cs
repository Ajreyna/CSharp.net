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
           

            ToPigLatin_V2(input);
            Console.Read();
        }

        //Console.WriteLine("Would you like to enter a word?");
    //String ans = Console.ReadLine().ToLower();
    //while (ans == ("y" & "Y")
        

        // ToPigLatin_V1 returns the converted word"
        public static string ToPigLatin_V1(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int firstVowelPosition = word.IndexOfAny(vowels);
            if (firstVowelPosition == -1)  
            {
                return (word + "ay");
            }
            else
            {
                char firstLetter = word[0]; 
                char lastLetter = word[word.Length - 1]; 
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
       
        public static void ToPigLatin_V2(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int firstVowelPosition = word.IndexOfAny(vowels);
            if (firstVowelPosition == -1)  
            {
                Console.WriteLine(word + "ay");

            else
            {
                char firstLetter = word[0]; 
                char lastLetter = word[word.Length - 1]; 
                if (vowels.Contains(firstLetter) && vowels.Contains(lastLetter))
                {
                    Console.WriteLine(word + "yay");
                    // You can also do this
                    // Console.WriteLine($"{word}yay");
                }
                else
                {
                   
                    string firstHalf = word.Substring(0, firstVowelPosition);
                    string secondHalf = word.Substring(firstVowelPosition);
                    Console.WriteLine(secondHalf + firstHalf + "ay");

                    
                }

            }
        }

       // Console.WriteLine("Would you like to go again?")
    } 
}
