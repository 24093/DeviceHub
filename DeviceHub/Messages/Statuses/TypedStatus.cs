using Alkl.DeviceHub.Common;

namespace Alkl.DeviceHub.Messages.Statuses
{
    public abstract class TypedStatus : NamedType, IStatus
    {
        public static IStatus Ok => new Ok();

        public static IStatus Error => new Error();
    }
}