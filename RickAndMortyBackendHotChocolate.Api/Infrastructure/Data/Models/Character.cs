namespace RickAndMortyBackendHotChocolate.Infrastructure.Data.Models;

public class Character
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Status { get; set; }
    
    public string Species { get; set; }
    
    public string Type { get; set; }
    
    public string Gender { get; set; }
    
    public object Origin { get; set; }
    
    public object Location { get; set; }
    
    public string Image { get; set; }
    
    public IEnumerable<string> Episode { get; set; }
    
    public string Url { get; set; }
    
    public string Created { get; set; }
}