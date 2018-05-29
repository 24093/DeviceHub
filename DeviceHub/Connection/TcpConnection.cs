using System.Net;
using System.Threading.Tasks;
using Alkl.DeviceHub.Messages;

namespace Alkl.DeviceHub.Connection
{
    public class TcpConnection : Connection
    {
        private IPEndPoint _endPoint;

        public TcpConnection(IPEndPoint endPoint)
        {
            _endPoint = endPoint;
        }

        protected override async Task DoConnectAsync()
        {
            await Task.Delay(1000);
        }

        protected override async Task DoDisconnectAsync()
        {
            await Task.Delay(1000);
        }

        protected override Task<IResponse> Send(IRequest request)
        {


        }
    }
}