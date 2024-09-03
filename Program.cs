using MongodbTest;
using MongodbTest.Model;
using MongodbTest.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<UserDetail>(
    builder.Configuration.GetSection("Database"));
// Add services to the container.
builder.Services.AddSingleton<UserService>();
//builder.Services.AddScoped<IUserBL,UserBL>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
