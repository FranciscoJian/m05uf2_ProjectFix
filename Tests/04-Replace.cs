using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Tests
{
    [TestClass]
    public class Replace_Tests
    {
        [TestMethod]
        public void Replace_Test()
        {
            //Arrange
            string original = Utils.RandomString(Utils.random.Next(10, 100));
            char search = Utils.RandomChar();
            char replace = Utils.RandomChar();
            string result = "";
            string resultOK = original.Replace(search, replace);
            //Act
            result = Replace.Program.Replace(original, search, replace);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
    }
}
