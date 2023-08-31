using MyStack;

namespace MyStackTest
{
    [TestClass]
    internal class MyMathTest
    {
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(5, MyMath.Add(2, 3));
        }
    }
    
}
