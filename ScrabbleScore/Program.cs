using System;
using Stytem.Collections.Generic;

using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("What Scrabble word do you want to play?");
      string userWord = Console.ReadLine();
      Word newWord = new Word(userWord);
      
      List<char> listValue1 = new List<char> {A, E, I, O, U, L, N, R, S, T};
      List<char> listValue2 = new List<char> {D, G};
      List<char> listValue3 = new List<char> {B, C, M, P};
      List<char> listValue4 = new List<char> {F, H, V, W, Y};
      List<char> listValue8 = new List<char> {J, X};
      List<char> listValue10 = new List<char> {Q, Z};
      //K is worth 5 use else statment


      // string ScoreTotal = CheckScore(userWord);


  Console.WriteLine("you have scored " +  ScoreTotal + "points.");    }
  }
} 