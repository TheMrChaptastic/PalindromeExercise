using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("corey", false)]
        [InlineData("Do geese see God",true)]
        public void WordSmith(string s, bool expected)
        {
            var testing = new PalindromeExercise.WordSmith();
            bool actual = testing.IsAPalindrome(s);
            Assert.Equal(expected, actual);
        }
    }
}
