using MongoDB.Driver;
using MongodbTest;
using MongodbTest.Model;
using MongodbTest.Services;
using MongodbTest.Common;
using MongodbTest.Services.Interface;

var builder = WebApplication.CreateBuilder(args);



//builder.Services.AddSingleton<IMongoClient>(sp =>
//{
//    return new MongoClient("mongodb://localhost:27017");
//});
//builder.Services.AddScoped(x =>
//{
//    var client = x.GetRequiredService<IMongoClient>();
//    return client.GetDatabase("TestProject");
//});
// Add services to the container.
builder.Services.AddSingleton<MongoDbService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IMasterService, MasterService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true).AddJsonOptions(opt => opt.JsonSerializerOptions.PropertyNamingPolicy = null);
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



