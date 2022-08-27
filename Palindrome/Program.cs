using System;
using System.Collections.Generic;


namespace Palindrome
{
    class PalindromSubstring
    {
        //Determines if the given string is palindrome by considering that the left and right of every palindrome substring is equal
        public static void checkPalindrome(string str, int left, int right, HashSet<string> set)
        {
            while ((left >= 0 && right < str.Length) && (str[left] == str[right]))
            {
                set.Add(str.Substring(left, right + 1 - left));
                left--;
                right++;
            }
        }

        // Optimized method
        public static void extractAllSubstrings(string str)
        {
            var set = new HashSet<string>();
            for (int i = 0; i < str.Length; i++)
            {
                // Determines the even lenght palindrome substring
                PalindromSubstring.checkPalindrome(str, i, i, set);
                // Determines the odd lenght palindrome substring
                PalindromSubstring.checkPalindrome(str, i, i + 1, set);
            }
            Console.WriteLine("\nPalindromes: ");
            Console.WriteLine(string.Join(", ", set));
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Extracts All the Palindrome From a Given String");
            Console.WriteLine("-----------------------------------------------\n");
            Console.WriteLine("Enter a String: ");
            var input = Console.ReadLine();
            PalindromSubstring.extractAllSubstrings(input);
        }
    }
}