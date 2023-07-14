using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MSFabricBots.Copilots;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://kinfey-urban-engine-qgjvj6pq4qxc47xg-7071.preview.app.github.dev/") });


await builder.Build().RunAsync();
