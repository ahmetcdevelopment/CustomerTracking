using CustomerTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Data.Abstract;

namespace CustomerTracking.Data.Abstract
{
    public interface IMainTenanceRepository:IEntityRepository<MainTenance>
    {
    }
}
