using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class Empleados:ComunClaseBase
    {
        
        private decimal salario;
        private string genero;
        private int numeroContrato;
        private int edad;
        private string cargo;
        private string tipoContrato;
        private int numero;
        
        public Empleados(string pNombre, int pId, decimal pSalario, string pGenero, int pNumeroContrato, int pEdad, string pCargo, string pTipoContrato) : base(pNombre, pId)
        {
            salario = pSalario;
            genero = pGenero;
            numeroContrato = pNumeroContrato;
            edad = pEdad;
            cargo = pCargo;
            tipoContrato = pTipoContrato;
        }

        public decimal Salario
        {
            get { return salario; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Salario)} el rango esta fuera para Salario >0");
                }
                
                salario = value; 
            }
        }


        public string Genero
        {
            get { return genero; }
            set 
            {
                genero = value; 
            }
        }


        public int NumeroContrato
        {
            get { return numeroContrato; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(NumeroContrato)} el rango esta fuera para Numero de Contrato >0");
                }
                
                numeroContrato = value;
            }
        }


        public int Edad
        {
            get { return edad; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Edad)} el rango esta fuera para Edad >0");
                }
                
                edad = value; 
            }
        }


        public string Cargo
        {
            get { return cargo; }
            set 
            {
                cargo = value;
            }
        }

        public string TipoContrato
        {
            get { return tipoContrato; }
            set 
            {
                tipoContrato = value; 
            }
        }

        public override void Agregar()
        {
            base.Agregar();

            WriteLine("Salario");
            Salario =decimal.Parse( ReadLine());
            WriteLine("Genero");
            Genero= ReadLine();
            WriteLine("NumeroContrato");
            NumeroContrato = int.Parse(ReadLine());
            WriteLine("Edad");
            Edad = int.Parse(ReadLine());
            WriteLine("Cargo");
            Cargo = ReadLine();
            WriteLine("TipoContrato");
            TipoContrato = ReadLine();
        }
        public override void listar()
        {
            base.listar();
            WriteLine($"Salario: {Salario}");
            WriteLine($"Genero: {Genero}");
            WriteLine($"Numero de Contrato: {NumeroContrato}");
            WriteLine($"Edad: {Edad}");
            WriteLine($"Cargo: {Cargo}");
            WriteLine($"Tipo de Contrato: {TipoContrato}");
        }
        public override void Buscar()
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
                    WriteLine($"Salario: {Salario}");
                }
                if (numero == 4)
                {
                    WriteLine($"Genero: {Genero}");
                }
                if (numero == 5)
                {
                    WriteLine($"NumeroContrato: {NumeroContrato}");
                }
                if (numero == 6)
                {
                    WriteLine($"Edad: {Edad}");
                }
                if (numero == 7)
                {
                    WriteLine($"Cargo: {Cargo}");
                }
                if (numero == 8)
                {
                    WriteLine($"TipoContrato: {TipoContrato}");
                }
            }
        }
        public override string ToString() =>
            $"{base.ToString()}"+
            $"Salario: {Salario:C}\n" +
            $"Genero: {Genero}\n" +
            $"Numero de Contrato:{NumeroContrato}\n" +
            $"Edad: {Edad:D3}\n" +
            $"Cargo: {Cargo}\n" +
            $"Tipo de Contrato: {TipoContrato}\n";



    }
}
