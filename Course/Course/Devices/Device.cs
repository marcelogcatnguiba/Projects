
namespace Course.Devices
{
    abstract class Device
    {
        public double SerialNumber { get; set; }

        public abstract void ProcessDocument(string doc);
    }
}
