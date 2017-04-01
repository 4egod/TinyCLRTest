
namespace DesktopUnitTestProject
{
    using System.Diagnostics;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CustomUnitTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Debug.WriteLine("Initialize...");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Debug.WriteLine("Cleanup...");
        }

        [TestMethod]
        public void HardMethodTest()
        {
            for (int i = 0; i < 1000; i++)
            {
                object o = i;
                o.ToString();
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine("Method1");
        }

        [TestMethod]
        public void Method2Test()
        {
            Debug.WriteLine("Method2");
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Debug.WriteLine("Method3");
            Assert.Inconclusive("Inconclusive method...");
        }
    }
}
