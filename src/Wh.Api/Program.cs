using Wh.Application;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.ConfiguredDbContext(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.MapDefaultEndpoints();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
