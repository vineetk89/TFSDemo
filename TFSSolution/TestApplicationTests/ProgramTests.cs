using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Tests
{
    //test checkin
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TestAdd()
        {
            Program.add(10, 20);
        }

        [TestMethod()]
        public void TestSub()
        {
            Program.sub(10, 20);
        }

        [TestMethod()]
        public void TestMul()
        {
            Program.mul(10, 20);
        }

        [TestMethod()]
        public void TestDiv()
        {
            Program.div(10, 20);
        }
    }
}