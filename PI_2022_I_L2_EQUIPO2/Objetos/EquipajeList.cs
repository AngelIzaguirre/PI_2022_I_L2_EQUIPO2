using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class EquipajeList
    {
        public List<Equipaje> equipajeList { get; set; }

        public EquipajeList()
        {
            equipajeList = new List<Equipaje>();
        }
        public void Agregar(Equipaje pEquipaje)
        {
            equipajeList.Add(pEquipaje);
        }
        public Equipaje Buscar(int pId)
        {
            if (equipajeList == null)
            {
                return null;
            }
            foreach (var equipaje in equipajeList)
            {
                if (equipaje.Id == pId)
                {
                    return equipaje;
                }

            }
            return null;
        }
        public void Eliminar(int pId)
        {
            foreach (var equipaje in equipajeList)
            {
                if (equipaje.Id == pId)
                {
                    equipajeList.Remove(equipaje);
                    break;
                }

            }
        }
        public Equipaje Actualizar(Equipaje pEquipaje)
        {
            if (equipajeList == null)
            {
                return null;
            }
            foreach (var equipaje in equipajeList)
            {
                if (equipaje.Id == pEquipaje.Id)
                {
                    equipaje.Nombre = pEquipaje.Nombre;
                    equipaje.Hora = pEquipaje.Hora;
                    equipaje.Minuto = pEquipaje.Minuto;
                    equipaje.TipoEquipaje = pEquipaje.TipoEquipaje;
                    equipaje.CantidadMaletas = pEquipaje.CantidadMaletas;
                    equipaje.Peso = pEquipaje.Peso;
                    equipaje.Aerolinea = pEquipaje.Aerolinea;
                    equipaje.ClaseBoleto = pEquipaje.ClaseBoleto;
                    return equipaje;
                }
            }
            return null;
        }
    }
}
