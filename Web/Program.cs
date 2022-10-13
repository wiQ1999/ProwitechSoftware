using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddApplicationServices();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseExceptionHandler("/ErrorDev");
}
else if (app.Environment.IsProduction())
{
    app.UseExceptionHandler("/ErrorProd");
}
app.UseHsts();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
