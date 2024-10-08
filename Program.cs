using BlazorApp1;
using BlazorApp1.Components;
using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

/*builder.Services.AddDbContext<MedicalImplantsContext>(options =>
       options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
*/
builder.Services.AddSingleton<IDataHandler<Client>>(sp =>
    new FileDataHandler<Client>("clients.xml"));
builder.Services.AddSingleton<IDataHandler<Implant>>(sp =>
    new FileDataHandler<Implant>("implants.xml"));
builder.Services.AddSingleton<IDataHandler<Order>>(sp =>
    new FileDataHandler<Order>("orders.xml"));





var app = builder.Build();

// Resolve IDataHandler<Implant> using DI
var implantDataHandler = app.Services.GetRequiredService<IDataHandler<Implant>>();

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

var testImplants = TestData.GetImplants();
foreach (var implant in testImplants)
{
    await implantDataHandler.SaveAsync(implant); // Assuming SaveAsync is in your IDataHandler
}



app.Run();
