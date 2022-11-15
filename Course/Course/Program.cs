using Course.Devices;
using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scanner scanner = new Scanner() { SerialNumber = 1020 };
            Printer printer = new Printer() { SerialNumber = 1030 };
            ComboDevice combo = new ComboDevice() { SerialNumber = 1050 };

            combo.ProcessDocument("Email");
            Console.WriteLine(combo.Scan());
            combo.Print("Email");
        }
    }
}
