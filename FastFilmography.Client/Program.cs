using FastFilmography.Client.Models.DataAccess;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<ITMDBApi, TMDBApi>();

await builder.Build().RunAsync();
