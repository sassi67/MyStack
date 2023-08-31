using MyStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackTest
{
    [TestClass]
    public class MyStackBaseTest : MyStackBase
    {
        [TestMethod]
        public void FirstTest()
        {
            MyStackBaseTest myStackBaseTest = new MyStackBaseTest();
            Assert.AreEqual(myStackBaseTest.Count, 0);
        }
    }
}
