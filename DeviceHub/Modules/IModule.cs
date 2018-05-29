using System.Collections.Generic;
using Alkl.DeviceHub.Devices;

namespace Alkl.DeviceHub.Modules
{
    public interface IModule
    {
        IEnumerable<IDevice> GetDevices();

    }
}
