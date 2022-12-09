using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zurafworks.Shared.Entities.Abstract;

namespace CustomerTracking.Entities.Concrete
{
    public class MainTenance:EntityBase,IEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public double Amount { get; set; }
        public DateTime? Date { get; set; }
    }
}
