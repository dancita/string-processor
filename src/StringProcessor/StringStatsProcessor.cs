using System;
using System.Linq;

namespace StringProcessor
{
    /// <summary>
    /// Extracts statistics from the supplied string.
    /// </summary>
    public class StringStatsProcessor
    {
        /// <summary>
        /// Extracts statistics from the supplied string.
        /// </summary>
        /// <param name="subject">Must not be null.</param>
        /// <returns>A model containing statistics for the supplied string.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the supplied input is null.</exception>
        public StringStatsModel Run(string subject)
        {
            ValidateInput(subject);
            var wordsList = SplitStringIntoWords(subject);
            var stringStatsModel = new StringStatsModel
            {
                NumberOfCharacters = subject.Length,
                NumberOfWords = wordsList.Length,
                LongestWordNumberOfCharacters = GetLongestWordLength(wordsList)
            };
            return stringStatsModel;
        }

        private static void ValidateInput(string subject)
        {
            if (subject == null)
            {
                throw new ArgumentNullException();
            };
        }

        private static string[] SplitStringIntoWords(string subject)
        {
            char[] separator = {' ', '\t'};
            return subject.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }

        private static long GetLongestWordLength(string[] wordsList)
        {
            var longestWord = wordsList.OrderByDescending(word => word.Length).FirstOrDefault();
            if (longestWord == null)
            {
                return 0;
            }
            return longestWord.Length;
        }
    }
}