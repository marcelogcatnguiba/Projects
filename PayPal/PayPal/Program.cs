using PayPal.Entities;
using PayPal.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Security.Principal;

namespace PayPal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalvalue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int installment = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalvalue);
            ContractService contractService = new ContractService(new PayPalService());
            contractService.ProcessContract(contract, installment);
            
            foreach (Installment i in contract.Installment)
            {
                Console.WriteLine(i);
            }

        }
    }
}
