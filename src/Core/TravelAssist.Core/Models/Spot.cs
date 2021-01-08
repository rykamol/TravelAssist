using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAssist.Core.Models
{
    public class Spot
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string PhotoUrl { get; set; }

        public User User { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }

        public Spot()
        {
            Feedbacks = new List<Feedback>();
        }
    }
}
