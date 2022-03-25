using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class MantenimientoList
    {
        public List<Mantenimiento> mantenimientoList { get; set; }

        public MantenimientoList()
        {
            mantenimientoList = new List<Mantenimiento>();
        }
        public void Agregar(Mantenimiento pMantenimiento)
        {
            mantenimientoList.Add(pMantenimiento);
        }
        public Mantenimiento Buscar(int pId)
        {
            if (mantenimientoList == null)
            {
                return null;
            }
            foreach (var mantenimiento in mantenimientoList)
            {
                if (mantenimiento.Id == pId)
                {
                    return mantenimiento;
                }

            }
            return null;
        }
        public void Eliminar(int pId)
        {
            foreach (var mantenimiento in mantenimientoList)
            {
                if (mantenimiento.Id == pId)
                {
                    mantenimientoList.Remove(mantenimiento);
                    break;
                }

            }
        }
        public Mantenimiento Actualizar(Mantenimiento pMantenimiento)
        {
            if (mantenimientoList == null)
            {
                return null;
            }
            foreach (var mantenimiento in mantenimientoList)
            {
                if (mantenimiento.Id == pMantenimiento.Id)
                {
                    mantenimiento.Nombre = pMantenimiento.Nombre;
                    mantenimiento.Costo = pMantenimiento.Costo;
                    mantenimiento.Fecha = pMantenimiento.Fecha;
                    mantenimiento.NumeroSerie = pMantenimiento.NumeroSerie;
                    mantenimiento.Costo = pMantenimiento.Costo;
                    mantenimiento.Material = pMantenimiento.Material;
                    mantenimiento.Empresa = pMantenimiento.Empresa;
                    mantenimiento.Problema = pMantenimiento.Problema;
                    return mantenimiento;
                }
            }
            return null;
        }
    }
}
