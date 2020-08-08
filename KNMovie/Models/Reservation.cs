using KNMovie.Models.Authentication;

namespace KNMovie.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Screening Screening { get; set; }

    }
}
