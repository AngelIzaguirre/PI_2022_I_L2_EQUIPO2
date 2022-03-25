using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class Boleto
    {
        private string nombre;
        private int id;
        private decimal costo;
        private string tipoBoleto;
        private int numeroBoleto;
        private Date fecha;
        private string aerolinea;
        private string ciudadSalida;
        private string ciudadLlegada;

        public Boleto(string pNombre, int pId, decimal pCosto, string pTipoBoleto, int pNumeroBoleto, Date pFecha, string pAerolinea, string pCiudadSalida, string pCiudadLlegada)
        {
            nombre = pNombre;
            id = pId;
            costo = pCosto;
            tipoBoleto = pTipoBoleto;
            numeroBoleto = pNumeroBoleto;
            fecha = pFecha;
            aerolinea = pAerolinea;
            ciudadSalida = pCiudadSalida;
            ciudadLlegada = pCiudadLlegada;
        }
        public Boleto()
        {

        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Id
        {
            get { return id; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Id)} el rango esta fuera para Salario >0");
                }
                
                id = value; 
            }
        }
        public decimal Costo
        {
            get { return costo; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Costo)} el rango esta fuera para Salario >0");
                }

                costo = value;
            }
        }


        public string TipoBoleto
        {
            get { return tipoBoleto; }
            set
            {
                tipoBoleto = value;
            }
        }


        public int NumeroBoleto
        {
            get { return numeroBoleto; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(NumeroBoleto)} el rango esta fuera para Numero de Contrato >0");
                }

                numeroBoleto = value;
            }
        }


        public Date Fecha
        {
            get { return fecha; }
            set
            {
                fecha = value;
            }
        }


        public string Aerolinea
        {
            get { return aerolinea; }
            set
            {
                aerolinea= value;
            }
        }

        public string CiudadSalida
        {
            get { return ciudadSalida; }
            set
            {
                ciudadSalida = value;
            }
        }

        public string CiudadLlegada
        {
            get { return ciudadLlegada; }
            set
            {
                ciudadLlegada = value;
            }
        }
        
        public override string ToString() =>
            $"{base.ToString()}"+
            $"Costo: {Costo:C}\n" +
            $"Tipo de boleto: {TipoBoleto}\n" +
            $"Numero de boleto:{NumeroBoleto}\n" +
            $"Fecha: {Fecha}\n" +
            $"Aerolinea: {Aerolinea}\n" +
            $"Ciudad de salida: {CiudadSalida}\n"+
            $"Ciudad de llegada: {CiudadLlegada}\n";

    }
}
