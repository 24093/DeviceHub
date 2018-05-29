using Alkl.DeviceHub.Common;

namespace Alkl.DeviceHub.Messages.Methods
{
    public abstract class TypedMethod : NamedType, IMethod
    {
        public static IMethod Get => new Get();

        public static IMethod Set => new Set();
    }
}