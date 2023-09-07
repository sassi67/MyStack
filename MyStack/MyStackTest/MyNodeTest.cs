using MyStack;

namespace MyStackTest
{
    [TestClass]
    public class MyNodeTest
    {
        [TestMethod]
        public void TestMyNode()
        {
            MyNode<string> myFirstNode = new MyNode<string>("Giggino");
            Assert.AreEqual("Giggino", myFirstNode.Data);
            Assert.IsNull(myFirstNode.Next);

            MyNode<string> mySecondNode = new MyNode<string>("Giggino");
            Assert.AreEqual(myFirstNode, mySecondNode);

        }
    }
}
