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
        public virtual void Agregar()
        {
            WriteLine("Nombre");
            Nombre = ReadLine();
            WriteLine("Id");
            Id = int.Parse(ReadLine());
        }
        public virtual void listar()
        {
            WriteLine($"Nombre: {Nombre}");
            WriteLine($"Id: {Id}");
        }

        public virtual void Buscar()
        {
            
        }

        public override string ToString() =>
            $"Nombre: {Nombre:D60}\n" +
            $"Id: {Id}\n";

    }
}
