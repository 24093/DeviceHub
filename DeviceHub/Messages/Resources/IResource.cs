using Alkl.DeviceHub.Common;

namespace Alkl.DeviceHub.Messages.Resources
{
    public interface IResource
    {
        ITypedObject Data { get; }
    }
}