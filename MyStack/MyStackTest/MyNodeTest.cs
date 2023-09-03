using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStack;

namespace MyStackTest
{
    [TestClass]
    public class MyNodeTest
    {
        [TestMethod]
        public void Test() 
        {

            MyNode<string> myNode = new MyNode<string>("abc");
            Assert.AreEqual("abc", myNode.Data);
            Assert.AreEqual(null, myNode.Next);
        }
    }
}
