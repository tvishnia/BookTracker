using BookTracker.Contracts;

namespace BookTracker.Domain;

public class SearchFantlabResponceContract
{
    // public List<FantlabAttribute> attrs { get; set; }
    // public string error { get; set; }
    // public List<string> fields { get; set; }
    public List<AuthorFantlabSearchContract> matches { get; set; }
}