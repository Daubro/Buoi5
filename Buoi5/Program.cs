using Buoi5.Service;

var builder = WebApplication.CreateBuilder(args);

// Thêm dịch vụ BookService vào container DI
builder.Services.AddSingleton<IBookService, BookService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();
// Cấu hình các middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Book}/{action=Index}/{id?}");

app.Run();
