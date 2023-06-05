using Examen1_Orlando.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Examen1_Orlando.DAL
{
    public class Contexto:DbContext
    {

        public Contexto()
        {

        }

        public object ingresos { get; internal set; }
    }

    /*DbContext
    {
 public DbSet<Ingresos>? Ingresos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source = DATA\Prioridades.db");
    }*/
}
