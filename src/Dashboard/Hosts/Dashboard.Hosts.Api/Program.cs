using Dashboard.Application.AppServices.Contexts.Comment.Repositories;
using Dashboard.Application.AppServices.Contexts.Comment.Services;
using Dashboard.Application.AppServices.Contexts.Content.Repositories;
using Dashboard.Application.AppServices.Contexts.Content.Services;
using Dashboard.Application.AppServices.Contexts.Image.Repositories;
using Dashboard.Application.AppServices.Contexts.Image.Services;
using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Application.AppServices.Contexts.Post.Services;
using Dashboard.Application.AppServices.Contexts.PostExt.Repositories;
using Dashboard.Application.AppServices.Contexts.PostExt.Services;
using Dashboard.Application.AppServices.Contexts.PublicUser.Repositories;
using Dashboard.Application.AppServices.Contexts.PublicUser.Services;
using Dashboard.Application.AppServices.Contexts.Rating.Repositories;
using Dashboard.Application.AppServices.Contexts.Rating.Services;
using Dashboard.Application.AppServices.Contexts.Tag.Repositories;
using Dashboard.Application.AppServices.Contexts.Tag.Services;
using Dashboard.Contracts.Comment;
using Dashboard.Contracts.Content;
using Dashboard.Contracts.Image;
using Dashboard.Contracts.Post;
using Dashboard.Contracts.PostExt;
using Dashboard.Contracts.PublicUser;
using Dashboard.Contracts.Rating;
using Dashboard.Contracts.Tag;
using Dashboard.Hosts.Api.Controllers;
using Dashboard.Infrastructure.DataAccess.Contexts.Comment.Repositories;
using Dashboard.Infrastructure.DataAccess.Contexts.Content.Repositories;
using Dashboard.Infrastructure.DataAccess.Contexts.Image.Repositories;
using Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories;
using Dashboard.Infrastructure.DataAccess.Contexts.PostExt.Repositories;
using Dashboard.Infrastructure.DataAccess.Contexts.PublicUser.Repositories;
using Dashboard.Infrastructure.DataAccess.Contexts.Rating.Repositories;
using Dashboard.Infrastructure.DataAccess.Contexts.Tag.Repositories;

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
        typeof(PostController),
        typeof(PublicUserController),
        typeof(ContentController),
        typeof(ImageController),
        typeof(TagController),
        typeof(CommentController),
        typeof(RatingController),
        typeof(PostExtController),
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
builder.Services.AddTransient<IPostRepository, PostRepository>(); // Transient -- живет один вызов; новый экземл€р на каждый вызов

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