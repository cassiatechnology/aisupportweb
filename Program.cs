using AiSupportWeb;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configurando para o web Assembly reconhecer Enum como String


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://aisupportapi-f0frfeh8abc9g2ey.brazilsouth-01.azurewebsites.net") });

await builder.Build().RunAsync();
