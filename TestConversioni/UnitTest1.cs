using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestConversioni
{
    [TestClass]
    public class TestConv64
    {
        [TestMethod]
        public void TestMethod1()
        {
            string risposta = Conversioni.ClasseBase64.Conv64();
            Assert.AreEqual("UHJvZiBGYWx1Y2NhLCBxdWEgZG92cmViYmUgdXNjaXJlIHVuIDEwLi4u", risposta);
        }
    }
}
