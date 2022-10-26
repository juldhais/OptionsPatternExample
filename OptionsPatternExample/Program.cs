using OptionsPatternExample;

var builder = WebApplication.CreateBuilder(args);

// company options configuration
builder.Services.Configure<CompanyOptions>(builder.Configuration.GetSection("CompanyOptions"));

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.MapControllers();
app.Run();