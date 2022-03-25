using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class BoletoList
    {
        public List<Boleto> boletoList { get; set; }

        public BoletoList()
        {
            boletoList = new List<Boleto>();
        }
        public void Agregar(Boleto pBoleto)
        {
            boletoList.Add(pBoleto);
        }
        public Boleto Buscar(int pId)
        {
            if (boletoList == null)
            {
                return null;
            }
            foreach (var boleto in boletoList)
            {
                if (boleto.Id == pId)
                {
                    return boleto;
                }

            }
            return null;
        }
        public void Eliminar(int pId)
        {
            foreach (var boleto in boletoList)
            {
                if (boleto.Id == pId)
                {
                    boletoList.Remove(boleto);
                    break;
                }

            }
        }
        public Boleto Actualizar(Boleto pBoleto)
        {
            if (boletoList == null)
            {
                return null;
            }
            foreach (var boleto in boletoList)
            {
                if (boleto.Id == pBoleto.Id)
                {
                    boleto.Nombre = pBoleto.Nombre;
                    boleto.Costo = pBoleto.Costo;
                    boleto.TipoBoleto = pBoleto.TipoBoleto;
                    boleto.NumeroBoleto = pBoleto.NumeroBoleto;
                    boleto.Fecha = pBoleto.Fecha;
                    boleto.Aerolinea = pBoleto.Aerolinea;
                    boleto.CiudadSalida = pBoleto.CiudadSalida;
                    boleto.CiudadLlegada = pBoleto.CiudadLlegada;
                    return boleto;
                }
            }
            return null;
        }
    }
}
