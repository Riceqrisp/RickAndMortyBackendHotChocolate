using HotChocolate.Data.Filters;
using RickAndMortyBackendHotChocolate.Infrastructure.Data.Models;

namespace RickAndMortyBackendHotChocolate.Controllers.Queries.GetCharacters;

public class GetCharactersFilter : FilterInputType<Character>
{
    protected override void Configure(IFilterInputTypeDescriptor<Character> descriptor)
    {
        descriptor.BindFieldsExplicitly();
        descriptor.AllowAnd();
        descriptor.AllowOr();
    }
}