using Generic_Repository.Data;
using Generic_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Repository.Repositories
{
    public class CompanyRepository :GenericRepository<Company> , ICompanyRepository
    {
        public CompanyRepository(ApplicationDbContext _dbContext) :base(_dbContext)
        {

        }
        public async Task<Company> GetFirstCompany()
        {
            return await  GetAll().FirstOrDefaultAsync();
        }
    }
}
