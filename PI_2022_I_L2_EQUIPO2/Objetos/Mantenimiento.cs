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
