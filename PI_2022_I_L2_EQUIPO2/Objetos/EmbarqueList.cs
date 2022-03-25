using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class EmbarqueList
    {
        public List<Embarque> embarqueList { get; set; }

        public EmbarqueList()
        {
            embarqueList = new List<Embarque>();
        }
        public void Agregar(Embarque pEmbarque)
        {
            embarqueList.Add(pEmbarque);
        }
        public Embarque Buscar(int pId)
        {
            if (embarqueList == null)
            {
                return null;
            }
            foreach (var embarque in embarqueList)
            {
                if (embarque.Id == pId)
                {
                    return embarque;
                }

            }
            return null;
        }
        public void Eliminar(int pId)
        {
            foreach (var embarque in embarqueList)
            {
                if (embarque.Id == pId)
                {
                    embarqueList.Remove(embarque);
                    break;
                }

            }
        }
        public Embarque Actualizar(Embarque pEmbarque)
        {
            if (embarqueList == null)
            {
                return null;
            }
            foreach (var embarque in embarqueList)
            {
                if (embarque.Id == pEmbarque.Id)
                {
                    embarque.Nombre = pEmbarque.Nombre;
                    embarque.Costo = pEmbarque.Costo;
                    embarque.Direccion = pEmbarque.Direccion;
                    embarque.Telefono = pEmbarque.Telefono;
                    embarque.FechaIngreso = pEmbarque.FechaIngreso;
                    embarque.Compañia = pEmbarque.Compañia;
                    embarque.Peso = pEmbarque.Peso;
                    embarque.Cantidad = pEmbarque.Cantidad;
                    return embarque;
                }
            }
            return null;
        }
    }
}
