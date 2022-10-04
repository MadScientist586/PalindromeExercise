using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("hello", false)]
        [InlineData("cup", false)]
        [InlineData("noon", true)]
        public void isPalindromeTest(string str, bool expected)
        {
            //Arrange
            var input = new WordSmith();
            //Act
            var actual = input.IsAPalindrome(str);

            //Assert
            Assert.Equal(actual, expected);

        }
    }
}
