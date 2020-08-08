using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KNMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        public int RunningTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public ICollection<Genre> Genre { get; set; }

    }
}
