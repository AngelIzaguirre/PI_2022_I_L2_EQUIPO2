using Microsoft.OData.Edm;
using Newtonsoft.Json;
using PI_2022_I_L2_EQUIPO2.Objetos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_2022_I_L2_EQUIPO2
{
    internal class Program
    {
        const string NOMBREARCHIVO = @"D:\Laboratorio\PI_2022_I_L2_EQUIPO2\PI_2022_I_L2_EQUIPO2\bin\Debug\EmpleadoList.json";
        static EmpleadoList empleadoList= new EmpleadoList();
        static string jsonText = "";
        static void Main(string[] args)
        {
            jsonText = File.ReadAllText(NOMBREARCHIVO);
            empleadoList = JsonConvert.DeserializeObject<EmpleadoList>(jsonText);
            Program objProgram = new Program();
            var opcion = "1";
            do
            {
                WriteLine("Seleccione una opcion \n1 - Empleados \n2 - Boletos \n3 - Embarque \n4 - Equipaje \n5 - Mantenimiento\n6 - Migracion");
                opcion = ReadLine();
                switch (opcion)
                {
                    case "1":
                        WriteLine("Seleccione una opcion \n1 - Agregar \n2 - Buscar \n3 - Actualizar \n4 - Eliminar \n5 - Listar ");
                        int opcion1 = int.Parse(ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                objProgram.AgregarEmpleado();
                                break;
                            case 2:
                                objProgram.BuscarEmpleado();
                                break;
                            case 3:
                                objProgram.ActualizarEmpleados();
                                break;
                            case 4:
                                objProgram.EliminarEmpleado();
                                
                                break;
                            case 5:
                                objProgram.ListarEmpleados();
                                break;

                            default:
                                Main(null);
                                break;
                        }
                        break;
                    case "2":
                        WriteLine("Seleccione una opcion \n1 - Agregar \n2 - Listar \n3 - Buscar");
                        opcion1 = int.Parse(ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                
                                break;

                            case 2:
                                
                                
                                break;
                            case 3:
                                WriteLine("Seleccione una opcion \n1.Nombre \n2.Id \n3.Costo \n4.TipoBoleto \n5.NumeroBoleto \n6.Fecha \n7.Aerolinea \n8.CiudadSalida \n9.CiudadLlegada");
                                
                                break;
                            default:
                                Main(null);
                                break;
                        }
                        break;
                    case "3":
                        WriteLine("Seleccione una opcion \n1 - Agregar \n2 - Listar \n3 - Buscar");
                        opcion1 = int.Parse(ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                
                                break;
                            case 2:
                                
                                break;
                            case 3:
                                WriteLine("Seleccione una opcion \n1.Nombre \n2.Id \n3.Costo \n4.Direccion \n5.Telefono \n6.FechaIngreso \n7.Compañia \n8.Peso \n9.Cantidad");
                                
                                break;
                            default:
                                Main(null);
                                break;
                        }
                        break;
                    case "4":
                        WriteLine("Seleccione una opcion \n1 - Agregar \n2 - Listar \n3 - Buscar");
                        opcion1 = int.Parse(ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                
                                break;
                            case 2:
                                
                                break;
                            case 3:
                                WriteLine("Seleccione una opcion \n1.Nombre \n2.Id \n3.Hora \n4.TipoEquipaje \n5.CantidadMaletas \n6.Peso \n7.Aerolinea \n8.ClaseBoleto");
                                
                                break;
                            default:
                                Main(null);
                                break;
                        }
                        break;
                    case "5":
                        WriteLine("Seleccione una opcion \n1 - Agregar \n2 - Listar \n3 - Buscar");
                        opcion1 = int.Parse(ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                
                                break;
                            case 2:
                                
                                break;
                            case 3:
                                WriteLine("Seleccione una opcion \n1.Nombre \n2.Id \n3.Fecha \n4.NumeroSerie \n5.Costo \n6.Material \n7.Empresa \n8.Problema");
                                
                                break;
                            default:
                                Main(null);
                                break;
                        }
                        break;
                    case "6":
                        WriteLine("Seleccione una opcion \n1 - Agregar \n2 - Listar \n3 - Buscar");
                        opcion1 = int.Parse(ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                
                                break;
                            case 2:
                                
                                break;
                            case 3:
                                WriteLine("Seleccione una opcion \n1.Nombre \n2.Id \n3.NumeroPasaporte \n4.NumeroBoleto \n5.CantidadEquipaje \n6.FechaIda \n7.FechaRegreso \n8.MotivoViaje \n9.CiudadSalida \n10.CiudadLLegada");
                                
                                
                                break;
                            default:
                                Main(null);
                                break;
                        }
                        break;
                    default:
                        Main(null);
                        break;
                }
                WriteLine("Si desea seguir, Teclee 1");
               
                opcion = ReadLine();
            } while (opcion== "1");

            ReadLine();
        }
        private void AgregarEmpleado()
        {
            var empleadoNew = new Empleados();
            try
            {
                WriteLine("Ingrese el Id");
                var id = int.Parse(ReadLine());
                if (id <= 100)
                {
                    var empleadoBuscar = empleadoList.Buscar(id);
                    if (empleadoBuscar == null)
                    {
                        empleadoNew.Id = id;
                        WriteLine("Nombre");
                        empleadoNew.Nombre = ReadLine();
                        WriteLine("Salario");
                        empleadoNew.Salario = decimal.Parse(ReadLine());
                        WriteLine("Genero");
                        empleadoNew.Genero = ReadLine();
                        WriteLine("NUmero de contrato");
                        empleadoNew.NumeroContrato = int.Parse(ReadLine());
                        WriteLine("Edad");
                        empleadoNew.Edad = int.Parse(ReadLine());
                        WriteLine("Cargo");
                        empleadoNew.Cargo = ReadLine();
                        WriteLine("Tipo de contrato");
                        empleadoNew.TipoContrato = ReadLine();
                        empleadoList.Agregar(empleadoNew);
                        jsonText = JsonConvert.SerializeObject(empleadoList, Formatting.Indented);
                        File.WriteAllText(NOMBREARCHIVO, jsonText);
                        WriteLine("Guardado exitosamente");
                    }
                    else
                    {
                        WriteLine("Id del libro incorrecto, intentelo de nuevo");
                        AgregarEmpleado();
                    }
                }
                else
                {
                    WriteLine("error, sobrepaso el limite a 100");
                    AgregarEmpleado();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ActualizarEmpleados()
        {
            try
            {

                WriteLine("Ingrese el Id");
                var id = int.Parse(ReadLine());
                var empleadoBuscar = empleadoList.Buscar(id);
                if (empleadoBuscar != null)
                {
                    empleadoBuscar.Id = id;
                    WriteLine("Nombre");
                    empleadoBuscar.Nombre = ReadLine();
                    WriteLine("Salario");
                    empleadoBuscar.Salario = decimal.Parse(ReadLine());
                    WriteLine("Genero");
                    empleadoBuscar.Genero = ReadLine();
                    WriteLine("NUmero de contrato");
                    empleadoBuscar.NumeroContrato = int.Parse(ReadLine());
                    WriteLine("Edad");
                    empleadoBuscar.Edad = int.Parse(ReadLine());
                    WriteLine("Cargo");
                    empleadoBuscar.Cargo = ReadLine();
                    WriteLine("Tipo de contrato");
                    empleadoBuscar.TipoContrato = ReadLine();
                    empleadoList.Actualizar(empleadoBuscar);
                    jsonText = JsonConvert.SerializeObject(empleadoList, Formatting.Indented);
                    File.WriteAllText(NOMBREARCHIVO, jsonText);
                    WriteLine("Actualizado Exitosamente");
                }
                else
                {
                    WriteLine("Id Libro Incorrecto, Intente de nuevo");
                    ActualizarEmpleados();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void EliminarEmpleado()
        {
            try
            {
                WriteLine("Ingrese el Id: ");
                var id = int.Parse(ReadLine());
                var empleadoBuscar = empleadoList.Buscar(id);
                if (empleadoBuscar != null)
                {
                    empleadoList.Eliminar(id);
                    jsonText = JsonConvert.SerializeObject(empleadoList, Formatting.Indented);
                    File.WriteAllText(NOMBREARCHIVO, jsonText);
                    WriteLine("Eliminado Exitosamente");
                }
                else
                {
                    WriteLine("Id Libro Incorrecto, Intente de nuevo");
                    EliminarEmpleado();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ListarEmpleados()
        {
            try
            {

                if (empleadoList != null)
                {
                    WriteLine("Empleado ya existente");
                    foreach (var empleado in empleadoList.empleadosList)
                    {
                        WriteLine($"ID: {empleado.Id}");
                        WriteLine($"Nombre: {empleado.Nombre}");
                        WriteLine($"Salario: {empleado.Salario}");
                        WriteLine($"Genero: {empleado.Genero}");
                        WriteLine($"Numero de contrato: {empleado.NumeroContrato}");
                        WriteLine($"Edad: {empleado.Edad}");
                        WriteLine($"Cargo: {empleado.Cargo}");
                        WriteLine($"Tipo de contrato: {empleado.TipoContrato}");
                        WriteLine("");
                    }
                    WriteLine(" Final");
                }
                else
                {
                    WriteLine("Archivo Vacio de empleados, Intente de nuevo");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BuscarEmpleado()
        {
            try
            {
                bool found = false;
                WriteLine("Ingrese el Id: ");
                var id = int.Parse(ReadLine());
                if (empleadoList != null)
                {
                    foreach (var empleado in empleadoList.empleadosList)
                    {
                        if (empleado.Id == id)
                        {
                            WriteLine($"ID: {empleado.Id}");
                            WriteLine($"Nombre: {empleado.Nombre}");
                            WriteLine($"Salario: {empleado.Salario}");
                            WriteLine($"Genero: {empleado.Genero}");
                            WriteLine($"Numero de contrato: {empleado.NumeroContrato}");
                            WriteLine($"Edad: {empleado.Edad}");
                            WriteLine($"Cargo: {empleado.Cargo}");
                            WriteLine($"Tipo de contrato: {empleado.TipoContrato}");
                            WriteLine("");
                            found = true;
                        }

                    }
                    if (found)
                    {
                        WriteLine("Satisfactorio");
                    }
                    else
                    {
                        WriteLine("No encontrado");
                    }
                }
                else
                {
                    WriteLine("Archivo Vacio de Libros, Intente de nuevo");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    
}
