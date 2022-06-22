using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.tests
{
  [TestClass]
  public class PalindromeCheckerTests
  {
    [TestMethod]
    public void IsStringPalindrome_StringSameInReverse_True()
    {
      PalindromeChecker testPalindromeChecker = new PalindromeChecker();
      Assert.AreEqual(true, testPalindromeChecker.IsStringPalindrome("poop"));
    }
    [TestMethod]
    public void IsStringPalindrome_StringNotSameInReverse_False()
    {
      PalindromeChecker testPalindromeChecker = new PalindromeChecker();
      Assert.AreEqual(false, testPalindromeChecker.IsStringPalindrome("patty"));
    }
  }
}
