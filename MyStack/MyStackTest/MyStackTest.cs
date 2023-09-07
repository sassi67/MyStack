using MyStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackTest
{
    [TestClass]
    public class MyStackTest
    {
        private class MyStringStack : MyStack<string> { }
        [TestMethod]
        public void TestClear()
        {
            MyStringStack stack = new MyStringStack();
            stack.Push("Alberto");
            Assert.AreEqual(1, stack.Count);

            stack.Clear();
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void TestPush()
        {
            MyStringStack stack = new MyStringStack();
            stack.Push("Alberto");
            stack.Push("Alessandro");
            stack.Push("Daniela");

            Assert.AreEqual(3, stack.Count);

        }

        [TestMethod]
        public void TestPop()
        {
            MyStringStack stack = new MyStringStack();
            stack.Push("Alberto");
            stack.Push("Alessandro");
            stack.Push("Daniela");
            
            Assert.AreEqual("Daniela", stack.Pop());
            Assert.AreEqual(2, stack.Count);
        }

        [TestMethod]
        public void TestPeek()
        {
            MyStringStack stack = new MyStringStack();
            stack.Push("Alberto");
            stack.Push("Alessandro");
            stack.Push("Daniela");

            Assert.AreEqual("Daniela", stack.Peek());
            Assert.AreEqual(3, stack.Count);
        }

        [TestMethod]
        public void TestContains()
        {
            MyStringStack stack = new MyStringStack();
            stack.Push("Alberto");
            stack.Push("Alessandro");
            stack.Push("Daniela");

            Assert.IsTrue(stack.Contains("Alessandro"));
            Assert.IsFalse(stack.Contains("Gigi Di Meo"));
        }

        [TestMethod]
        public void TestStackForEach()
        {
            MyStringStack stack = new MyStringStack();
            stack.Push("Alberto");
            stack.Push("Alessandro");
            stack.Push("Daniela");

            foreach (var elem in stack)
            {
                Console.WriteLine(elem);
            }
        }
        [TestMethod]
        public void TestStackIndexer()
        {
            MyStringStack stack = new MyStringStack();
            stack.Push("Alberto");
            stack.Push("Alessandro");
            stack.Push("Daniela");

            Assert.AreEqual("Daniela", stack[2]);
            Assert.AreEqual("Alessandro", stack[1]);
            Assert.AreEqual("Alberto", stack[0]);

        }
    }
}
