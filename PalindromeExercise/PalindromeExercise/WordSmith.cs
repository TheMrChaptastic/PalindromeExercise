using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string s)
        {
            if (s == null || s == "")
            {
                return false;
            }

            var symbols = " .!,?";
            for (int i = 0; i < symbols.Length; i++)
            {
                s = s.Replace(symbols[i].ToString(), "");
            }

            if (s == "")
            {
                return false;
            }

            var cArr = s.ToLower().ToCharArray();
            cArr = cArr.Reverse().ToArray();
            var nStr = new string(cArr);
            return nStr == s.ToLower() ? true : false;
        }
    }
}
