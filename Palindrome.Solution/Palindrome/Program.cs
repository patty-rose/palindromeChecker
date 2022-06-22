using System;
using System.Collections.Generic;
using Palindrome.Models;

namespace Palindrome.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter a word to check if it is a Palindrome:");
      string strInput = Console.ReadLine();
      PalindromeChecker checker = new PalindromeChecker();
      if (checker.IsStringPalindrome(strInput))
      {
        Console.WriteLine("Your word is a palindrome! The same forwards and backwards!");
      }
      else
      {
        Console.WriteLine("Your word is not a palindrome. It is not the same forwards and backwards.");
      }
    }
  }
}