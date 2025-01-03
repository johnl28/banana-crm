using BananaApi.Contexts;
using BananaApi.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ContactContext>(options => 
    options.UseMySql(builder.Configuration.GetConnectionString("MysqlServer"), 
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MysqlServer"))));

builder.Services.AddScoped<IContactRepository, ContactRepository>();

if(builder.Environment.IsDevelopment()) {
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(name: MyAllowSpecificOrigins,
                        policy  =>
                        {
                            policy.AllowAnyOrigin();
                            policy.AllowAnyHeader();
                        });
    });
}



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
