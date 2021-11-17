using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MaNguonMo.Models;

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<MaNguonMo.Models.Movie> Movie { get; set; }

        public DbSet<MaNguonMo.Models.Student> Student { get; set; }

        public DbSet<MaNguonMo.Models.Person> Person { get; set; }

        public DbSet<MaNguonMo.Models.Product> Product { get; set; }

        public DbSet<MaNguonMo.Models.Employee> Employee { get; set; }
        public DbSet<DemoMVC.Models.Person> people {get; set;}
    }
