using System;
using SayHello;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02.SayHelloTests
{
    [TestClass]
    public class SayHelloTests
    {
        [TestMethod]
        public void FirstTest()
        {
            string actual = SayHello.SayHello.PrintSomeName("Dimitrichka");
            string expected = "Hello, Dimitrichka";
            Assert.AreEqual(expected, actual);
        }
        public void SecondTest()
            {
            string actual = SayHello.SayHello.PrintSomeName("Ivanka");
            string expected = "Hello, Ivanka";
            Assert.AreEqual(expected, actual);
            }
    }
}
