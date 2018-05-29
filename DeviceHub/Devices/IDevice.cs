using Alkl.DeviceHub.Connection;

namespace Alkl.DeviceHub.Devices
{
    public interface IDevice
    {
        string Vendor { get; }

        string Model { get; }

        string Description { get; }

        IConnection Connection { get; }
    }
}
