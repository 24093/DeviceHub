using System.Collections.Generic;
using Alkl.DeviceHub.Common;

namespace Alkl.DeviceHub.Messages.Resources
{
    public interface IResourceProperties
    {
        Dictionary<string, ITypedObject> GetProperties();
    }
}