global using Microsoft.AspNetCore.ResponseCompression;
global using Microsoft.EntityFrameworkCore;
global using ProyectoEmcartago.Shared.Entidades.Entidad_Formato_De_Permisos;
global using ProyectoEmcartago.Shared.Entidades.Entidad_Uso_Epp;
global using ProyectoEmcartago.Server.Data;
global using ProyectoEmcartago.Shared.Entidades.Entidad_Ingreso_y_Salida;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using ProyectoEmcartago.Shared.Entidades.Entidad_PEDSYP;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
