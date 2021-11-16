using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrainIterpreter;
using System;

namespace BrainInterpreterTest
{
    [TestClass]
    public class BrainTestClass
    {
        [TestMethod]
        public void TestHello()
        {
            var service  = new InterpreterService();
            var result = service.ProcessInstructions("+[----->+++<]>+.---.+++++++..+++.");
            Assert.IsTrue("hello" == result);
        }

        [TestMethod]
        public void TestNumber_100()
        {
            var service  = new InterpreterService();
            var result = service.ProcessInstructions("-[----->+<]>--.-..");
            Assert.IsTrue(100 == Convert.ToInt32(result));
        }

        [TestMethod]
        public void TestMultiplyNumber()
        {
            var service  = new InterpreterService();
            var result = service.ProcessInstructions("+++++ ++[-> +++++ ++<]> +++.<");
            Assert.IsTrue(2*2 == Convert.ToInt32(result));
        } 
        
        [TestMethod]
        public void TestSubtractNumber()
        {
            var service  = new InterpreterService();
            var result = service.ProcessInstructions("-[----->+<]>++++.");
            Assert.IsTrue(10-3 == Convert.ToInt32(result));
        } 
        
        [TestMethod]
        public void Test255ByteOverflow()
        {
            var service  = new InterpreterService();
            var result = service.ProcessInstructions(",+[-.,+]");
            Assert.IsTrue("overflow" == "overflow");
        }
    }
}
