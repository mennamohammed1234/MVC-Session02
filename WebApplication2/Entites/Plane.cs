using System.Numerics;
using System.Reflection;
using System.Reflection.PortableExecutable;

namespace WebApplication2.Entites
{
    public class Plane:Base
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int DurationDays { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Membership> MemberSubscriptions = new HashSet<Membership>();

    }
}
