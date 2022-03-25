using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class MigracionList
    {
        public List<Migracion> migracionList { get; set; }

        public MigracionList()
        {
            migracionList = new List<Migracion>();
        }
        public void Agregar(Migracion pMigracion)
        {
            migracionList.Add(pMigracion);
        }
        public Migracion Buscar(int pId)
        {
            if (migracionList == null)
            {
                return null;
            }
            foreach (var migracion in migracionList)
            {
                if (migracion.Id == pId)
                {
                    return migracion;
                }

            }
            return null;
        }
        public void Eliminar(int pId)
        {
            foreach (var migracion in migracionList)
            {
                if (migracion.Id == pId)
                {
                    migracionList.Remove(migracion);
                    break;
                }

            }
        }
        public Migracion Actualizar(Migracion pMigracion)
        {
            if (migracionList == null)
            {
                return null;
            }
            foreach (var migracion in migracionList)
            {
                if (migracion.Id == pMigracion.Id)
                {
                    migracion.Nombre = pMigracion.Nombre;
                    migracion.NumeroPasaporte = pMigracion.NumeroPasaporte;
                    migracion.NumeroBoleto = pMigracion.NumeroBoleto;
                    migracion.CantidadEquipaje = pMigracion.CantidadEquipaje;
                    migracion.FechaIda = pMigracion.FechaIda;
                    migracion.FechaRegreso = pMigracion.FechaRegreso;
                    migracion.MotivoViaje = pMigracion.MotivoViaje;
                    migracion.CiudadSalida = pMigracion.CiudadSalida;
                    migracion.CiudadLlegada = pMigracion.CiudadLlegada;
                    return migracion;
                }
            }
            return null;
        }
    }
}
