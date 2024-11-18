using Microsoft.EntityFrameworkCore;
using Student.Core.Student;
using Student.Dataccess.Modal;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StudentDB>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConn"),
    b => b.MigrationsAssembly("Student.Core")));


//Add Dependancies
builder.Services.AddTransient(typeof(IStudentRepository), typeof(StudentRepository));
builder.Services.AddTransient<IStudentService, StudentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
