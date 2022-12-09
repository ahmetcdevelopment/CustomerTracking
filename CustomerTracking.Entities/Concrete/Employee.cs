using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Entities.Abstract;

namespace CustomerTracking.Entities.Concrete
{
    public class Employee:EntityBase,IEntity
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public float Salary { get; set; }
    }
}
