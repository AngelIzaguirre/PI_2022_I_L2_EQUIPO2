using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class Embarque
    {
            private string nombre;
            private int id;
            private decimal costo;
            private string direccion;
            private int telefono;
            private Date fechaIngreso;
            private string compañia;
            private decimal peso;
            private int cantidad;
        
        public Embarque(string pNombre, int pId, decimal pCosto, string pDireccion, int pTelefono, Date pFechaIngreso, string pCompañia, decimal pPeso, int pCantidad)
        {
            nombre = pNombre;
            id = pId;
            costo = pCosto;
            direccion = pDireccion;
            telefono = pTelefono;
            fechaIngreso = pFechaIngreso;
            compañia = pCompañia;
            peso = pPeso;
            cantidad = pCantidad;
        }
        public Embarque()
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
                        nameof(value), value, $"{nameof(Id)} el rango esta fuera para Id >0");
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
