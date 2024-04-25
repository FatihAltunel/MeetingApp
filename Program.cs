var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //MVC şablonu oluşturmak için gerekli servis
var app = builder.Build();


//{controller}/{action}/{id?} şemasını ekler
//app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
