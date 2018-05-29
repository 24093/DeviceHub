namespace Alkl.DeviceHub.Common
{
    public abstract class NamedType
    {
        public string Name => GetType().Name;
    }
}
