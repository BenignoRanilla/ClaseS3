using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DemoS3.Models
{
    public class Cliente
    {
        public int ID { get; set; }

        [StringLength (60, MinimumLength = 3)]
        public string nombre { get; set; }

        [Display (Name = "Fecha de registro")]
        [DataType (DataType.Date)]
        [DisplayFormat (DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaRegistro { get; set; }

        [Range (18,65)]
        public int edad { get; set; }

    }

    public class EmpDbContext : DbContext
    {
        public EmpDbContext()
        { }

        public DbSet<Cliente> Cliente { get; set; }

    }
}