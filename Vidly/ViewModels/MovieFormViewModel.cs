using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vitty.Models;

namespace Vitty.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
     
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Id do Género")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Data de Lancamento")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Número no Stock")]
        [Required]
        public byte? NumberInStock { get; set; }

        public MovieFormViewModel() { Id = 0; }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }

        public string Title
        {
            get { return Id != 0 ? "Edit Movie" : "New Movie"; }
        }
    }
}