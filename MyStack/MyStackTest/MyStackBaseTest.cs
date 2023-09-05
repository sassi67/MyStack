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
            public override void Clear()
            {
                throw new NotImplementedException();
            }

            public override bool Contains(string elem)
            {
                throw new NotImplementedException();
            }

            public override string Peek()
            {
                throw new NotImplementedException();
            }

            public override string Pop()
            {
                throw new NotImplementedException();
            }

            public override void Push(string elem)
            {
                throw new NotImplementedException();
            }
        }
        [TestMethod]
        public void FirstTest()
        {
            MySillyStackBaseTest myStackBaseTest = new MySillyStackBaseTest();
            Assert.AreEqual(myStackBaseTest.Count, 0);
        }
    }
}
