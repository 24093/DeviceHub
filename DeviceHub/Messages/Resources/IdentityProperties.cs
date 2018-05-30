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

        public IEnumerable<IResourceProperty> GetProperties()
        {
            yield return new ResourceProperty(nameof(Name), Name);
        }
    }
}