using Alkl.DeviceHub.Common;
using Alkl.DeviceHub.Messages.Statuses;

namespace Alkl.DeviceHub.Messages
{
    public class GenericResponse : IResponse
    {
        public IRequestId RequestId { get; }

        public IStatus Status { get; }

        public ITypedObject Data { get; }

        public GenericResponse(IRequestId requestId, IStatus status, ITypedObject data = null)
        {
            RequestId = requestId;
            Status = status;
            Data = data;
        }
    }
}