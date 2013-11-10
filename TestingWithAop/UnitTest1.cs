using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingWithAop.Aspects;

namespace TestingWithAop
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestTrace]
        public void TestMethod1()
        {
            Console.WriteLine("This is the first test.");
            throw new Exception("Dummy exception");
        }
    }
}
