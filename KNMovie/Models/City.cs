using System.ComponentModel.DataAnnotations;

namespace KNMovie.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

    }
}
