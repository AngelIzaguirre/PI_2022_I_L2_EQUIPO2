using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    public abstract class ComunClaseBase
    {
        private string nombre;
        private int id;
        
        
        public ComunClaseBase(string pNombre, int pId)
        {
            nombre= pNombre;
            id= pId;
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
            }
        }


        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }
       
        public override string ToString() =>
            $"Nombre: {Nombre:D60}\n" +
            $"Id: {Id}\n";

    }
}
