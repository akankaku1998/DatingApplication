using DatingApp.Services;
using DatingApp.Data;
using DatingApp.Repositories.Users;
using Microsoft.EntityFrameworkCore;
using DatingApp.Services.Users;
using DatingApp.Services.Account;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddDataProtection();
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddMvc();
builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IAccountService, AccountService>();


var app = builder.Build();
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));
app.MapControllers();
app.Run();


if(app.Environment.IsDevelopment()){
    //Do nothing right now, will use in future
}