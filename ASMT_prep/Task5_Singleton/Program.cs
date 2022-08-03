using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Task5_Singleton
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()                
                .AddSingleton<IUserFetcher, UserFetcher>()               
                .BuildServiceProvider();

            var userFetcher = serviceProvider.GetService<IUserFetcher>();
          
            Console.WriteLine(await userFetcher.Fetch());
        }
    }
}
