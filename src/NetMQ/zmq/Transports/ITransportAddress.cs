using System;
using System.Net;

namespace NetMQ.zmq.Transports
{
    public interface ITransportAddress
    {
        void Resolve(String name, bool ip4Only);
        IPEndPoint Address { get; }
        String Protocol { get; }
    };
}