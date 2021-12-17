using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Repository.Models
{
    public class Branch : BaseEntity
    {
        public string Code { get; set; }
        public int Capacity { get; set; }
    }
}
