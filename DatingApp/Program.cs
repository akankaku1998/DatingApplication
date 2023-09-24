using DatingApp.BusinessLogicLayer;
using DatingApp.Data;
using DatingApp.DataAccessLayer.Users;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddMvc();
builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddTransient<UsersBusniessLayer>();

var app = builder.Build();