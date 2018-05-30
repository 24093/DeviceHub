using Alkl.DeviceHub.Common;

namespace Alkl.DeviceHub.Messages.Resources
{
    public class ResourceProperty : IResourceProperty
    {
        public string Key { get; }

        public ITypedObject Value { get; }

        public ITypedObject MinimumValue { get; }

        public ITypedObject MaximumValue { get; }

        public ITypedObject DefaultValue { get; }

        public ResourceProperty(string key, ITypedObject value)
        {
            Key = key;
            Value = value;
        }

        public ResourceProperty(string key, ITypedObject value, ITypedObject defaultValue)
            : this(key, value)
        {
            DefaultValue = defaultValue;
        }

        public ResourceProperty(string key, ITypedObject value, ITypedObject minimumValue, ITypedObject maximumValue, ITypedObject defaultValue)
            : this(key, value, defaultValue)
        {
            MinimumValue = minimumValue;
            MaximumValue = maximumValue;
        }
    }
}