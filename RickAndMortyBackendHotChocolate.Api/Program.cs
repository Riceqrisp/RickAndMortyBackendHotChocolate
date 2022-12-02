using RickAndMortyBackendHotChocolate.Controllers.Queries;
using RickAndMortyBackendHotChocolate.Controllers.Queries.GetCharacters;
using RickAndMortyBackendHotChocolate.Infrastructure.Data.Context;
using RickAndMortyBackendHotChocolate.Infrastructure.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICharactersContext, CharactersContext>();

builder.Services
    .AddGraphQLServer()
    .AddFiltering()
    .AddQueryType<GetCharacterQuery>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGraphQL();

app.MapControllers();

app.Run();