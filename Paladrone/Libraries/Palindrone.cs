﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libraries
{
    public class Palindrome
    {
        private string str;

        public Palindrome()
        {
            str = ""; // empty string
        }

        public Palindrome(string s)
        {
            str = s;
        }

        public bool isPalindrome()
        {
            
            string s = str.Replace(" ", "").ToLower(); // remove all whitespace and convert to lowercase
            var test = new StringBuilder();
            foreach (char c in s) // remove all punctuations
            {
                if (!char.IsPunctuation(c))
                {
                    test.Append(c);
                }
            }
            s = test.ToString();

            // Testing out the regex class
            var r = new Regex(@"\p{P}");
            str = r.Replace(str, ""); // removes all of the punctuation marks, still need to remove all of the spaces


            for (int i = 0, j = s.Count() - 1; i <= j; i++, j--)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
