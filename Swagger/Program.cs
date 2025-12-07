using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo()
    {
        Title = "Swagger App",
        Version = "v1",
        Description = "This is a swagger app",
        //Contact = new OpenApiContact()
        //{
        //    Url = new Uri("http://localhost:5000/swagger/index.html"),
        //    Email="ganeshkate520@gmail.com",
        //    Name= "Swagger App",
        //}
    });

    // XML comments file
    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);

});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1 Test");
        c.RoutePrefix = string.Empty;
    });
}



app.MapControllers();
app.Run();