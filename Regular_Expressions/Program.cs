// See https://aka.ms/new-console-template for more information

using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Program
    {
        private static void showMatch(string text, string expression)
        {
            var regex = new Regex(expression);
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }


        static void Main(string[] args)
        {
            string text = "A regular expression is a special sequence of characters that helps you match or find other strings or sets of strings, using a specialized syntax held in a pattern.";
            Console.WriteLine("Matching words that start with 'r':");
            
            showMatch(text, @"\bm\S*e\b");
            Console.WriteLine("Matching words that start with 's':");
        }
    }
}