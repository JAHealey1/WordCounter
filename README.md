# WordCounter
Alpha FX Interview Task

Solution to count the number of words in a given body of text.

Example text required to use: https://archive.org/stream/LordOfTheRingsApocalypticProphecies/Lord%20of%20the%20Rings%20Apocalyptic%20Prophecies_djvu.txt

Solution must list the top 10 words along with the nunber of occurences

Please note the large amount of comments found in this code are for clarity of thought process during development as this process naturally had to be conducted remotely.

Assumptions made:  
  1) The text is entirely written in english
  2) The text only contains common english punctuation
  3) Words that only differ in case should be counted as the same word
  4) If less than 10 words are counted, all should be returned instead of warning that <10 were found
  
Steps taken:
  1) Create interface containing the single method required and the model that represents the return type
  2) Build test cases based on the above assumptions using an empty implementation of the above interface
  3) Completely implement the aforementioned interface (this involved some very quick benchmarking using the stopwatch interface that I cannot entirely gurantuee the accuracy of)
  4) Test
  5) Refactor
  6) Write main method for output
  
Drawbacks:
    1) Delimiters for words were based on a quick google, some may be missed
    2) As mentioned previously this will not support languages that use alternative punctuation (e.g spanish)
    3) Whilst the method used to group the words may be more efficient than some others, this could still be improved if more time had been given (see comments in code for specifics)
