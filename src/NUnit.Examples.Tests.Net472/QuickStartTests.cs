using NUnit.Examples.Impl;
using NUnit.Framework;

namespace NUnit.Examples.Tests
{
    [TestFixture]
    public class QuickStartTests
    {
        [Test]
        public void AddTest()
        {
            // Arrange
            const int value1 = 5;
            const int value2 = 3;
            
            // Act
            var result = QuickStart.Add(value1, value2);
            
            // Assert
            Assert.AreEqual(8, result);
        }
        
        [TestCase(0, 0, 0)]
        [TestCase(0, 4, 4)]
        [TestCase(4, 0, 4)]
        [TestCase(5, 3, 8)]
        [TestCase(-1, 7, 6)]
        public void AddTest2(int value1, int value2, int expectedResult)
        {
            // Act
            var result = QuickStart.Add(value1, value2);
            
            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(0, 4, ExpectedResult = 4)]
        [TestCase(4, 0, ExpectedResult = 4)]
        [TestCase(5, 3, ExpectedResult = 8)]
        [TestCase(-1, 7, ExpectedResult = 6)]
        public int AddTest3(int value1, int value2)
        {
            // AAA
            return QuickStart.Add(value1, value2);
        }
    }
}