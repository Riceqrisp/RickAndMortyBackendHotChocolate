using RickAndMortyBackendHotChocolate.Infrastructure.Data.Models;
using RickAndMortyBackendHotChocolate.Infrastructure.Interfaces;

namespace RickAndMortyBackendHotChocolate.Controllers.Queries.GetCharacters;

public class GetCharacterQuery
{
    [UseFiltering(typeof(GetCharactersFilter))]
    public IEnumerable<Character> GetCharacters([Service] ICharactersContext context, string name)
        => context.GetCharacters().Where(c => c.Name.Contains(name));
}