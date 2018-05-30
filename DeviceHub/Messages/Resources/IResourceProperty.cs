using Alkl.DeviceHub.Common;

namespace Alkl.DeviceHub.Messages.Resources
{
    public interface IResourceProperty
    {
        string Key { get; }

        ITypedObject Value { get; }

        ITypedObject MinimumValue { get; }

        ITypedObject MaximumValue { get; }

        ITypedObject DefaultValue { get; }
    }
}