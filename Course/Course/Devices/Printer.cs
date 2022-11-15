using System;

namespace Course.Devices
{
    internal class Printer : Device, IPrinter
    {
        public override void ProcessDocument(string doc)
        {
            Console.WriteLine($"Process document {doc}");
        }

        public void Print(string doc)
        {
            Console.WriteLine($"Printing {doc}");
        }
    }
}
