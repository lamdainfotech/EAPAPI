using System.Collections.Generic;
using System.Threading.Tasks;
using EAP.Entity.Models.Occupation;

namespace EAP.Contracts.IRepositoty.OccupationRepo
{
    public interface IOccupationsRepo
    {
        Task<IEnumerable<Occupations>> GetAllOccupations();
    }
}