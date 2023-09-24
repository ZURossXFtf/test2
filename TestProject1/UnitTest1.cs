using MyApplication;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDiv()
        {
            Assert.AreEqual(MyClass.ToDiv(4),true);
            Assert.AreEqual(MyClass.ToDiv(1), false);
            Assert.AreEqual(MyClass.ToDiv(8), true);
            Assert.AreEqual(MyClass.ToDiv(3), false);
            Assert.AreEqual(MyClass.ToDiv(16), true);
            Assert.AreEqual(MyClass.ToDiv(5), false);
        }
    }
}