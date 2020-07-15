using System;

namespace WordCounter.Models
{
    public class WordCount
    {
        public string Word { get; set; }
        public long Count { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as WordCount);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Word, Count);
        }

        public bool Equals(WordCount obj)
        {
            return obj != null && obj.Word.Equals(Word, StringComparison.InvariantCultureIgnoreCase) && obj.Count == Count;
        }
    }
}
