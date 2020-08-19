using System;

namespace KNMovie.Models
{
    public class Screening
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public Multiplex Multiplex { get; set; }
        public DateTime StartTime { get; set; } 


    }

}
