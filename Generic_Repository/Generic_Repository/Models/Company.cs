using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Repository.Models
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public string Adress { get; set; }
    }
}
