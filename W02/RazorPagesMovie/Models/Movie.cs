using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Movie
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    public string Genre { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public string Rating { get; set; } = string.Empty;
}