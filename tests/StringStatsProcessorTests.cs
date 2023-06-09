using System;
using Xunit;

namespace StringProcessor.Tests
{
    /// <summary>
    /// Unit tests for StringStatsProcessor.
    /// </summary>
    public class StringStatsProcessorTests
    {
        [Fact]
        public void Run_NullInput_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => new StringStatsProcessor().Run(null));
        }

        [Fact]
        public void Run_EmptyString_ZeroStats()
        {
            const string testData = ""; 
            var subject = new StringStatsProcessor();

            StringStatsModel results = subject.Run(testData);
            
            Assert.Equal(0, results.LongestWordNumberOfCharacters);
            Assert.Equal(0, results.NumberOfCharacters);
            Assert.Equal(0, results.NumberOfWords);
        }
        
        [Fact]
        public void Run_WhitespaceString_NoWordsStats()
        {
            const string testData = "   \t"; 
            var subject = new StringStatsProcessor();

            StringStatsModel results = subject.Run(testData);
            
            Assert.Equal(0, results.LongestWordNumberOfCharacters);
            Assert.Equal(4, results.NumberOfCharacters);
            Assert.Equal(0, results.NumberOfWords);
        }
                
        [Fact]
        public void Run_SimpleString_ReturnsStats()
        {
            const string testData = "The cat sat on the mat."; 
            var subject = new StringStatsProcessor();

            StringStatsModel results = subject.Run(testData);
            
            Assert.Equal(4, results.LongestWordNumberOfCharacters);
            Assert.Equal(23, results.NumberOfCharacters);
            Assert.Equal(6, results.NumberOfWords);
        }

        // For bonus points, write a unit test which tests very large input to the StringStatsProcessor.Run(string) method.
        [Theory]
        [InlineData(5055)]
        [InlineData(10000)]
        [InlineData(999)]
        public void Run_LargeInputNoSpace_ReturnsStats(int stringLength)
        {
            string testData = new('a', stringLength);
            var subject = new StringStatsProcessor();

            StringStatsModel results = subject.Run(testData);

            Assert.Equal(stringLength, results.LongestWordNumberOfCharacters);
            Assert.Equal(stringLength, results.NumberOfCharacters);
            Assert.Equal(1, results.NumberOfWords);
        }
    }
}