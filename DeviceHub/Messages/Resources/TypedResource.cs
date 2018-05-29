using System.Collections.Generic;
using Alkl.DeviceHub.Common;

namespace Alkl.DeviceHub.Messages.Resources
{
    public abstract class TypedResource : NamedType, IResource
    {
        public ITypedObject Data { get; }

        public static IResource Identity => new Identity();

        protected TypedResource()
        {
        }

        protected TypedResource(IResourceProperties properties)
        {
            Data = new TypedObject(new Dictionary<string, ITypedObject>
            {
                {nameof(name), new TypedObject(name)}
            });
        }
    }
}