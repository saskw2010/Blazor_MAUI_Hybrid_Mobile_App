using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Taskmote.SharedUI.Services;
using Taskmote.Wasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

Console.WriteLine($"***** Baseaddress is {builder.HostEnvironment.BaseAddress}");

builder.Services.AddSingleton<WeatherForecastService>();

await builder.Build().RunAsync();

