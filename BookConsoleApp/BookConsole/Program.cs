using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BookConsole
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            // Asynchronously call the GetAndDisplayAsync method from the BookApi class.
            await BookApi.GetAndDisplayAsync();
            Console.ReadLine();
        }

    }
}
