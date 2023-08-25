using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlatziEntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddDbContext<WorkContext>(p => p.UseInMemoryDatabase("TaskDB")); //Configurar para usar base de datos en memoria
builder.Services.AddSqlServer<WorkContext>(builder.Configuration.GetConnectionString("cnWork"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapGet("/dbconexion", async ([FromServices] WorkContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Data Base in Memory: " + dbContext.Database.IsInMemory());
});

app.MapGet("/api/works", async ([FromServices] WorkContext dbcontext) =>
{
    return Results.Ok(dbcontext.Works.Include(p => p.Category).Where(p => p.Priority == Priority.Low));
});

app.Run();
