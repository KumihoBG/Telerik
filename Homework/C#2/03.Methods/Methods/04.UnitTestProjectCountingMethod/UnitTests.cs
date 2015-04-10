using Microsoft.VisualStudio.TestTools.UnitTesting;
// check Problem 2. More detailed explanation of Unit test could be found over there;

namespace _04.UnitTestProjectCountingMethod
    {
    [TestClass]
    public class UnitTests
        {
        [TestMethod]
        public void SuccessfulTestExample() //this test will succeed
            {
            int[] array = { 2, 3, 4, 5, 5, 5, 6, 5 };
            int actual = AppearanceCount.AppearanceCountMethod.CheckForNumber(array, 5);
            int expected = 4;
            Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void SuccessfulTestExample2() //this test will succeed
            {
            int[] array = { 2, 3, 4, 7, 7, 7, 6, 5 };
            int actual = AppearanceCount.AppearanceCountMethod.CheckForNumber(array, 7);
            int expected = 3;
            Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void FailedTestExample() //this test will fail
            {
            int[] array = { 2, 3, 4, 7, 7, 7, 6, 7 };
            int actual = AppearanceCount.AppearanceCountMethod.CheckForNumber(array, 7);
            int expected = 3;
            Assert.AreEqual(expected, actual);
            }
        }
    }
