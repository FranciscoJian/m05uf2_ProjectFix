using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class Palindrome_Tests
    {
        [TestMethod]
        public void Palindrome_Test()
        {
            //Arrange
            string original = Utils.RandomString(Utils.random.Next(5, 10));
            string result = "";
            //Act
            result = Palindrome.Program.Palindrome(original);
            //Assert
            Assert.IsTrue(IsPalindrome(result));
        }

        public static bool IsPalindrome(string text)
        {
            if (text.Length % 2 != 0)
                return false;
            string halfA = text.Substring(0, text.Length / 2);
            string halfB = text.Substring(text.Length / 2, text.Length / 2);
            return halfA == halfB;
        }
    }
}
