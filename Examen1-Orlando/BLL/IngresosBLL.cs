/*using Examen1_Orlando.DAL;
using Examen1_Orlando.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

*//*namespace Examen1_Orlando.BLL
{
    public class IngresosBLL
    {
        private Contexto _contexto;
        public IngresosBLL(Contexto _contexto)
        {
            this._contexto = _contexto;
        }

        public bool Existe(int IngresoId)
        {
            return _contexto.ingresos.Any(p => p.IngresoId == IngresoId);
        }
        public bool ExisteConcepto(string conc)
        {

            return _contexto.ingresos.Any(p => p.Concepto == conc);

        }

        public bool Insertar(Ingresos ingresos)
        {
            _contexto.ingresos.Add(ingresos);
            return _contexto.SaveChanges() > 0;
        }

        public bool Modificar(Ingresos ingresos)
        {
            _contexto.Entry(ingresos).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;
        }

        public bool Guardar(Ingresos ingresos)
        {
            if (!Existe(ingresos.IngresoId))
            {
                if (!ExisteFecha(ingresos.Fecha))
                {
                    return this.Insertar(ingresos);
                }
                else
                {
                    return false;
                }
            }

            else
                return this.Modificar(ingresos);
        }

        private bool ExisteFecha(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Ingresos ingresos)
        {
            _contexto.Entry(ingresos).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }

        public Ingresos? Buscar(int IngresoId) => _contexto.ingresos.Where(b => b.PrioridadId == IngresoId).AsNoTracking().SingleOrDefault();
        public List<Ingresos> GetList(Expression<Func<Ingresos, bool>> criterio)
        {
            return _contexto.ingresos.AsNoTracking().Where(criterio).ToList();
        }

    }
}*/