using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using oj.webapp;
using oj.webapp.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient("ProblemsClient", client =>
{
    client.BaseAddress = new Uri("http://localhost/api/problem");
});

builder.Services.AddTransient<IProblemService, ProblemService>();

await builder.Build().RunAsync();
