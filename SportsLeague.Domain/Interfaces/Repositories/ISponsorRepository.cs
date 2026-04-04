using SportsLeague.Domain.Entities;

namespace SportsLeague.Domain.Interfaces.Repositories;

public interface ISponsorRepository : IGenericRepository<Sponsor>
{
    Task<bool> ExistsByNameAsync(string name);
    Task<Sponsor?> GetByNameAsync(string name);
    Task<IEnumerable<Sponsor>> GetAllWithTournamentsAsync();
    Task<Sponsor?> GetByIdWithTournamentsAsync(int id);
}