using MyStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackTest
{
    [TestClass]
    public class MyStackBaseTest
    {
        private class MySillyStackBaseTest : MyStackBase<string> 
        {

        }
        [TestMethod]
        public void FirstTest()
        {
            MySillyStackBaseTest myStackBaseTest = new MySillyStackBaseTest();
            Assert.AreEqual(myStackBaseTest.Count, 0);
        }
    }
}
