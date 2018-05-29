using Alkl.DeviceHub.Common;
using Alkl.DeviceHub.Messages.Methods;
using Alkl.DeviceHub.Messages.Resources;

namespace Alkl.DeviceHub.Messages
{
    public class GenericRequest : IRequest
    {
        public IRequestId Id { get; }

        public IMethod Method { get; }

        public IResource Resource { get; }

        public ITypedObject Parameters { get; }

        public GenericRequest(IMethod method, IResource resource, ITypedObject parmeters = null)
        {
            Id = new GuidRequestId();
            Method = method;
            Resource = resource;
            Parameters = parmeters;
        }
    }
}