using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class Migracion:ComunClaseBase
    {
        private int numeroPasaporte;
        private int numeroBoleto;
        private int cantidadEquipaje;
        private Date fechaIda;
        private Date fechaRegreso;
        private string motivoViaje;
        private string ciudadSalida;
        private string ciudadLlegada;
        private int numero;

        public Migracion(string pNombre, int pId, int pNumeroPasaporte, int pNumeroBoleto, int pCantidadEquipaje, Date pFechaIda, Date pFechaRegreso, string pMotivoViaje, string pCiudadSalida, string pCiudadLlegada) 
            : base(pNombre, pId)
        {
            numeroPasaporte = pNumeroPasaporte;
            numeroBoleto = pNumeroBoleto;
            cantidadEquipaje = pCantidadEquipaje;
            fechaIda = pFechaIda;
            fechaRegreso = pFechaRegreso;
            motivoViaje = pMotivoViaje;
            ciudadSalida = pCiudadSalida;
            ciudadLlegada = pCiudadLlegada;
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
        public override void Agregar()
        {
            base.Agregar();

            WriteLine("NumeroPasaporte");
            NumeroPasaporte =int.Parse( ReadLine());
            WriteLine("NumeeroBoleto");
            NumeroBoleto = int.Parse(ReadLine());
            WriteLine("CantidadEquipaje");
            CantidadEquipaje = int.Parse(ReadLine());
            WriteLine("FechaIda: Año/Mes/Dia ");
            FechaIda = Date.Parse(ReadLine());
            WriteLine("FechaRegreso: Año/Mes/Dia");
            FechaRegreso = Date.Parse( ReadLine());
            WriteLine("MotivoViaje");
            MotivoViaje = ReadLine();
            WriteLine("CiudadSalida");
            CiudadSalida = ReadLine();
            WriteLine("Ciudadllegada");
            ciudadLlegada = ReadLine();
        }
        public override void listar()
        {
            base.listar();
            WriteLine($"Numero de Pasaporte:{NumeroPasaporte}");
            WriteLine($"Numero de Boleto: {NumeroBoleto}");
            WriteLine($"Cantidad de Equipaje: {CantidadEquipaje}");
            WriteLine($"Fecha de Ida: {FechaIda}");
            WriteLine($"Fecha de Regreso: {FechaRegreso}");
            WriteLine($"Motivo de Viaje: {MotivoViaje}");
            WriteLine($"Ciudad de Salida: {CiudadSalida}");
            WriteLine($"Ciudad de Llegada: {CiudadLlegada}");
        }
        public override void Buscar()
        {
            WriteLine("Ingrese numero a buscar");
            numero = int.Parse(ReadLine());

            if (numero < 0 || numero > 10)
            {
                WriteLine("Numero fuera del Rango");
            }
            else
            {
                if (numero == 1)
                {
                    WriteLine($"Nombre: {Nombre}");
                }
                if (numero == 2)
                {
                    WriteLine($"Id: {Id}");
                }
                if (numero == 3)
                {
                    WriteLine($"NumeroPasaporte: {NumeroPasaporte}");
                }
                if (numero == 4)
                {
                    WriteLine($"NumeroBoleto: {NumeroBoleto}");
                }
                if (numero == 5)
                {
                    WriteLine($"CantidadEquipaje: {CantidadEquipaje}");
                }
                if (numero == 6)
                {
                    WriteLine($"FechaIda: {FechaIda}");
                }
                if (numero == 7)
                {
                    WriteLine($"FechaRegreso: {FechaRegreso}");
                }
                if (numero == 8)
                {
                    WriteLine($"MotivoViaje: {MotivoViaje}");
                }
                if (numero == 9)
                {
                    WriteLine($"CiudadSalida: {CiudadSalida}");
                }
                if (numero == 10)
                {
                    WriteLine($"CiudadLLegada: {CiudadLlegada}");
                }
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
