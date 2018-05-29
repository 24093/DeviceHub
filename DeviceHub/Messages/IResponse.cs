using Alkl.DeviceHub.Common;
using Alkl.DeviceHub.Messages.Statuses;

namespace Alkl.DeviceHub.Messages
{
    public interface IResponse
    {
        IRequestId RequestId { get; }

        IStatus Status { get; }

        ITypedObject Data { get; }
    }
}