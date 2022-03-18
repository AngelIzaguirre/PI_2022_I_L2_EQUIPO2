using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class Boleto:ComunClaseBase 
    {
        
        private decimal costo;
        private string tipoBoleto;
        private int numeroBoleto;
        private Date fecha;
        private string aerolinea;
        private string ciudadSalida;
        private string ciudadLlegada;
        private int numero; 

        public Boleto(string pNombre, int pId, decimal pCosto, string pTipoBoleto, int pNumeroBoleto, Date pFecha, string pAerolinea, string pCiudadSalida, string pCiudadLlegada) : base(pNombre, pId)
        {
            costo = pCosto;
            tipoBoleto = pTipoBoleto;
            numeroBoleto = pNumeroBoleto;
            fecha = pFecha;
            aerolinea = pAerolinea;
            ciudadSalida = pCiudadSalida;
            ciudadLlegada = pCiudadLlegada;
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
        public override void Agregar()
        {
            base.Agregar();

            WriteLine("Costo");
            Costo = decimal.Parse(ReadLine());
            WriteLine("TipoBoleto");
            TipoBoleto = ReadLine();
            WriteLine("NumeroBoleto");
            NumeroBoleto = int.Parse(ReadLine());
            WriteLine("Fecha: Año/Mes/Dia");
            Fecha = Date.Parse(ReadLine());
            WriteLine("AeroLinea");
             Aerolinea= ReadLine();
            WriteLine("CiudadSalida");
            CiudadSalida = ReadLine();
            WriteLine("Ciudadllegada");
            CiudadLlegada = ReadLine();
        }
        public override void listar()
        {
            base.listar();
            WriteLine($"Costo: {Costo}");
            WriteLine($"Tipo de Boleto: {TipoBoleto}");
            WriteLine($"Numero de Boleto: {NumeroBoleto}");
            WriteLine($"Fecha: {Fecha}");
            WriteLine($"Aerolinea: {Aerolinea}");
            WriteLine($"Ciudad de Salida: {CiudadSalida}");
            WriteLine($"Ciudad de Llegada: {CiudadLlegada}");
        }
        public override void Buscar()
        {
            WriteLine("Ingrese numero a buscar");
            numero = int.Parse(ReadLine());

            if (numero < 0 || numero > 9)
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
                    WriteLine($"Costo:  {Costo}");
                }
                if (numero == 4)
                {
                    WriteLine($"TipoBoleto: {TipoBoleto}");
                }
                if (numero == 5)
                {
                    WriteLine($"NumeroBoleto: {NumeroBoleto}");
                }
                if (numero == 6)
                {
                    WriteLine($"Fecha: {Fecha}");
                }
                if (numero == 7)
                {
                    WriteLine($"Aerolinea: {Aerolinea}");
                }
                if (numero == 8)
                {
                    WriteLine($"CiudadSalida: {CiudadSalida}");
                }
                if (numero == 9)
                {
                    WriteLine($"CiudadLLegada: {CiudadLlegada}");
                }
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
