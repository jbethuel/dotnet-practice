using dotnet_practice.Models;
using dotnet_practice.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.Configure<BookStoreDatabaseSettings>(
//     builder.Configuration.GetSection("BookStoreDatabase")
// );
builder.Services.AddControllers();
builder.Services.AddSingleton<BooksService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
