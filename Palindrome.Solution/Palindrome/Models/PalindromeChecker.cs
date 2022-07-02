using System;

namespace Palindrome
{
  public class PalindromeChecker
  {
    public bool IsStringPalindrome(string str)
    {
      char[] chArr = new char[str.Length];
      for (int i= 0; i < str.Length; i++)
      {
        chArr[i] = str[i];
      }//turn str into array
      Array.Reverse( chArr ); //reverse array
      string strRev = new string(chArr);
      return str == strRev; //if reversed array == str array return true
    }
  }
}