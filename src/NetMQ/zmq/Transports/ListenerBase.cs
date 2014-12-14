namespace NetMQ.zmq.Transports
{
    public abstract class ListenerBase : Own
    {        
        protected ListenerBase(IOThread ioThread, Options options) : base(ioThread, options)
        {
        }

        public abstract int Port { get;  }
        public abstract string Address { get; }
    }
}