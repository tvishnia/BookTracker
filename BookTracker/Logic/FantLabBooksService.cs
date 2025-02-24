// using MediatR;
// using Microsoft.EntityFrameworkCore;

using BookTracker.Contracts;

namespace BookTracker.Logic;

public record SearchAuthorsQuery(
    string AuthorName,
    int PageNum = 1
);
public class FantLabBooksService 
{
    public  List<Author> SearchAuthors(SearchAuthorsQuery query, CancellationToken cancellationToken) //async
    {
        // GET /search-autors?q={query}&page={page}&onlymatches={0|1}

        var list = new List<Author>();
        list.Add(new Author
        {
            Name = "Tatiana",
            Surname = "Vishniakova"
        });
        list.Add(new Author
        {
            Name = "Jack",
            Surname = "London"
        });
        return list; 
    } 
}

