using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoS3.Models
{
    public class Cliente
    {
        public int ID { get; set; }

        public string nombre { get; set; }

        public DateTime fechaRegistro { get; set; }

        public int edad { get; set; }

    }

    public class EmpDbContext : DbContext
    {
        public EmpDbContext()
        { }

        public DbSet<Cliente> Cliente { get; set; }

    }
}