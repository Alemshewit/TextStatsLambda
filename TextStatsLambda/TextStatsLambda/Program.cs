using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStats("Create a function which takes an string parameter and prints " +
                       "\nout the words in reverse order. In Main, call your function. " +
                       "\nModify your Yodaizer to check to see the number of words in the sentence.");
            Console.ReadKey();
        }

        static void TextStats(string input)
        {
            //take the input string argument and store in string
            string userInput = input;
            //take the string array and count each character using .Length
            Console.WriteLine("Number of Chara " + userInput.Length);
            //select the letters in userInput where the vowels"aeiou contain the current letter in the string and count
            Console.WriteLine("Number of vowels " + userInput.Where(x => "aeiou".Contains(x)).Count());
            //check to see if the current character in the string is contained in the string ",!?. /\" and count
            Console.WriteLine("Number of special Chara " + userInput.Where(x => ",!?./ ".Contains(x)).Count());
            //select characters where the current string isn't a vowel or a character
            Console.WriteLine("Number of consonants " + userInput.Where(x => !"aeiou.?, ".Contains(x)).Count());
            //split the string by space and count the words
            Console.WriteLine("Number of words " + userInput.Split(' ').Count());
            //split the string by space and order by length going down from the longest to the shortest and get the first word
            Console.WriteLine("Longest Word " +userInput.Split(' ').OrderByDescending(x => x.Length).First());
            //split the string by space and order by length from the shortest to the longest, and get the first word 
            Console.WriteLine("Shortest Word " + userInput.Split(' ').OrderBy(x => x.Length).First());
        
        }
    }
}