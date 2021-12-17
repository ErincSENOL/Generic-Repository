using Generic_Repository.Models;
using Generic_Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Repository.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _respository;
        public CompanyController(ICompanyRepository repository)
        {
            _respository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var company = new Company { Name = "Alaz", Adress = "Turkey" };
            var company1 = new Company { Name = "Erinç", Adress = "Turkey" };

            await _respository.Create(company);
            await _respository.Create(company1);

            var model = _respository.GetAll();

            return View(model);
        }
    }
}
