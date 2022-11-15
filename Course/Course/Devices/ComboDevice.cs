using System;

namespace Course.Devices
{
    internal class ComboDevice : Device, IPrinter, IScanner
    {
        public override void ProcessDocument(string doc)
        {
            Console.WriteLine($"Combo process {doc}");
        }
        public void Print(string doc)
        {
            Console.WriteLine($"Combo print {doc}");
        }
        public string Scan()
        {
            return "Combo scanning";
        }
    }
}
