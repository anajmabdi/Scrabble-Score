using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ScrabbleScore.Models;


namespace ScrabbleScore.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordConstructor_CreateInstanceOfScabble_Scrabble()
    {
      Word newScrabble = new Word("test");
      Assert.AreEqual(typeof(Word), newScrabble.GetType());
    }
    [TestMethod]
    public void WordConstructor_CreateInstanceOfWord_Word()
    {
      string otherWord = "bike";
      Word newWord = new Word(otherWord);
      char[] otherOtherWord = newWord.UserWord;
      Assert.AreEqual(otherWord, otherOtherWord);
    }
    
  }
}