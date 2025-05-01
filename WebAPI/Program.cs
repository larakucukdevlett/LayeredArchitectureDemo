using BO.Abstract;
using BO.Concrete;
using DAO.Abstract;
using DAO.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllers();

//builder.Services.AddSingleton<IProductBo, ProductManager>();
//builder.Services.AddSingleton<IProductDao, EfProductDao>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();
