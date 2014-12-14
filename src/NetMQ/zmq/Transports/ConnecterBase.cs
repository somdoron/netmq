namespace NetMQ.zmq.Transports
{
    public abstract class ConnecterBase : Own
    {
        protected ConnecterBase(IOThread ioThread, Options options) : base(ioThread, options)
        {
        }
    }
}