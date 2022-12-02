using RickAndMortyBackendHotChocolate.Infrastructure.Data.Models;
using RickAndMortyBackendHotChocolate.Infrastructure.Interfaces;

namespace RickAndMortyBackendHotChocolate.Infrastructure.Data.Context;

public class CharactersContext : ICharactersContext
{
    public IEnumerable<Character?> GetCharacters() =>
        new Character[]
        {
            new Character
            {
                Id = 1,
                Name = "Rick Sanchez",
                Status = "Alive",
                Species = "Human",
                Type = "",
                Gender = "male",
                Origin = "Earth",
                Location = "Mars",
                Image = "https://rickandmortyapi.com/api/character/avatar/1.jpeg",
                Episode = new List<string>{"ep1","ep2"},
                Url = "",
                Created = "1.1.2000"
            },
            new Character
            {
                Id = 2,
                Name = "Morty Smith",
                Status = "Alive",
                Species = "Human",
                Type = "",
                Gender = "male",
                Origin = "Earth",
                Location = "Parallel Universe of Toilet Paper",
                Image = "https://rickandmortyapi.com/api/character/avatar/2.jpeg",
                Episode = new List<string>{"ep1","ep2"},
                Url = "",
                Created = "1.1.2000"
            },
            new Character
            {
                Id = 3,
                Name = "Summer Smith",
                Status = "Alive",
                Species = "Human",
                Type = "",
                Gender = "female",
                Origin = "Earth",
                Location = "Texas",
                Image = "https://rickandmortyapi.com/api/character/avatar/3.jpeg",
                Episode = new List<string>{"ep1","ep2"},
                Url = "",
                Created = "1.1.2000"
            },
            new Character
            {
                Id = 4,
                Name = "Alien4",
            },
            new Character
            {
                Id = 5,
                Name = "Alien5",
            },
            new Character
            {
                Id = 6,
                Name = "Alien6",
            },
        };
}