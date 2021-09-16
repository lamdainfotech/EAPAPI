using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EAP.Contracts.IRepositoty.OccupationRepo;
using EAP.Entity.Data;
using EAP.Entity.Models.Occupation;
using Microsoft.EntityFrameworkCore;

namespace EAP.Repository.Repo.OccupationRepo
{
    public class OccupationsRepo : IOccupationsRepo
    {
        private readonly EAPDbContext _context;

        public OccupationsRepo(EAPDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Occupations>> GetAllOccupations()
        {
            return await _context.Occupations
                .OrderBy(o => o.OccupationName)
                .ToListAsync();
        }
    }
}