using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class Empleados
    {
        private string nombre;
        private int id;
        private decimal salario;
        private string genero;
        private int numeroContrato;
        private int edad;
        private string cargo;
        private string tipoContrato;

        public Empleados(string pNombre, int pId, decimal pSalario, string pGenero, int pNumeroContrato, int pEdad, string pCargo, string pTipoContrato) 
        {
            nombre = pNombre;
            id = pId;
            salario = pSalario;
            genero = pGenero;
            numeroContrato = pNumeroContrato;
            edad = pEdad;
            cargo = pCargo;
            tipoContrato = pTipoContrato;
        }
        public Empleados()
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
