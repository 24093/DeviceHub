using System;
using System.Threading.Tasks;
using Alkl.DeviceHub.Messages;

namespace Alkl.DeviceHub.Connection
{
    public abstract class Connection : IConnection
    {
        public event EventHandler<ConnectectionStateChangedEventArgs> ConnectionStateChanged;

        public ConnectionState ConnectionState { get; private set; }

        public async Task ConnectAsync()
        {
            if (ConnectionState == ConnectionState.Connected)
            {
                return;
            }

            var previousState = ConnectionState;
            ConnectionState = ConnectionState.Connecting;
            ConnectionStateChanged?.Invoke(this, new ConnectectionStateChangedEventArgs(previousState, ConnectionState));

            await DoConnectAsync();

            previousState = ConnectionState;
            ConnectionState = ConnectionState.Connected;
            ConnectionStateChanged?.Invoke(this, new ConnectectionStateChangedEventArgs(previousState, ConnectionState));
        }

        protected abstract Task DoConnectAsync();

        public async Task DisconnectAsync()
        {
            if (ConnectionState == ConnectionState.Disconnected)
            {
                return;
            }

            var previousState = ConnectionState;
            ConnectionState = ConnectionState.Disconnecting;
            ConnectionStateChanged?.Invoke(this, new ConnectectionStateChangedEventArgs(previousState, ConnectionState));

            await DoDisconnectAsync();

            previousState = ConnectionState;
            ConnectionState = ConnectionState.Disconnected;
            ConnectionStateChanged?.Invoke(this, new ConnectectionStateChangedEventArgs(previousState, ConnectionState));
        }

        protected abstract Task DoDisconnectAsync();

        protected abstract Task<IResponse> Send(IRequest request);
    }
}