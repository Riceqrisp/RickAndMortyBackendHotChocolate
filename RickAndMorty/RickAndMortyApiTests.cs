using System.Threading.Tasks;
using RickAndMortyBackendHotChocolate.Controllers.Queries.GetCharacters;

namespace RickAndMorty;

public class SimpleTests
{
    [Fact]
    public async Task SchemaChangeTest()
    {
        var schema = await new ServiceCollection()
            .AddGraphQL()
            .AddQueryType<GetCharacterQuery>()
            .AddFiltering()
            .BuildSchemaAsync();
        schema.ToString().MatchSnapshot();
    }

    [Fact]
    public async Task FetchCharacter()
    {
        var result = await new ServiceCollection()
            .AddGraphQL()
            .AddQueryType<GetCharacterQuery>()
            .AddFiltering()
            .ExecuteRequestAsync(
            "{ query { character { name } } }");

        result.ToJson().MatchSnapshot();
    }
}
