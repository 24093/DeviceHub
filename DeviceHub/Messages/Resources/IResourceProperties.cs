using System.Collections.Generic;

namespace Alkl.DeviceHub.Messages.Resources
{
    public interface IResourceProperties
    {
        IEnumerable<IResourceProperty> GetProperties();
    }
}