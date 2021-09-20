using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Enter a word to search.");
            string input = Console.ReadLine();
            if (alice.ToLower().IndexOf(input.ToLower()) >= 0)
            {
                Console.WriteLine("true");
                Console.WriteLine("Index of word is " + alice.IndexOf(input));
                Console.WriteLine("Length of word is " + input.Length);
                alice = alice.ToLower().Replace(input.ToLower(), "");
                Console.WriteLine(alice);
            } else
            {
                Console.WriteLine("false");
            }
        }
    }
}
