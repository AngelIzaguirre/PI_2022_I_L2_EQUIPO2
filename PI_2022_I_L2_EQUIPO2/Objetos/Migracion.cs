using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class Migracion
    {
        private string nombre;
        private int id;
        private int numeroPasaporte;
        private int numeroBoleto;
        private int cantidadEquipaje;
        private Date fechaIda;
        private Date fechaRegreso;
        private string motivoViaje;
        private string ciudadSalida;
        private string ciudadLlegada;

        public Migracion(string pNombre, int pId, int pNumeroPasaporte, int pNumeroBoleto, int pCantidadEquipaje, Date pFechaIda, Date pFechaRegreso, string pMotivoViaje, string pCiudadSalida, string pCiudadLlegada) 
            
        {
            nombre = pNombre;
            id = pId;
            numeroPasaporte = pNumeroPasaporte;
            numeroBoleto = pNumeroBoleto;
            cantidadEquipaje = pCantidadEquipaje;
            fechaIda = pFechaIda;
            fechaRegreso = pFechaRegreso;
            motivoViaje = pMotivoViaje;
            ciudadSalida = pCiudadSalida;
            ciudadLlegada = pCiudadLlegada;
        }
        public Migracion()
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
        public int NumeroPasaporte
        {
            get { return numeroPasaporte; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(NumeroPasaporte)} el rango esta fuera para Salario >0");
                }

                numeroPasaporte = value;
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
                        nameof(value), value, $"{nameof(NumeroBoleto)} el rango esta fuera para Salario >0");
                }

                numeroBoleto = value;
            }
        }


        public int CantidadEquipaje
        {
            get { return cantidadEquipaje; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(CantidadEquipaje)} el rango esta fuera para Numero de Contrato >0");
                }

                cantidadEquipaje = value;
            }
        }


        public Date FechaIda
        {
            get { return fechaIda; }
            set
            {
                fechaIda = value;
            }
        }
        public Date FechaRegreso
        {
            get { return fechaRegreso; }
            set
            {
                fechaIda = value;
            }
        }

        public string MotivoViaje
        {
            get { return motivoViaje; }
            set
            {
                motivoViaje = value;
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
            $"{base.ToString()}" +
            $"Numero de pasaporte: {NumeroPasaporte:C}\n" +
            $"Numero de boleto: {NumeroBoleto}\n" +
            $"Cantidad de equipaje: {CantidadEquipaje}\n" +
            $"Fecha de Ida: {FechaIda}\n" +
            $"Fecha de Regreso: {FechaRegreso}\n" +
            $"Motivo Viaje: {MotivoViaje}\n" +
            $"Ciudad de salida: {CiudadSalida}\n" +
            $"Ciudad de llegada: {CiudadLlegada}\n";
    }
}
