using System.Linq.Expressions;
using WebApplication2.Entites;

namespace WebApplication2.reposetaries.interfaces
{
    public interface IMembershiprepocs
    {

        Task<bool>inMembership(Expression<Func<Membership, bool>> predicate,CancellationToken ct=default);
    }
}
