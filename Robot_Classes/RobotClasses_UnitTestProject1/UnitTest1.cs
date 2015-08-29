using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_Classes;

namespace RobotClasses_UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ButterRobot kevin = new ButterRobot(new Battery(), new BionicLegs());
        }


        [TestMethod]
        public void TestMethod2()
        {
            ButterRobot kevin = new ButterRobot(new Battery(), new BionicLegs());
            kevin.usePower();
        }
    }
}
