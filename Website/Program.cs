using Website;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");




//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress + "api/") });
//if (builder.HostEnvironment.IsDevelopment())

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://dummyapi.io/data/v1/") });


builder.Services.AddMudServices();




await builder.Build().RunAsync();
