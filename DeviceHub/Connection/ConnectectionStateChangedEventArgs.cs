using Alkl.DeviceHub.Common;

namespace Alkl.DeviceHub.Connection
{
    public class ConnectectionStateChangedEventArgs : StateChangedEventArgs<ConnectionState>
    {
        public ConnectectionStateChangedEventArgs(ConnectionState previousState, ConnectionState currentState)
            : base(previousState, currentState)
        {
        }
    }
}