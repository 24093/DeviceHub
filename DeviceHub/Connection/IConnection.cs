using System;
using System.Threading.Tasks;
using Alkl.DeviceHub.Messages;

namespace Alkl.DeviceHub.Connection
{
    public interface IConnection
    {
        event EventHandler<ConnectectionStateChangedEventArgs> ConnectionStateChanged;
        
        ConnectionState ConnectionState { get; }

        Task ConnectAsync();

        Task DisconnectAsync();

        Task<IResponse> Send(IRequest request);
    }
}