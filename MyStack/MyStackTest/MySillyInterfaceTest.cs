using MyStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyStackTest
{
    [TestClass]
    public class MySillyInterfaceTest
    {
        private class MySillyStack : IMyStack<string>
        {
            private List<string> list = new List<string>();
            public void Clear()
            {
                list.Clear();
            }

            public bool Contains(string item)
            {
                if (list.Count == 0) return false;
                if (list.Contains(item)) return true;
                return false;
            }

            public string Peek()
            {
                if (list.Count == 0) return null;
                return list[0];
            }

            public string Pop()
            {
                if (list.Count == 0) return null;
                string rtn = list[0];
                list.RemoveAt(0);
                return rtn;
            }

            public void Push(string item)
            {
                list.Insert(0, item);
            }
        }
        [TestMethod]
        public void TestClear()
        {
            MySillyStack list = new MySillyStack();
            list.Push("a");
            list.Clear();
        }
        [TestMethod]
        public void ContainsItem()
        {
            MySillyStack list = new MySillyStack();
            bool rtn = list.Contains("abc");
            Assert.IsFalse(rtn);
            list.Push("abc");
            bool rtn2 = list.Contains("abc");
            Assert.IsTrue(rtn2);
        }
        [TestMethod]
        public void Peek()
        {
            MySillyStack mySillyStack = new MySillyStack();
            mySillyStack.Push("a");
            string s = mySillyStack.Peek();
            Assert.AreEqual(s, "a");
        }
        [TestMethod]
        public void Pop()
        {
            MySillyStack mySillyStack = new MySillyStack();
            var s = mySillyStack.Pop();
            Assert.AreEqual(s, null);
            mySillyStack.Push("abc");
            var i = mySillyStack.Pop();
            Assert.AreEqual(i, "abc");
        }
        [TestMethod]
        public void Push()
        {
            MySillyStack mySillyStack = new MySillyStack();
            mySillyStack.Push("abc");
            var s = mySillyStack.Peek();
            Assert.AreEqual(s, "abc");
        }
    }
   
}
