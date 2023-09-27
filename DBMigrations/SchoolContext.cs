using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMigrations
{
    public class SchoolContext : DbContext
    {
        //entities
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=SchoolDB;User Id=sa;Password=HAL@VSCPassword123;TrustServerCertificate=True;");
        }
    }
}
