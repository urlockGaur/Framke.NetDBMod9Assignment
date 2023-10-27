using ContextExample.Data;
using System;

namespace ContextExample.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    private readonly IContext _context;

    public MainService(IContext context)
    {
        _context = context;
    }

    public void Invoke()
    {
        // provide an option to the user to 
        // 1. select by id
        // 2. select by title 
        // 3. find movie by title
        var movie = _context.GetById(1);
        Console.WriteLine($"Your movie is {movie.Title}");
    }
}
