using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KNMovie.Models
{
    public class Auditorium
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string AuditoriumName { get; set; }

        public ICollection<AuditoriumScreen> AuditoriumScreens { get; set; }

    }


}
