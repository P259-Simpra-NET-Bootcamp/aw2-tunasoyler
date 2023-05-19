using Microsoft.EntityFrameworkCore;
using SimpraOdev1.Core.Entities;
using SimpraOdev1.Core.Repositories;
using SimpraOdev1.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraOdev1.Data.Repositories
{
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository
    {
        public StaffRepository(DbContext db) : base(db)
        {
        }

        private StaffDb dbContext
        {
            get { return db as StaffDb; }
        }

        public async Task<IEnumerable<Staff>> GetByCity(string city)
        {
            return await dbContext.Staff.Where(x => x.City == city).ToListAsync();
        }

        public async Task<Staff> GetByEmail(string email)
        {
            return await dbContext.Staff.Where(x => x.Email == email).FirstOrDefaultAsync();
        }
    }
}
