using RickAndMortyBackendHotChocolate.Infrastructure.Data.Models;

namespace RickAndMortyBackendHotChocolate.Infrastructure.Interfaces;

public interface ICharactersContext
{
    IEnumerable<Character?> GetCharacters();
}