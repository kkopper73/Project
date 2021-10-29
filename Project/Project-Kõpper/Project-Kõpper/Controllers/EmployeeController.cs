using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Kõpper.Data;
using Project_Kõpper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Kõpper.Controllers
{
    public class EmployeeController : Controller
    {
        public StoredProcDBContext _context;
        public EmployeeController(StoredProcDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IEnumerable<Employee> SearchResult()
        {
            var result = _context.Employee
                .FromSqlRaw<Employee>("spSearchEmploayees")
                .ToList();

            return result;
                
        }
    }
}
