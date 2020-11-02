using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using CookBook.WEB.BL;

namespace CookBook.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            Install(builder);
            await builder.Build().RunAsync();
        }

        private static void Install(WebAssemblyHostBuilder builder)
        {
            builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
            new BLWebInstaller().Install(builder.Services);
        }
    }
}
