using System.ComponentModel.DataAnnotations;

namespace Examen1_Orlando.Models
{
    public class Ingresos
    {

        [Key]
        public int IngresoId { get; set; }
        public string Concepto { get; set; } = String.Empty;

        public DateTime Fecha { get; set; } = DateTime.Today;
        public string Monto { get; set; } = String.Empty;
    }
}
