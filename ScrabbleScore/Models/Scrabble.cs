
using System;

namespace ScrabbleScore.Models
{
    public class Word
    {
      public string UserWord { get; set; }
      public Word(string userWord)
      {
        UserWord = userWord;
      }

      public string CheckScore(string userWord)
      {
        int scoreTotal = 0;
        string ucUserWord = userWord.ToUpper();
        char[] wordArray = ucUserWord.ToCharArray();

      }
  }
}


