global using Microsoft.AspNetCore.Components.Web;
global using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
global using MudBlazor.Services;
global using ProyectoEmcartago.Client;
global using ProyectoEmcartago.Shared.Entidades.Entidad_Formato_De_Permisos;
global using Microsoft.AspNetCore.Components;
global using System.Text;
global using System.Text.Json;
global using ProyectoEmcartago.Client.Repositorios.RepositorioFormatoPermisos;
global using ProyectoEmcartago.Client.Mensajes;
global using Microsoft.JSInterop;
global using ProyectoEmcartago.Client.Mensajes.Alertas;
global using ProyectoEmcartago.Shared.Entidades.Entidad_Uso_Epp;
global using System.Net.Http.Json;
global using ProyectoEmcartago.Client.Repositorios.RepositorioUsoEpp;
global using ProyectoEmcartago.Shared.Entidades.Entidad_Ingreso_y_Salida;
global using ProyectoEmcartago.Client.Repositorios.RepositorioIngresoySalida;
global using ProyectoEmcartago.Shared.Entidades.Entidad_PEDSYP;
global using ProyectoEmcartago.Client.Repositorios.RepositorioPEDSYP;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IRepositorioPermisos, RepositorioPermisos>();
builder.Services.AddScoped<IRepositorioUsoEpp, RepositorioUsoEpp>();
builder.Services.AddScoped<IRepositorioIngresoySalida, RepositorioIngresoySalida>();
builder.Services.AddScoped<IRepositorioPEDSYP, RepositorioPEDSYP>();
builder.Services.AddScoped<IMostrarMensajes, MostrarMensajes>();
builder.Services.AddMudServices();

await builder.Build().RunAsync();
