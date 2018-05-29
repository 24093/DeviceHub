using Alkl.DeviceHub.Common;
using Alkl.DeviceHub.Messages.Methods;
using Alkl.DeviceHub.Messages.Resources;

namespace Alkl.DeviceHub.Messages
{
    public interface IRequest
    {
        IRequestId Id { get; }

        IMethod Method { get; }

        IResource Resource { get; }

        ITypedObject Parameters { get; }
    }
}