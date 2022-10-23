using DotNet___CRUD_Movies_WebApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNet___CRUD_Movies_WebApp.ViewModels
{
    public class MovieFormViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(250)]
        public string Title { get; set; }

        public int Year { get; set; }

        [Range(1,10)]
        public double Rate { get; set; }

        [Required, StringLength(2500)]
        public string StoryLine { get; set; }

        [Display(Name = "Upload Poster")]
        public byte[] Poster { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public IEnumerable<Genre> Geners { get; set; }
    }
}
