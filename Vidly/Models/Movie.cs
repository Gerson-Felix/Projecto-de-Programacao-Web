﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        public Genre Genre { get; set; }

        [Display(Name = "Género")]
        [Required]
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }

        [Display(Name = "Data de Lançamento")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Número no Stock")]
        public byte NumberInStock { get; set; }
    }
}