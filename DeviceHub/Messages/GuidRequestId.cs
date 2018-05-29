using System;

namespace Alkl.DeviceHub.Messages
{
    public class GuidRequestId : IRequestId
    {
        private Guid _guid;

        public string Id => _guid.ToString();

        public GuidRequestId()
        {
            _guid = Guid.NewGuid();
        }
    }
}