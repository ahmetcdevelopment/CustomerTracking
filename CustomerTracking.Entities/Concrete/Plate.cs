using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Entities.Abstract;

namespace CustomerTracking.Entities.Concrete
{
    public class Plate:EntityBase,IEntity
    {
        public string? PlateCode { get; set; }
        public string? BrandName { get; set; }
        public string? Color { get; set; }
        public ICollection<MainTenance>? MainTenances { get; set; }
    }
}
