using SimpraOdev1.Core.Repositories;
using SimpraOdev1.Core.UnitOfWork;
using SimpraOdev1.Data.Context;
using SimpraOdev1.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraOdev1.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StaffDb db;
        private StaffRepository staffRepository;

        public UnitOfWork(StaffDb _db)
        {
            db = _db;
        }
        public IStaffRepository Staff => staffRepository = staffRepository ?? new StaffRepository(db);


        public async Task<int> CommitAsync()
        {
            return await db.SaveChangesAsync();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
