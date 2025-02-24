namespace BookTracker.Contracts;

public class Author
{
    public string Name { get; set; }  = string.Empty;
    public string Surname { get; set; }  = string.Empty;
    public List<Work> Works { get; set; } = [];
}