using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Entites
{
    public class Membership:Base
    {

        public int MemberId  { get; set; }

        public Member Member { get; set; } = null!;


        public int PlaneId { get; set; }

        public Plane Plane { get; set; } = null!;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [NotMapped]
        public string Status => StartDate > DateTime.Now ?
            
            "upcoming" : StartDate < DateTime.Now & EndDate > DateTime.Now ? "Active" : "Expired";
    }
}
