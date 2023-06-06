using Examen1_Orlando.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Examen1_Orlando.DAL
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Ingresos> ingresos { get; set; }

    }

}
