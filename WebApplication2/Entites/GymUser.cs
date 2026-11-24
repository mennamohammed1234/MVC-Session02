using System.Net;
using System.Reflection;

namespace WebApplication2.Entites
{
    public class GymUser:Base
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;
        public DateOnly DateOfBirth { get; set; }

        public Gender Gender { get; set; }
        public Adress Adress { get; set; } = null!;

     
    }
}
