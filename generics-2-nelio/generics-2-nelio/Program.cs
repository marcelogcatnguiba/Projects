using generics_2_nelio.Entities;
using generics_2_nelio.Services;
using System;

try
{
    Console.Write("Enter N: ");
    int n = int.Parse(Console.ReadLine());

    List<Products> list = new List<Products>();

    for (int i = 0; i < n; i++)
    {
        string[] vect = Console.ReadLine().Split(',');
        string product = vect[0];
        int price = int.Parse(vect[1]);

        list.Add(new Products(product, price));
    }

    CalculationService calculation = new CalculationService();
    Console.WriteLine(calculation.Max(list));
}
catch (Exception ex)
{

}
