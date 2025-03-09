using BookTracker.Contracts;
using BookTracker.Domain;

namespace BookTracker.Logic;

public record SearchAuthorsQuery(
    string AuthorName,
    int PageNum = 1
);
public class FantLabBooksService 
{
    private static HttpClient _sharedClient = new()
    {
        BaseAddress = new Uri("https://api.fantlab.ru"),
    };
    public async Task<List<AuthorFantlabSearchContract>> SearchAuthors(SearchAuthorsQuery query, CancellationToken cancellationToken) //async
    {
        // GET /search-autors?q={query}&page={page}&onlymatches={0|1}
        using HttpResponseMessage 
            response = await _sharedClient.GetAsync("search-autors?q="+query.AuthorName, cancellationToken);
    
        response.EnsureSuccessStatusCode()
            .WriteRequestToConsole();

        var jsonResponse = await response.Content.ReadFromJsonAsync<SearchFantlabResponceContract>(cancellationToken);
        // var stringResponse = await response.Content.ReadAsStringAsync();
        // Console.WriteLine($"{jsonResponse}\n");
        // var list = new List<SearchFantlabResponceContract>();
        // list.Add(new SearchFantlabResponceContract
        // {
        //     Name = "Tatiana",
        //     Surname = "Vishniakova"
        // });
        // list.Add(new SearchFantlabResponceContract
        // {
        //     Name = "Jack",
        //     Surname = "London"
        // });
        return jsonResponse!.matches; 
    } 
    static async Task GetAsync(HttpClient httpClient)
    {
        using HttpResponseMessage response = await httpClient.GetAsync("todos/3");
    
        // response.EnsureSuccessStatusCode()
        //     .WriteRequestToConsole();
    
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"{jsonResponse}\n");

        // Expected output:
        //   GET https://jsonplaceholder.typicode.com/todos/3 HTTP/1.1
        //   {
        //     "userId": 1,
        //     "id": 3,
        //     "title": "fugiat veniam minus",
        //     "completed": false
        //   }
    }
}

static class HttpResponseMessageExtensions
{
    internal static void WriteRequestToConsole(this HttpResponseMessage response)
    {
        if (response is null)
        {
            return;
        }

        var request = response.RequestMessage;
        Console.Write($"{request?.Method} ");
        Console.Write($"{request?.RequestUri} ");
        Console.WriteLine($"HTTP/{request?.Version}");        
    }
}