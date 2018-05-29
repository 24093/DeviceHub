using System.Collections.Generic;
using Alkl.DeviceHub.Common;

namespace Alkl.DeviceHub.Messages.Resources
{
    public class IdentityProperties : IResourceProperties
    {
        public string Name { get; set; }

        public IdentityProperties(string name)
        {
            Name = name;
        }

        public Dictionary<string, ITypedObject> GetProperties()
        {
            return new Dictionary<string, ITypedObject>
            {
                {nameof(Name), new TypedObject(Name)}
            };
        }
    }
}