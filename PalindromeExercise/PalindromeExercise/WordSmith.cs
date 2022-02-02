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
            var cArr = s.Replace(" ", "").ToLower().ToCharArray();
            cArr = cArr.Reverse().ToArray();
            var nStr = new string(cArr);
            return nStr == s.Replace(" ", "").ToLower() ? true : false;
        }
    }
}
