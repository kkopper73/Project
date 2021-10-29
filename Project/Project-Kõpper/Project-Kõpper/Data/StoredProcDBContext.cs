using Microsoft.EntityFrameworkCore;
using Project_Kõpper.Controllers;
using Project_Kõpper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Kõpper.Data
{
    public class StoredProcDBContext: DbContext
    {
        public StoredProcDBContext(DbContextOptions<StoredProcDBContext> options)
            : base(options) { }

        public DbSet<Employee> Employee { get; set; }
    }
}
