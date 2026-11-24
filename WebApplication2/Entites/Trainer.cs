namespace WebApplication2.Entites
{
    public class Trainer:GymUser
    {
        public Speciality Speciality { get; set; }
        public DateTime HireDate { get; set; }

        public ICollection<Session>? Sessions = new HashSet<Session>();

    }
}
