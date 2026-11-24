namespace WebApplication2.Entites
{
    public class Member:GymUser
    {
        public string ? Photo { get; set; }

        public ICollection<Membership>? MemberSubscriptions = new HashSet<Membership>();
    }
}
