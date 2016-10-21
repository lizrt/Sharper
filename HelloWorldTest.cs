using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;


namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [TestCategory("Simple Math")]
        public void Test_Calculator_Add()
        {

            MyCalculator c = new MyCalculator();
            var sum = c.Add(1, 2);
            Assert.AreEqual(3,sum);
            
        }

        [TestMethod]
        [TestCategory("Exceptions")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_Calculator_DivideByZero()
        {
            MyCalculator c = new MyCalculator();
            c.Divide(32, 0);
        }
    }
}
