//using Dashboard.Application.AppServices.Contexts.Post.Repositories;
//using Dashboard.Application.AppServices.Contexts.Post.Services;
//using Dashboard.Contracts;
using Dashboard.Hosts.Api.Controllers;
//using Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(s =>
{
    var includeDocsTypesMarkers = new[]
    {
        //typeof(PostDto), // TO FUTURE
        //typeof(PostController) // TO FUTURE
    };

    foreach (var marker in includeDocsTypesMarkers)
    {
        var xmlName = $"{marker.Assembly.GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlName);

        if (File.Exists(xmlPath))
            s.IncludeXmlComments(xmlPath);
    }
});

//builder.Services.AddTransient<IPostService, PostService>(); // TO FUTURE
//builder.Services.AddTransient<IPostRepository, PostRepository>(); // TO FUTURE

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