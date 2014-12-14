namespace NetMQ.zmq.Transports
{
    public interface ITransport
    {
        bool IsSocketTypeSupported(ZmqSocketType socketType);

        bool SubscribeToAll { get; }

        ITransportAddress Resolve(string address, bool ip4Only);

        ListenerBase CreateListener(IOThread ioThread, SocketBase socketBase, string address, Options options);

        ConnecterBase CreateConnecter(IOThread ioThread, SessionBase sessionBase, Address address, Options options, bool delayedStart);
    }
}
