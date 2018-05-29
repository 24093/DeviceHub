using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeviceHubUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var module = UnitTestHelper.CreateModuleMock();

            var devices = module.GetDevices();


        }
    }
}
