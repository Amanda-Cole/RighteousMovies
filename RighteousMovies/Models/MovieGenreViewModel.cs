using Microsoft.AspNetCore.Mvc.Rendering;
using RighteousMovies.Models;
using System.Collections.Generic;

namespace RighteousMovies.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}