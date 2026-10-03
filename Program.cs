var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseRequestLocalization("en-US");
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();
