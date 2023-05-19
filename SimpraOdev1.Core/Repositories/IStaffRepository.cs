using SimpraOdev1.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraOdev1.Core.Repositories
{
    public interface IStaffRepository : IGenericRepository<Staff>
    {
        Task<IEnumerable<Staff>> GetByCity(string city);
        Task<Staff> GetByEmail(string email);
    }
}
