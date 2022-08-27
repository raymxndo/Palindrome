using System;
using System.Collections.Generic;


namespace Palindrome
{
    class PalindromicSubstring
    {
        public static void isPalindrome(string str, int left, int right, HashSet<string> set)
        {
            while ((left >= 0 && right < str.Length) && (str[left] == str[right]))
            {
                set.Add(str.Substring(left, right + 1 - left));
                left--;
                right++;
            }
        }
        public static void generateAllSubstring(string str)
        {
            var set = new HashSet<string>();
            for (int i = 0; i < str.Length; i++)
            {
                PalindromicSubstring.isPalindrome(str, i, i, set);
                // odd length palindrome
                PalindromicSubstring.isPalindrome(str, i, i + 1, set);
            }
            Console.WriteLine(string.Join(" ", set));
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String: ");
            var input = Console.ReadLine();
            PalindromicSubstring.generateAllSubstring(input);
        }
    }
}