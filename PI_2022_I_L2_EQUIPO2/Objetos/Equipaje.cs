using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class Equipaje
    {
        private string nombre;
        private int id;
        private int hora;
        private int minuto;
        private string tipoEquipaje;
        private int cantidadMaletas;
        private decimal peso;
        private string aerolinea;
        private string claseBoleto;
        private int numero;
        
        public Equipaje(string pNombre, int pId, int phora, int pMinuto, string pTipoEquipaje, int pCantidadMaletas, decimal pPeso, string pAerolinea, string pClaseBoleto) 
        {
            nombre = pNombre;
            id = pId;
            hora = phora;
            minuto = pMinuto;
            tipoEquipaje = pTipoEquipaje;
            cantidadMaletas = pCantidadMaletas;
            peso = pPeso;
            aerolinea = pAerolinea;
            claseBoleto = pClaseBoleto;
        }
        public Equipaje()
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
        public int Hora
        {
            get { return hora; }
            set
            {
                if (value < 0||value>23)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Hora)} el rango esta fuera para Numero de Contrato < 0 o > 23");
                }
                hora = value;
            }
        }
        public int Minuto
        {
            get { return minuto; }
            set 
            {
                if (value < 0|| value>59)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Minuto)} el rango esta fuera para Minuto < 0 o > 59");
                }
                minuto = value; 
            }
        }   

        public string TipoEquipaje
        {
            get { return tipoEquipaje; }
            set
            {
                tipoEquipaje = value;
            }
        }


        public int  CantidadMaletas
        {
            get { return cantidadMaletas; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(CantidadMaletas)} el rango esta fuera para Numero de Contrato >0");
                }

                CantidadMaletas = value;
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
                        nameof(value), value, $"{nameof(CantidadMaletas)} el rango esta fuera para Numero de Contrato >0");
                }
                peso = value;
            }
        }


        public string Aerolinea
        {
            get { return aerolinea; }
            set
            {
                aerolinea = value;
            }
        }

        public string ClaseBoleto
        {
            get { return claseBoleto; }
            set
            {
                claseBoleto = value;
            }
        }

        public override string ToString()=>
            $"{base.ToString()}" +
            $"Hora: {Hora:D2}/{Minuto:D2}\n" +
            $"Tipo de equipaje: {TipoEquipaje}\n" +
            $"Cantidad de Maletas:{CantidadMaletas}\n" +
            $"Peso: {Peso}\n" +
            $"Aerolinea: {Aerolinea}\n" +
            $"Clase de boleto: {ClaseBoleto}\n";
    }
}
