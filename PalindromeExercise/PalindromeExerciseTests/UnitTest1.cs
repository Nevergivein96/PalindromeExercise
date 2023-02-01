using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("morgan", false)]
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("truck", false)]
        public void TestPalindrone(string word, bool expected)
        {
            //arrange 
            var test = new WordSmith();
            //act
            var actual = test.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);

        }
    }
}
