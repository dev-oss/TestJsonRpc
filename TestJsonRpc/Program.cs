using TestJsonRpc.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IOilPricesService, OilPricesService>();
// Add services to the container.

builder.Services.AddJsonRpc();

//builder.Services.AddControllers();
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
app.UseJsonRpc();
app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.Run();
