using Alkl.DeviceHub.Connection;
using Alkl.DeviceHub.Messages.Resources;

namespace Alkl.DeviceHub.Devices
{
    public interface IDevice
    {
        Identity Identity { get; }

        Status Status { get; }

        IConnection Connection { get; }
    }
}
