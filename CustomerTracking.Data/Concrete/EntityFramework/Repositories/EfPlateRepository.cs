using CustomerTracking.Data.Abstract;
using CustomerTracking.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Data.Concrete.EntityFramework;

namespace CustomerTracking.Data.Concrete.EntityFramework.Repositories
{
    public class EfPlateRepository : EfEntityRepositoryBase<Plate>, IPlateRepository
    {
        public EfPlateRepository(DbContext context) : base(context)
        {
        }
    }
}
