using MyStack;

namespace MyStackTest
{
    [TestClass]
    public class MyLinkedListTest
    {
        private class MyStringLinkedList : MyLinkedList<string>
        {

        }

        [TestMethod]
        public void TestMyLinkedListEmpty()
        {
            MyStringLinkedList myStringLinkedList = new MyStringLinkedList();

            Assert.AreEqual(0, myStringLinkedList.Count);
            Assert.IsNull(myStringLinkedList.First);
            Assert.AreEqual(myStringLinkedList.First, myStringLinkedList.Last);

        }

        [TestMethod]
        public void TestMyLinkedListAddLast()
        {
            MyStringLinkedList myStringLinkedList = new MyStringLinkedList();
            myStringLinkedList.AddLast("Alberto");
            myStringLinkedList.AddLast("Sacilotto");

            Assert.AreEqual(2, myStringLinkedList.Count);
            Assert.AreEqual("Alberto", myStringLinkedList.First.Data);
            Assert.AreEqual("Sacilotto", myStringLinkedList.Last.Data);
        }

        [TestMethod]
        public void TestMyLinkedListAddFirst()
        {
            MyStringLinkedList myStringLinkedList = new MyStringLinkedList();
            myStringLinkedList.AddFirst("Alberto");
            myStringLinkedList.AddFirst("Sacilotto");

            Assert.AreEqual(2, myStringLinkedList.Count);
            Assert.AreEqual("Sacilotto", myStringLinkedList.First.Data);
            Assert.AreEqual("Alberto", myStringLinkedList.Last.Data);
        }

        [TestMethod]
        public void TestMyLinkedListClear()
        {
            MyStringLinkedList myStringLinkedList = new MyStringLinkedList();
            myStringLinkedList.AddFirst("Alberto");
            myStringLinkedList.AddFirst("Sacilotto");
            myStringLinkedList.Clear();

            Assert.AreEqual(0, myStringLinkedList.Count);
        }

        [TestMethod]
        public void TestMyLinkedListContains()
        {
            MyStringLinkedList myStringLinkedList = new MyStringLinkedList();
            Assert.IsFalse(myStringLinkedList.Contains("Gigi Di Meo"));

            myStringLinkedList.AddFirst("Alberto");
            myStringLinkedList.AddFirst("Sacilotto");
            myStringLinkedList.AddFirst("Daniela");
            myStringLinkedList.AddFirst("Minudel");

            Assert.IsFalse(myStringLinkedList.Contains("Gigi Di Meo"));
            Assert.IsTrue(myStringLinkedList.Contains("Daniela"));
        }

        [TestMethod]
        public void TestMyLinkedListRemoveLast()
        {
            MyStringLinkedList myStringLinkedList = new MyStringLinkedList();
            Assert.IsNull(myStringLinkedList.RemoveLast());
            Assert.AreEqual(0, myStringLinkedList.Count);

            myStringLinkedList.AddFirst("Alberto");
            myStringLinkedList.AddFirst("Sacilotto");
            myStringLinkedList.AddFirst("Daniela");
            myStringLinkedList.AddFirst("Minudel");
            MyNode<string> myNode = new MyNode<string>("Alberto");

            Assert.AreEqual(myNode, myStringLinkedList.RemoveLast());
            Assert.AreEqual(3, myStringLinkedList.Count);
            Assert.IsFalse(myStringLinkedList.Contains("Alberto"));

        }

        [TestMethod]
        public void TestMyLinkedListAddAfter()
        {
            MyStringLinkedList myStringLinkedList = new MyStringLinkedList();
            Exception expectedException = null;
            try
            {
                myStringLinkedList.AddAfter(null, "Alberto");
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);

            MyNode<string> firstNode = new MyNode<string>("Alberto");
            MyNode<string> secondNode = new MyNode<string>("Sacilotto");
            MyNode<string> thirdNode = new MyNode<string>("Daniela");

            myStringLinkedList.AddLast("Alberto");
            Assert.AreEqual(secondNode, myStringLinkedList.AddAfter(firstNode, "Sacilotto"));
            Assert.AreEqual(thirdNode, myStringLinkedList.AddAfter(secondNode, "Daniela"));
            Assert.AreEqual(3, myStringLinkedList.Count);

            MyNode<string> unexistingNode = new MyNode<string>("Gigi Di Meo");
            expectedException = null;
            try
            {
                Assert.AreEqual(thirdNode, myStringLinkedList.AddAfter(unexistingNode, "Ugo Fantozzi"));
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

    }
}
