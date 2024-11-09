using AlbumAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddSingleton<AlbumAPi>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<AlbumAPi>();

app.Run();
