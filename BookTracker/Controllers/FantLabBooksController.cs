using BookTracker.Contracts;
using BookTracker.Logic;
using Microsoft.AspNetCore.Mvc;

namespace BookTracker.Controllers;

[Produces("application/json")]
[ApiController]
[Route("api/[controller]")]
public class FantLabBooksController : ControllerBase
{
    private FantLabBooksService _fantLabBooksService;

    public FantLabBooksController(FantLabBooksService fantLabBooksService)
    {
        _fantLabBooksService = fantLabBooksService;
    }

    /// <summary>
    /// Search for the author by name
    /// </summary>
    /// <returns>Result</returns>
    /// <response code="200">Success</response>
    [HttpGet]
    public async Task<ActionResult<List<Author>>> SearchAuthors([FromQuery]string name, CancellationToken cancellationToken)
    {
        var result = await _fantLabBooksService.SearchAuthors(
            new SearchAuthorsQuery(
                AuthorName: name,
                PageNum: 1), 
           cancellationToken);
        
        return Ok(result);
    }
}