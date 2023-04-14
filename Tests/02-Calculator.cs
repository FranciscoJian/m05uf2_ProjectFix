using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Calculator_Tests
    {
        [TestMethod]
        public void Add_Test()
        {
            //Arrange
            float A = (float)Utils.random.NextDouble();
            float B = (float)Utils.random.NextDouble();
            float result = 0;
            float resultOK = A + B;
            //Act
            result = Calculator.Program.Sum(A, B);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
        [TestMethod]
        public void Substract_Test()
        {
            //Arrange
            float A = (float)Utils.random.NextDouble();
            float B = (float)Utils.random.NextDouble();
            float result = 0;
            float resultOK = A - B;
            //Act
            result = Calculator.Program.Substract(A, B);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
        [TestMethod]
        public void Divide_Test()
        {
            //Arrange
            float A = (float)Utils.random.NextDouble();
            float B = (float)Utils.random.NextDouble();
            float result = 0;
            float resultOK = A / B;
            //Act
            result = Calculator.Program.Divide(A, B);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
        [TestMethod]
        public void Multiply_Test()
        {
            //Arrange
            float A = (float)Utils.random.NextDouble();
            float B = (float)Utils.random.NextDouble();
            float result = 0;
            float resultOK = A * B;
            //Act
            result = Calculator.Program.Multiply(A, B);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
        [TestMethod]
        public void Mod_Test()
        {
            //Arrange
            float A = (float)Utils.random.NextDouble();
            float B = (float)Utils.random.NextDouble();
            float result = 0;
            float resultOK = A % B;
            //Act
            result = Calculator.Program.Mod(A, B);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
    }
}
