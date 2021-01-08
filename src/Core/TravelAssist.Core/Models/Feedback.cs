using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAssist.Core.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        [ForeignKey("Spot")]
        public int SpotId { get; set; }

        public Spot Spot { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
