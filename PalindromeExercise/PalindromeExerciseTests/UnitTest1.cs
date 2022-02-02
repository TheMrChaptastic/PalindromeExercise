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
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("Sir, I demand I am a maid named Iris!",true)]
        [InlineData("Never odd or even.", true)]
        [InlineData(" ", false)]
        public void WordSmith(string s, bool expected)
        {
            var testing = new PalindromeExercise.WordSmith();
            bool actual = testing.IsAPalindrome(s);
            Assert.Equal(expected, actual);
        }
    }
}
