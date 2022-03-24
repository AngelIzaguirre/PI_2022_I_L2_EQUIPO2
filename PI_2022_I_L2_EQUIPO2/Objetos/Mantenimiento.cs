using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class Mantenimiento
    {
        private string nombre;
        private int id;
        private Date fecha;
        private int numeroSerie;
        private decimal costo;
        private string material;
        private string empresa;
        private string problema;
        private int numero;

        public Mantenimiento(string pNombre, int pId, Date pFecha, int pNumeroSerie, decimal pCosto, string pMaterial, string pEmpresa, string pProblema) 
        {
            nombre = pNombre;
            id = pId;
            fecha = pFecha;
            numeroSerie = pNumeroSerie;
            costo = pCosto;
            material = pMaterial;
            empresa = pEmpresa;
            problema = pProblema;
        }
        public Mantenimiento()
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
        public Date Fecha
        {
            get { return fecha; }
            set
            {
                fecha = value;
            }
        }


        public int NumeroSerie
        {
            get { return numeroSerie; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(NumeroSerie)} el rango esta fuera para ID > 0");
                }
                numeroSerie = value;
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
                        nameof(value), value, $"{nameof(Costo)} el rango esta fuera para Numero de Contrato >0");
                }

                costo = value;
            }
        }


        public string Material
        {
            get { return material; }
            set
            {
                
                material = value;
            }
        }

        public string Empresa
        {
            get { return empresa; }
            set
            {
                empresa = value;
            }
        }
        public string Problema
        {
            get { return problema; }
            set
            {
                problema = value;
            }
        }
        public void Agregar()
        {
            

            WriteLine("fecha: Año/Mes/Dia");
            Fecha = Date.Parse(ReadLine());
            WriteLine("NumeeroSerie");
            NumeroSerie =int.Parse( ReadLine());
            WriteLine("Costo");
            Costo = decimal.Parse(ReadLine());
            WriteLine("Material");
            Material =ReadLine();
            WriteLine("Empresa");
            Empresa = ReadLine();
            WriteLine("Problema");
            Problema = ReadLine();
        }
        public void listar()
        {
            
            WriteLine($"Fecha: {Fecha}");
            WriteLine($"Numero de Serie: {NumeroSerie}");
            WriteLine($"Costo: {Costo}");
            WriteLine($"Material: {Material}");
            WriteLine($"Empresa: {Empresa}");
            WriteLine($"Problema: {Problema}");
        }
        public void Buscar()
        {
            WriteLine("Ingrese numero a buscar");
            numero = int.Parse(ReadLine());

            if (numero < 0 || numero > 8)
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
                    WriteLine($"Fecha: {Fecha}");
                }
                if (numero == 4)
                {
                    WriteLine($"NumeroSerie: {NumeroSerie}");
                }
                if (numero == 5)
                {
                    WriteLine($"Costo: {Costo}");
                }
                if (numero == 6)
                {
                    WriteLine($"Material: {Material}");
                }
                if (numero == 7)
                {
                    WriteLine($"Empresa: {Empresa}");
                }
                if (numero == 8)
                {
                    WriteLine($"Problema: {Problema}");
                }
            }
        }

        public override string ToString() =>
            $"{base.ToString()}" +
            $"Fecha: {Fecha:C}\n" +
            $"Numero de Serie:{NumeroSerie}\n" +
            $"Costo: {Costo}\n" +
            $"Material: {Material}\n" +
            $"Empresa: {Empresa}\n" +
            $"Problema: {Problema}\n";
    }
}
