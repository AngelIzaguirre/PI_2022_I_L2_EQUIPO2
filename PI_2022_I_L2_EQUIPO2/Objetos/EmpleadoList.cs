using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_2022_I_L2_EQUIPO2.Objetos
{
    internal class EmpleadoList
    {
        public List<Empleados> empleadosList { get; set; }

        public EmpleadoList()
        {
            empleadosList = new List<Empleados>();
        }
        public void Agregar(Empleados pEmpleados)
        {
            empleadosList.Add(pEmpleados);
        }
        public Empleados Buscar(int pId)
        {
            if ( empleadosList == null)
            {
                return null;
            }
            foreach (var empleado in empleadosList)
            {
                if (empleado.Id == pId)
                {
                    return empleado;
                }
                
            }
            return null;
        }
        public void Eliminar(int pId)
        {
            foreach (var empleado in empleadosList)
            {
                if (empleado.Id == pId)
                {
                   empleadosList.Remove(empleado);
                    break;
                }

            }
        }
        public Empleados Actualizar(Empleados pEmpleados)
        {
            if (empleadosList == null)
            {
                return null;
            }
            foreach (var empleado in empleadosList)
            {
                if (empleado.Id == pEmpleados.Id)
                {
                    empleado.Nombre = pEmpleados.Nombre;
                    empleado.Salario= pEmpleados.Salario;
                    empleado.Genero= pEmpleados.Genero;
                    empleado.NumeroContrato = pEmpleados.NumeroContrato;
                    empleado.Edad= pEmpleados.Edad;
                    empleado.Cargo = pEmpleados.Cargo;
                    empleado.TipoContrato= pEmpleados.TipoContrato;
                    return empleado;
                }
            }
            return null; 
        }
        
    }
}
