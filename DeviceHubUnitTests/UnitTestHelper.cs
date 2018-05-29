using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Alkl.DeviceHub.Devices;
using Alkl.DeviceHub.Modules;
using Moq;

namespace DeviceHubUnitTests
{
    internal static class UnitTestHelper
    {
        public static IModule CreateModuleMock()
        {
            var mock = new Mock<IModule>();

            mock.Setup(x => x.GetDevices()).Returns(new List<IDevice> {CreateDeviceMock()});

            return mock.Object;
        }

        public static IDevice CreateDeviceMock()
        {
            var mock = new Mock<IDevice>();

            mock.Setup(x => x.Vendor).Returns("alkl.de");
            mock.Setup(x => x.Model).Returns("XY123");
            mock.Setup(x => x.Description).Returns("lenghty description");

            return mock.Object;
        }
    }
}
