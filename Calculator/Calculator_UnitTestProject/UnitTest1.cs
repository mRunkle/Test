using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator_UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testDeclarationOfAddition()
        {
            Addition addTest = new Addition();
        }

        [TestMethod]
        public void testAdditionFunctionality()
        {
            Addition addTest = new Addition();

            decimal testVar = 100;
            decimal[] testInput = new decimal[] {2, 3, 70, 25};
            decimal testSum = addTest.addNumbers(testInput);

            Assert.AreEqual(testVar, testSum);
        }

        [TestMethod]
        public void testSubtractionFunctionality()
        {
            Subtraction subTest = new Subtraction();

            decimal testVar = 5;
            decimal testDifference = subTest.subtractNumbers(10, 5);

            Assert.AreEqual(testVar, testDifference);
        }

        [TestMethod]
        public void testMultiplicationFunctionality()
        {
            Multiplication multTest = new Multiplication();

            decimal testVar = 4;
            decimal testProduct = multTest.multiplyNumbers(2, 2);

            Assert.AreEqual(testVar, testProduct);
        }

        [TestMethod]
        public void testDivisionFunctionality()
        {
            Division divTest = new Division();

            decimal testVar = 20;
            decimal testQuotient = divTest.divideNumbers(100, 5);

            Assert.AreEqual(testVar, testQuotient);
        }
        /*
        [TestMethod]
        public void testFunctionCall_callAddition()
        {
            FunctionCall addCallTest = new FunctionCall();

            decimal testVar = 100;
            string testInput = "2+3+70+25";
            decimal callOutput = addCallTest.callAddition(testInput);

            Assert.AreEqual(testVar, callOutput);
        }
        */
    }
}
