using GraphQL;
using grapghql01.IService;
using grapghql01.Models;
using grapghql01.Service;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<Query>();

builder.Services.AddGraphQL(p => SchemaBuilder.New().AddServices(p)
    .AddType<StudentType>()
    .AddQueryType<Query>()
    .Create()
);


var app = builder.Build();

app.UsePlayground(new PlaygroundOptions
{
    QueryPath = "/api",
    Path = "/playground"

});

app.MapGraphQL("/api");

app.MapGet("/", () => "Hello World!");

app.Run();

