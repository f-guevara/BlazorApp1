using BlazorApp1;
using BlazorApp1.Components;
using BlazorApp1.Models;
using BlazorApp1.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

/*builder.Services.AddDbContext<MedicalImplantsContext>(options =>
       options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
*/
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IImplantService, ImplantService>();
builder.Services.AddScoped<IOrderService, OrderService>();





var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();





app.Run();
