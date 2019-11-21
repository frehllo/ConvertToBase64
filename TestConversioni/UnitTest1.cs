using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestConversioni
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string risposta = Conversioni.ClasseBase64.Conv64();
            Assert.AreEqual("Vm9ycmVpIHVuIDEw", risposta);
        }
    }
}
