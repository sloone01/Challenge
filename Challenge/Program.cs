using System;
using System.Net.Http;
using Challenge;
using Challenge.Core.Shared;
using Challenge.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(typeof(IService<Student>), typeof(StudentService));
builder.Services.AddScoped(typeof(IService<Country>), typeof(CountryService));
builder.Services.AddScoped(typeof(IService<ClassRecord>), typeof(ClassService));

builder.Services.AddMudServices();
await builder.Build().RunAsync();
