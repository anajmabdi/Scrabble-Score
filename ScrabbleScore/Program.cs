using System;
using System.Collections.Generic;

using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("What Scrabble word do you want to play?");
      string userWord = Console.ReadLine();
      string ucUserWord = userWord.ToUpper();
      Word newWord = new Word(ucUserWord);
      char[] result = newWord.UserWord;


      List<char> list1 = new List<char> { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };
      List<char> list2 = new List<char> { 'D', 'G' };
      List<char> list3 = new List<char> { 'B', 'C', 'M', 'P' };
      List<char> list4 = new List<char> { 'F', 'H', 'V', 'W', 'Y' };
      List<char> list5 = new List<char> { 'J', 'X' };
      List<char> list6 = new List<char> { 'Q', 'Z' };

  
      
      int scoreTotal = 0;

      foreach (char letter in result)
      {
        if (list1.Contains(letter))
        {
          scoreTotal += 1;
        }
        else if (list2.Contains(letter))
        {
          scoreTotal += 2;
        }
        else if (list3.Contains(letter))
        {
          scoreTotal += 3;
        }
        else if (list4.Contains(letter))
        {
          scoreTotal += 4;
        }
        else if (list5.Contains(letter))
        {
          scoreTotal += 8;
        }
        else if (list6.Contains(letter))
        {
          scoreTotal += 10;
        }
        else
        {
          scoreTotal +=5 ;
        }
      }
    
      //string ScoreTotal = CheckScore(userWord);


  Console.WriteLine("you have scored " +  scoreTotal + " points.");    }
  }
} 