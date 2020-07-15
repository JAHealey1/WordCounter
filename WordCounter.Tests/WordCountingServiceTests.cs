using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using WordCounter.Models;
using WordCounter.Service;

namespace WordCounter.Tests
{
    public class WordCountingServiceTests
    {
        private string testText;
        private IWordCountingService wordCountingService;
        [SetUp]
        public void Setup()
        {
            wordCountingService = new WordCountingService();
            testText =
                "This Is is is is is is is is is is a submission submission a technical test test test test in relation relation relation relation relation relation relation relation a job at Alpha Alpha Alpha Alpha Alpha FX, submitted submitted submitted submitted submitted submitted by Jacob Jacob Jacob Jacob Jacob Jacob Jacob Healey Healey Healey Healey Healey Healey Healey Healey Healey";
        }
        [Test]
        public void CountsWordsCorrectly()
        {
            //Arrange
            var expectedResult = new List<WordCount>
            {
                new WordCount { Word = "is", Count = 10 },
                new WordCount { Word = "healey", Count = 9 },
                new WordCount { Word = "relation", Count = 8 },
                new WordCount { Word = "jacob", Count = 7 },
                new WordCount { Word = "submitted", Count = 6 },
                new WordCount { Word = "alpha", Count = 5 },
                new WordCount { Word = "test", Count = 4 },
                new WordCount { Word = "a", Count = 3 },
                new WordCount { Word = "submission", Count = 2 },
                new WordCount { Word = "this", Count = 1 }
            };

            //Act
            IEnumerable<WordCount> topTenWords = wordCountingService.GetTopTenWords(testText);
            
            //Assert
            Assert.That(topTenWords, Is.EquivalentTo(expectedResult));

        }

        [Test]
        public void CountsWordsCaseInsensitively()
        {
            //Arrange
            var expected = new WordCount {Word = "is", Count = 10};

            //Act
            IEnumerable<WordCount> topTenWords = wordCountingService.GetTopTenWords(testText);
            List<WordCount> isCounts =
                topTenWords.Where(w => w.Word.Equals("is", StringComparison.InvariantCultureIgnoreCase)).ToList();

            //Assert
            Assert.That(() => isCounts.Count == 1 && isCounts[0].Equals(expected));
        }

        [Test]
        public void FindsNoWordsWhenOnlyPunctuationOrWhiteSpace()
        {
            //Arrange
            string punctuatioAndWhiteSpacenOnlyText = "!?,    .\'\":;";

            //Act
            IEnumerable<WordCount> topTenWords = wordCountingService.GetTopTenWords(punctuatioAndWhiteSpacenOnlyText);

            //Assert
            Assert.IsEmpty(topTenWords);
        }
    }
}