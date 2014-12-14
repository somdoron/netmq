using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace NetMQ.zmq.Transports.Tcp
{
    class TcpTransport : ITransport
    {
        public bool IsSocketTypeSupported(ZmqSocketType socketType)
        {
            return true;
        }

        public bool SubscribeToAll
        {
            get { return false; }
        }
        
        public ITransportAddress Resolve(string address, bool ip4Only)
        {
            var protocolAddress = new TcpAddress();
            protocolAddress.Resolve(address, ip4Only);

            return protocolAddress;
        }

        public ListenerBase CreateListener(IOThread ioThread, SocketBase socketBase, string address, Options options)
        {
            var listener = new TcpListener(ioThread, socketBase, options);

            try
            {
                listener.SetAddress(address);
            }
            catch (NetMQException ex)
            {
                listener.Destroy();
                throw;
            }
            
            return listener;
        }

        public ConnecterBase CreateConnecter(IOThread ioThread, SessionBase sessionBase, Address address, Options options, bool delayedStart)
        {
            return new TcpConnecter(ioThread, sessionBase, options, address, delayedStart);            
        }
    }
}
