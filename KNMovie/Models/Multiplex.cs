using System.ComponentModel.DataAnnotations;

namespace KNMovie.Models
{
    public class Multiplex
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
        public string Locality { get; set; }
        public Auditorium Auditoriam { get; set; } 
        public City City { get; set; }
    }


}
