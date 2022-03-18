using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class Embarque:ComunClaseBase
    {
            private decimal costo;
            private string direccion;
            private int telefono;
            private Date fechaIngreso;
            private string compañia;
            private decimal peso;
            private int cantidad;
            private int numero;

        public Embarque(string pNombre, int pId, decimal pCosto, string pDireccion, int pTelefono, Date pFechaIngreso, string pCompañia, decimal pPeso, int pCantidad) : base(pNombre, pId)
        {
            costo = pCosto;
            direccion = pDireccion;
            telefono = pTelefono;
            fechaIngreso = pFechaIngreso;
            compañia = pCompañia;
            peso = pPeso;
            cantidad = pCantidad;
        }
        
            public decimal Costo
            {
                get { return costo; }
                set
                {
                    if (value <= 0)
                    {
                        throw new ArgumentOutOfRangeException(
                            nameof(value), value, $"{nameof(Costo)} el rango esta fuera para Costo >0");
                    }

                    costo = value;
                }
            }


            public string Direccion
            {
                get { return direccion; }
                set
                {
                    direccion = value;
                }
            }


            public int Telefono
            {
                get { return telefono; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException(
                            nameof(value), value, $"{nameof(Telefono)} el rango esta fuera para Numero de Contrato >0");
                    }

                    telefono = value;
                }
            }


            public Date FechaIngreso
            {
                get { return fechaIngreso; }
                set
                {
                    fechaIngreso = value;
                }
            }


            public string Compañia
            {
                get { return compañia; }
                set
                {
                    compañia = value;
                }
            }

            public decimal Peso
            {
                get { return peso; }
                set
                {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Peso)} el rango esta fuera para Peso >0");
                }
                peso = value;
                }
            }

            public int Cantidad
            {
                get { return cantidad; }
                set
                {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Cantidad)} el rango esta fuera para Cantidad > 0");
                }
                cantidad = value;
                }
            }
        public override void Agregar()
        {
            base.Agregar();

            WriteLine("Costo");
            Costo = decimal.Parse(ReadLine());
            WriteLine("Direccion");
            Direccion = ReadLine();
            WriteLine("Telefono");
            Telefono = int.Parse(ReadLine());
            WriteLine("FechaIngreso: Año/Mes/Dia");
            FechaIngreso = Date.Parse(ReadLine());
            WriteLine("Compañia");
            Compañia = ReadLine();
            WriteLine("Peso");
            Peso = decimal.Parse(ReadLine());
            WriteLine("Cantidad");
            Cantidad = int.Parse(ReadLine());
        }
        public override void listar()
        {
            base.listar();
            WriteLine($"Costo: {Costo}");
            WriteLine($"Direccion: {Direccion}");
            WriteLine($"Telefono: {Telefono}");
            WriteLine($"Fecha de Ingreso: {FechaIngreso}");
            WriteLine($"Compañia: {Compañia}");
            WriteLine($"Peso: {Peso}");
            WriteLine($"Cantidad: {Cantidad}"); 
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
                    WriteLine($"Costo: {Costo}");
                }
                if (numero == 4)
                {
                    WriteLine($"Direccion: {Direccion}");
                }
                if (numero == 5)
                {
                    WriteLine($"Telefono: {Telefono}");
                }
                if (numero == 6)
                {
                    WriteLine($"FechaIngreso: {FechaIngreso}");
                }
                if (numero == 7)
                {
                    WriteLine($"Compañia: {Compañia}");
                }
                if (numero == 8)
                {
                    WriteLine($"Peso: {Peso}");
                }
                if (numero == 9)
                {
                    WriteLine($"Cantidad: {Cantidad}");
                }
            }
        }
        public override string ToString() =>
                $"{base.ToString()}" +
                $"Costo: {Costo:C}\n" +
                $"Direccion: {Direccion}\n" +
                $"Telefono:{Telefono}\n" +
                $"Fecha de ingreso: {FechaIngreso}\n" +
                $"Compañia: {Compañia}\n" +
                $"Peso: {Peso}\n" +
                $"Cantidad: {Cantidad}\n";
        }
}
