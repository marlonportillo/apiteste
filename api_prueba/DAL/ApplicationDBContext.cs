using api_prueba.DAO.Interfaces.ADM;
using api_prueba.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() { }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbContext DbContext { set; get; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roles> Roles { set; get; }
        public DbSet<Estados> Estados { set; get; }
    }
}
