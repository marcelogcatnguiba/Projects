using RestSharp;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace PokemonDays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            InvocarGet();

            static void InvocarGet()
            {
                
                var client = new RestClient($"https://pokeapi.co/api/v2/pokemon");

                var request = new RestRequest("", Method.Get);

                var response = client.Execute(request);

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine(response.Content);
                }
                else
                {
                    Console.WriteLine(response.ErrorMessage);
                }
            }

            
        }
    }
}
