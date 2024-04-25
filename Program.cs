var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //MVC şablonu oluşturmak için gerekli servis
var app = builder.Build();

app.UseStaticFiles(); //wwwroot klasörünün dışarıya açılması için gerekli middleware

//{controller}/{action}/{id?} şemasını ekler
//app.MapDefaultControllerRoute();

app.UseRouting(); //Eklenen middleware'lerin yönlendirmeden önce çalıştırılması için gerekli

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
