using NUnit.Framework;
using Shiny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShinyNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new();

            //Act
            int result = calc.AddNumbers(10, 20);

            //Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            Calculator calculator = new();
            bool isOdd = calculator.IsOddNumber(22);

            Assert.That(isOdd, Is.False);
            Assert.That(isOdd, Is.EqualTo(false));
            Assert.IsFalse(isOdd);
        }

        [Test]
        public void IsOddChecker_InputOddNumber_ReturnTrue()
        {
            Calculator calculator = new();
            bool isOdd = calculator.IsOddNumber(21);

            Assert.That(isOdd, Is.True);
            Assert.That(isOdd, Is.EqualTo(true));
            Assert.IsTrue(isOdd);
        }

        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsOddChecker_InputOddNumber_ReturnTrue2(int a)
        {
            Calculator calculator = new();
            bool isOdd = calculator.IsOddNumber(21);

            Assert.That(isOdd, Is.True);
            Assert.That(isOdd, Is.EqualTo(true));
            Assert.IsTrue(isOdd);
        }

        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
        {
            Calculator calculator = new();
            return calculator.IsOddNumber(a);
        }


        [Test]
        [TestCase(5.4, 10.5)] // 15.9
        [TestCase(5.43, 10.53)] // 15.93
        [TestCase(5.49, 10.59)] // 16.08
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            Calculator calculator = new();
            double result = calculator.AddNumbersDouble(a, b);
            Assert.That(result, Is.EqualTo(15.9).Within(1));
        }

        [Test]
        public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            Calculator calc = new();
            List<int> expectedOddRange = new() { 5, 7, 9 };

            List<int> result = calc.GetOddRange(5, 10);

            Assert.That(result, Is.EquivalentTo(expectedOddRange));
            //Assert.AreEqual(expectedOddRange, result);
            //Assert.That(result, Is.EqualTo(expectedOddRange));
            Assert.Contains(7, result);
            Assert.That(result, Does.Contain(7));
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Has.No.Member(6));
            Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Ordered.Descending);
            Assert.That(result, Is.Unique);
        }


    }
}
