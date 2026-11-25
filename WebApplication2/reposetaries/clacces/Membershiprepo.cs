using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApplication2.Dbcontext;
using WebApplication2.Entites;

namespace WebApplication2.reposetaries.interfaces
{
    public class Membershiprepo : IMembershiprepocs
    {
        private Gymcontxt _gymcontext;
        public Membershiprepo(Gymcontxt gymcontext) { _gymcontext = gymcontext; }
        public async Task<bool> inMembership(Expression<Func<Membership, bool>> predicate, CancellationToken ct = default)
        {
            var membership = _gymcontext.Membership.AnyAsync(predicate, ct);
            return await membership;
        }
    }
}
