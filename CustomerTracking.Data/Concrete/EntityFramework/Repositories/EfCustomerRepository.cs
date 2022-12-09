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
    public class EfCustomerRepository : EfEntityRepositoryBase<Customer>, ICustomerRepository
    {
        public EfCustomerRepository(DbContext context) : base(context)
        {
        }
    }
}
