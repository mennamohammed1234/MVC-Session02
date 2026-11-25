using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using WebApplication2.Dbcontext;
using WebApplication2.Entites;
using WebApplication2.reposetaries.interfaces;

namespace WebApplication2.reposetaries.clacces
{
    public class Plan : Iplan
    {
        private Gymcontxt _dbcontext;
        public Plan(Gymcontxt gymcontxt)
        {
            _dbcontext = gymcontxt;
        }

        public async Task<Entites.Plane> GetPlanebyidasync(int id, CancellationToken ct = default)
        {
            var plan = _dbcontext.planes.FindAsync(id,ct);
            return await plan;
        }

        public async Task<IEnumerable<Entites.Plane>> GetPlanesAsync(CancellationToken ct = default)
        {
            var plans = _dbcontext.Set<Entites.Plane>().ToListAsync(ct);
            return await plans;
        }

     
       public async Task<int> UpdateasAsync(CancellationToken ct)
        {
            try
            {
              return await  _dbcontext.SaveChangesAsync(ct);
            }
            catch {

                     return 0;
            }
        }
    }
}
