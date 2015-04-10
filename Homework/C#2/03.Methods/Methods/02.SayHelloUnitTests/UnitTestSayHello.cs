using System;
using Microsoft.VisualStudio.TestTools.UnitTesting; // new project -> c# -> Test -> Unit test project

// references must be active/added
// open Test menu -> Windows -> Test explorer -> play with it and check tests

namespace _01.SayHelloUnitTests
    {
    [TestClass] // this is necessary to be written
    public class UnitTestSayHello
        {
        [TestMethod] // this is necessary to be written, otherwise the method won't be tested
        public void FirstTest() // this one will fail
            {
            string actual = SayHello.SayHello.PrintSomeName("Dimitrichka");
            string expected = "Hello, Dimitrichka";
            Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void SecondTest() // this one will pass
            {
            string actual = SayHello.SayHello.PrintSomeName("Ivanka");
            string expected = "Hello, Ivanka";
            Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void ThirdTest() // this one will fail
            {
            string actual = SayHello.SayHello.PrintSomeName("Penka");
            string expected = "Penka is not a correct name format.";
            Assert.AreEqual(expected, actual);
            }
        }
    }

