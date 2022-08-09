using TestJsonRpc.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddJsonRpc();
builder.Services.AddSingleton<IOilPricesService, OilPricesService>();

var app = builder.Build();

app.UseJsonRpc();
app.Run();