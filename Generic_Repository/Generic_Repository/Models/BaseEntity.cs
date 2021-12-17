using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Repository.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
