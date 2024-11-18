using Microsoft.EntityFrameworkCore;
using Student.Core.Student;
using Student.Dataccess.Modal;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StudentDB>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConn")));



//Add Dependancies
builder.Services.AddTransient(typeof(IStudentRepository), typeof(StudentRepository));
builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
