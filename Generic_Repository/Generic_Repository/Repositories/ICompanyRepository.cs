using Generic_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Repository.Repositories
{
    public interface ICompanyRepository :IRepository<Company>
    {
        Task<Company> GetFirstCompany();
    }
}
