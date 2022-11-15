using System;
namespace Course.Devices
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDocument(string doc)
        {
            Console.WriteLine($"Processing doc {doc}");
        }
        public string Scan()
        {
            return $"Scanning";
        }
    }
}
