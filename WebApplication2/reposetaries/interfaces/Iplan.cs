using WebApplication2.Entites;

namespace WebApplication2.reposetaries.interfaces
{
    public interface Iplan
    {
        Task<IEnumerable<Plane>> GetPlanesAsync(CancellationToken ct=default);
        Task<Plane> GetPlanebyidasync(int id, CancellationToken ct=default);
        Task<int> UpdateasAsync(CancellationToken ct);
    }
}
