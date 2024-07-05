// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var builder = WebApplication.CreateBuilder(args);

//add services to the container
builder.Services.AddControllersWithViews();

var app:WebApplication = builder.Build();

//Confige the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("Home/Error");
    //The defaul HSTS valoue is 30 days. o may want to chage this for production scenarius, see https://aka.ms/aspnecore-hsts
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    nameof: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();