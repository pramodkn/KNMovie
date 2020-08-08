using System.ComponentModel.DataAnnotations;

namespace KNMovie.Models
{
    public class AuditoriumScreen
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string ScreenName { get; set; }
        public int Capacity { get; set; }

    }


}
