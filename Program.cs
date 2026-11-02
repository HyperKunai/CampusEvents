var builder = WebApplication.CreateBuilder(args);

// Register MVC controller and Razor View services.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Use a controlled error path outside Development.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
