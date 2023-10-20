using Microsoft.AspNetCore.Identity;
using WebApiWithoutDB;

List<User> users = new List<User>()
{
    new User { Id = Guid.NewGuid().ToString(), Name = "Vasia", Age = 27 },
    new User {Id = Guid.NewGuid().ToString(), Name = "Alex", Age = 22 },
    new User {Id = Guid.NewGuid().ToString(), Name = "Boris", Age = 31 }
};

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Run();