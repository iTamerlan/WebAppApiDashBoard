using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Application.AppServices.Contexts.Post.Services;
using Dashboard.Application.AppServices.Contexts.Repositories;
using Dashboard.Application.AppServices.Contexts.Services;
using Dashboard.Contracts;
using Dashboard.Contracts.Attachment;
using Dashboard.Hosts.Api.Controllers;
using Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories;
using Dashboard.Infrastructure.DataAccess.Contexts.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(s =>
{
    var includeDocsTypesMarkers = new[]
    {
        typeof(PostDto),
        typeof(CommentDto),
        typeof(PostExtDto),
        typeof(RatingDto),
        typeof(ContentDto),
        typeof(ImageDto),
        typeof(PublicUserDto),
        typeof(TagDto),
        typeof(PostController)
    };
            
    foreach (var marker in includeDocsTypesMarkers)
    {
        var xmlName = $"{marker.Assembly.GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlName);
        
        Console.WriteLine(xmlPath);    
        
        if (File.Exists(xmlPath))
            s.IncludeXmlComments(xmlPath);
    }
});

builder.Services.AddTransient<IPostService, PostService>();
builder.Services.AddTransient<IPostRepository, PostRepository>();

builder.Services.AddTransient<IContentService, ContentService>();
builder.Services.AddTransient<IContentRepository, ContentRepository>();
builder.Services.AddTransient<IImageService, ImageService>();
builder.Services.AddTransient<IImageRepository, ImageRepository>();
builder.Services.AddTransient<IPublicUserService, PublicUserService>();
builder.Services.AddTransient<IPublicUserRepository, PublicUserRepository>();
builder.Services.AddTransient<ITagService, TagService>();
builder.Services.AddTransient<ITagRepository, TagRepository>();
builder.Services.AddTransient<ICommentService, CommentService>();
builder.Services.AddTransient<ICommentRepository, CommentRepository>();
builder.Services.AddTransient<IRatingService, RatingService>();
builder.Services.AddTransient<IRatingRepository, RatingRepository>();
builder.Services.AddTransient<IPostExtService, PostExtService>();
builder.Services.AddTransient<IPostExtRepository, PostExtRepository>();

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