using System;
using System.Collections.Generic;
using System.Linq;
using WordCounter.Models;

namespace WordCounter.Service
{
    public interface IWordCountingService
    {
        IEnumerable<WordCount> GetTopTenWords(string text);
    }
    public class WordCountingService : IWordCountingService
    {
        private readonly char[] delimiters = {'\n', '\r', ' ', '.', ',', '?', '!', '\"', '\'', ';', ':', '*'};
        public IEnumerable<WordCount> GetTopTenWords(string text)
        {
            //Avoid null reference exceptions
            if (string.IsNullOrWhiteSpace(text))
            {
                return Enumerable.Empty<WordCount>();
            }

            /*
             * Split text by known word delimiters in the english language (will have the added effect of removing them)
             * Include quotation marks as they will obscure identification of unique words. Allow apostraphes and hyphens to remain.
             * Removing these characters with Regex would be more expensive
             */
            string[] wordsArray = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            //Although it won't error, there is no need to continue with this method if the above found no words
            if (wordsArray.Length == 0)
            {
                return Enumerable.Empty<WordCount>();
            }
            /*
             * Running IDictionary.ContainsKey n times would be significantly less efficient than using LINQ even given the inherent overhead of LINQ. A v quick benchmark (with increasing data set size) showed that the LINQ statement was in fact approx. 100x faster
             * A Trie structure may prove faster but time does not allow for implementation
             */
            IEnumerable<WordCount> wordCounts = wordsArray.GroupBy(word => word.ToLower()).Select(g => new WordCount {Word = g.Key, Count = g.Count()});
            return wordCounts.OrderByDescending(w => w.Count).Take(10);
        }
    }
}