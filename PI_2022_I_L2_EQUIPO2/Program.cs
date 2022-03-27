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
        const string NOMBREARCHIVO2 = @"D:\Laboratorio\PI_2022_I_L2_EQUIPO2\PI_2022_I_L2_EQUIPO2\bin\Debug\EquipajeList.json";
        const string NOMBREARCHIVO3 = @"D:\Laboratorio\PI_2022_I_L2_EQUIPO2\PI_2022_I_L2_EQUIPO2\bin\Debug\EmbarqueList.json";
        const string NOMBREARCHIVO4 = @"D:\Laboratorio\PI_2022_I_L2_EQUIPO2\PI_2022_I_L2_EQUIPO2\bin\Debug\BoletoList.json";
        const string NOMBREARCHIVO5 = @"D:\Laboratorio\PI_2022_I_L2_EQUIPO2\PI_2022_I_L2_EQUIPO2\bin\Debug\MigracionList.json";
        const string NOMBREARCHIVO6 = @"D:\Laboratorio\PI_2022_I_L2_EQUIPO2\PI_2022_I_L2_EQUIPO2\bin\Debug\MantenimientoList.json";
        static EmpleadoList empleadoList= new EmpleadoList();
        static EquipajeList equipajeList = new EquipajeList();
        static EmbarqueList embarqueList = new EmbarqueList();
        static BoletoList boletoList = new BoletoList();
        static MigracionList migracionList = new MigracionList();
        static MantenimientoList mantenimientoList = new MantenimientoList();
        static string jsonText = "";
        static void Main(string[] args)
        {
            jsonText = File.ReadAllText(NOMBREARCHIVO);
            empleadoList = JsonConvert.DeserializeObject<EmpleadoList>(jsonText);
            jsonText = File.ReadAllText(NOMBREARCHIVO2);
            equipajeList = JsonConvert.DeserializeObject<EquipajeList>(jsonText);
            jsonText = File.ReadAllText(NOMBREARCHIVO3);
            embarqueList = JsonConvert.DeserializeObject<EmbarqueList>(jsonText);
            jsonText = File.ReadAllText(NOMBREARCHIVO4);
            boletoList = JsonConvert.DeserializeObject<BoletoList>(jsonText);
            jsonText = File.ReadAllText(NOMBREARCHIVO5);
            migracionList = JsonConvert.DeserializeObject<MigracionList>(jsonText);
            jsonText = File.ReadAllText(NOMBREARCHIVO6);
            mantenimientoList = JsonConvert.DeserializeObject<MantenimientoList>(jsonText);
            Program objProgram = new Program();
            var opcion = "1";
            do
            {
                WriteLine("Seleccione una opcion \n1 - Empleados \n2 - Equipaje \n3 - Embarque \n4 - Boleto \n5 - Mantenimiento\n6 - Migracion");
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
                        WriteLine("Seleccione una opcion \n1 - Agregar \n2 - Buscar \n3 - Actualizar \n4 - Eliminar \n5 - Listar ");
                         opcion1 = int.Parse(ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                objProgram.AgregarEquipaje();

                                break;
                            case 2:
                                objProgram.BuscarEquipaje();
                                
                                break;
                            case 3:
                                objProgram.ActualizarEquipaje();
                                
                                break;
                            case 4:
                                objProgram.EliminarEquipaje();

                                break;
                            case 5:
                                objProgram.ListarEquipaje();
                                
                                break;

                            default:
                                Main(null);
                                break;
                        }
                        break;
                    case "3":
                        WriteLine("Seleccione una opcion \n1 - Agregar \n2 - Buscar \n3 - Actualizar \n4 - Eliminar \n5 - Listar ");
                        opcion1 = int.Parse(ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                objProgram.AgregarEmbarque();

                                break;
                            case 2:
                                objProgram.BuscarEmbarque();

                                break;
                            case 3:
                                objProgram.ActualizarEmbarque();

                                break;
                            case 4:
                                objProgram.EliminarEmbarque();

                                break;
                            case 5:
                                objProgram.ListarEmbarque();

                                break;

                            default:
                                Main(null);
                                break;
                        }
                        break;
                    case "4":
                        WriteLine("Seleccione una opcion \n1 - Agregar \n2 - Buscar \n3 - Actualizar \n4 - Eliminar \n5 - Listar ");
                        opcion1 = int.Parse(ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                objProgram.AgregarBoleto();

                                break;
                            case 2:
                                objProgram.BuscarBoleto();

                                break;
                            case 3:
                                objProgram.ActualizarBoleto();

                                break;
                            case 4:
                                objProgram.EliminarBoleto();

                                break;
                            case 5:
                                objProgram.ListarBoleto();

                                break;

                            default:
                                Main(null);
                                break;
                        }
                        break;
                    case "5":
                        WriteLine("Seleccione una opcion \n1 - Agregar \n2 - Buscar \n3 - Actualizar \n4 - Eliminar \n5 - Listar ");
                        opcion1 = int.Parse(ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                objProgram.AgregarEquipaje();

                                break;
                            case 2:
                                objProgram.BuscarEquipaje();

                                break;
                            case 3:
                                objProgram.ActualizarEquipaje();

                                break;
                            case 4:
                                objProgram.EliminarEquipaje();

                                break;
                            case 5:
                                objProgram.ListarEquipaje();

                                break;

                            default:
                                Main(null);
                                break;
                        }
                        break;
                    case "6":
                        WriteLine("Seleccione una opcion \n1 - Agregar \n2 - Buscar \n3 - Actualizar \n4 - Eliminar \n5 - Listar ");
                        opcion1 = int.Parse(ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                objProgram.AgregarEquipaje();

                                break;
                            case 2:
                                objProgram.BuscarEquipaje();

                                break;
                            case 3:
                                objProgram.ActualizarEquipaje();

                                break;
                            case 4:
                                objProgram.EliminarEquipaje();

                                break;
                            case 5:
                                objProgram.ListarEquipaje();

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
                        WriteLine("Numero de contrato");
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
                    WriteLine("error, sobrepaso el limite a 100");
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
        private void AgregarEquipaje()
        {
            var equipajeNew = new Equipaje();
            try
            {
                WriteLine("Ingrese el Id");
                var id = int.Parse(ReadLine());
                if (id <= 100)
                {
                    var equipajeBuscar = equipajeList.Buscar(id);
                    if (equipajeBuscar == null)
                    {
                        equipajeNew.Id = id;
                        WriteLine("Nombre");
                        equipajeNew.Nombre = ReadLine();
                        WriteLine("Hora");
                        equipajeNew.Hora = int.Parse(ReadLine());
                        WriteLine("Minuto");
                        equipajeNew.Minuto = int.Parse(ReadLine());
                        WriteLine("Tipo de equipaje");
                        equipajeNew.TipoEquipaje =ReadLine();
                        WriteLine("Cantidad de maletas ");
                        equipajeNew.CantidadMaletas = int.Parse(ReadLine());
                        WriteLine("Peso");
                        equipajeNew.Peso = decimal.Parse(ReadLine());
                        WriteLine("Aerolinea");
                        equipajeNew.Aerolinea = ReadLine();
                        WriteLine("Clase de boleto");
                        equipajeNew.ClaseBoleto = ReadLine();
                        equipajeList.Agregar(equipajeNew);
                        jsonText = JsonConvert.SerializeObject(equipajeList, Formatting.Indented);
                        File.WriteAllText(NOMBREARCHIVO2, jsonText);
                        WriteLine("Guardado exitosamente");
                    }
                    else
                    {
                        WriteLine("Id del equipaje incorrecto, intentelo de nuevo");
                        AgregarEquipaje();
                    }
                }
                else
                {
                    WriteLine("error, sobrepaso el limite a 100");
                    AgregarEquipaje();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ActualizarEquipaje()
        {
            try
            {

                WriteLine("Ingrese el Id");
                var id = int.Parse(ReadLine());
                var equipajeBuscar = equipajeList.Buscar(id);
                if (equipajeBuscar != null)
                {
                    equipajeBuscar.Id = id;
                    WriteLine("Nombre");
                    equipajeBuscar.Nombre = ReadLine();
                    WriteLine("Hora");
                    equipajeBuscar.Hora = int.Parse(ReadLine());
                    WriteLine("Minuto");
                    equipajeBuscar.Minuto = int.Parse(ReadLine());
                    WriteLine("Tipo de equipaje");
                    equipajeBuscar.TipoEquipaje = ReadLine();
                    WriteLine("Cantidad de maletas");
                    equipajeBuscar.CantidadMaletas = int.Parse(ReadLine());
                    WriteLine("Peso");
                    equipajeBuscar.Peso = decimal.Parse(ReadLine());
                    WriteLine("Tipo de Aerolinea");
                    equipajeBuscar.Aerolinea = ReadLine();
                    WriteLine("Clase de boleto");
                    equipajeBuscar.ClaseBoleto = ReadLine();
                    equipajeList.Actualizar(equipajeBuscar);
                    jsonText = JsonConvert.SerializeObject(equipajeList, Formatting.Indented);
                    File.WriteAllText(NOMBREARCHIVO2, jsonText);
                    WriteLine("Actualizado Exitosamente");
                }
                else
                {
                    WriteLine("Id de equipaje Incorrecto, Intente de nuevo");
                    ActualizarEquipaje();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void EliminarEquipaje()
        {
            try
            {
                WriteLine("Ingrese el Id: ");
                var id = int.Parse(ReadLine());
                var equipajeBuscar = equipajeList.Buscar(id);
                if (equipajeBuscar != null)
                {
                    equipajeList.Eliminar(id);
                    jsonText = JsonConvert.SerializeObject(equipajeList, Formatting.Indented);
                    File.WriteAllText(NOMBREARCHIVO2, jsonText);
                    WriteLine("Eliminado Exitosamente");
                }
                else
                {
                    WriteLine("Id de equipaje Incorrecto, Intente de nuevo");
                    EliminarEquipaje();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ListarEquipaje()
        {
            try
            {

                if (equipajeList != null)
                {
                    WriteLine("Equipaje ya existente");
                    foreach (var equipaje in equipajeList.equipajeList)
                    {
                        WriteLine($"ID: {equipaje.Id}");
                        WriteLine($"Nombre: {equipaje.Nombre}");
                        WriteLine($"Hora: { equipaje.Hora}");
                        WriteLine($"Minuto: { equipaje.Minuto}");
                        WriteLine($"Tipo de equipaje: { equipaje.TipoEquipaje}");
                        WriteLine($"Cantidad de maletas: { equipaje.CantidadMaletas}");
                        WriteLine($"Peso: { equipaje.Peso}");
                        WriteLine($"Tipo de Aerolinea: { equipaje.Aerolinea}");
                        WriteLine($"Clase de boleto: { equipaje.ClaseBoleto}");
                        WriteLine("");
                    }
                    WriteLine(" Final");
                }
                else
                {
                    WriteLine("Archivo Vacio de Equipaje, Intente de nuevo");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BuscarEquipaje()
        {
            try
            {
                bool found = false;
                WriteLine("Ingrese el Id: ");
                var id = int.Parse(ReadLine());
                if (equipajeList != null)
                {
                    foreach (var equipaje in equipajeList.equipajeList)
                    {
                        if (equipaje.Id == id)
                        {
                            WriteLine($"ID: {equipaje.Id}");
                            WriteLine($"Nombre: {equipaje.Nombre}");
                            WriteLine($"Hora: { equipaje.Hora}");
                            WriteLine($"Minuto: { equipaje.Minuto}");
                            WriteLine($"Tipo de equipaje: { equipaje.TipoEquipaje}");
                            WriteLine($"Cantidad de maletas: { equipaje.CantidadMaletas}");
                            WriteLine($"Peso: { equipaje.Peso}");
                            WriteLine($"Tipo de Aerolinea: { equipaje.Aerolinea}");
                            WriteLine($"Clase de boleto: { equipaje.ClaseBoleto}");
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
                    WriteLine("Archivo Vacio de Equipaje, Intente de nuevo");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void AgregarEmbarque()
        {
            var embarqueNew = new Embarque();
            try
            {
                WriteLine("Ingrese el Id");
                var id = int.Parse(ReadLine());
                if (id <= 100)
                {
                    var embarqueBuscar = embarqueList.Buscar(id);
                    if (embarqueBuscar == null)
                    {
                        embarqueNew.Id = id;
                        WriteLine("Nombre");
                        embarqueNew.Nombre = ReadLine();
                        WriteLine("Costo");
                        embarqueNew.Costo = decimal.Parse(ReadLine());
                        WriteLine("Direccion");
                        embarqueNew.Direccion = ReadLine();
                        WriteLine("Telefono");
                        embarqueNew.Telefono = int.Parse(ReadLine());
                        WriteLine("Fecha de ingreso ");
                        embarqueNew.FechaIngreso = Date.Parse(ReadLine());
                        WriteLine("Compañia");
                        embarqueNew.Compañia = ReadLine();
                        WriteLine("Peso");
                        embarqueNew.Peso = decimal.Parse(ReadLine());
                        WriteLine("Cantidad");
                        embarqueNew.Cantidad = int.Parse(ReadLine());
                        embarqueList.Agregar(embarqueNew);
                        jsonText = JsonConvert.SerializeObject(embarqueList, Formatting.Indented);
                        File.WriteAllText(NOMBREARCHIVO3, jsonText);
                        WriteLine("Guardado exitosamente");
                    }
                    else
                    {
                        WriteLine("Id del embarque incorrecto, intentelo de nuevo");
                        AgregarEmbarque();
                    }
                }
                else
                {
                    WriteLine("error, sobrepaso el limite a 100");
                    AgregarEmbarque();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ActualizarEmbarque()
        {
            try
            {

                WriteLine("Ingrese el Id");
                var id = int.Parse(ReadLine());
                var embarqueBuscar = embarqueList.Buscar(id);
                if (embarqueBuscar != null)
                {
                    embarqueBuscar.Id = id;
                    WriteLine("Nombre");
                    embarqueBuscar.Nombre = ReadLine();
                    WriteLine("Costo");
                    embarqueBuscar.Costo = decimal.Parse(ReadLine());
                    WriteLine("Direccion");
                    embarqueBuscar.Direccion = ReadLine();
                    WriteLine("Telefono");
                    embarqueBuscar.Telefono = int.Parse(ReadLine());
                    WriteLine("Fecha de ingreso");
                    embarqueBuscar.FechaIngreso = Date.Parse(ReadLine());
                    WriteLine("Compañia");
                    embarqueBuscar.Compañia = ReadLine();
                    WriteLine("Peso");
                    embarqueBuscar.Peso = decimal.Parse(ReadLine());
                    WriteLine("Cantidad");
                    embarqueBuscar.Cantidad = int.Parse(ReadLine());
                    embarqueList.Actualizar(embarqueBuscar);
                    jsonText = JsonConvert.SerializeObject(embarqueList, Formatting.Indented);
                    File.WriteAllText(NOMBREARCHIVO3, jsonText);
                    WriteLine("Actualizado Exitosamente");
                }
                else
                {
                    WriteLine("Id de equipaje Incorrecto, Intente de nuevo");
                    ActualizarEmbarque();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void EliminarEmbarque()
        {
            try
            {
                WriteLine("Ingrese el Id: ");
                var id = int.Parse(ReadLine());
                var embarqueBuscar = embarqueList.Buscar(id);
                if (embarqueBuscar != null)
                {
                    embarqueList.Eliminar(id);
                    jsonText = JsonConvert.SerializeObject(embarqueList, Formatting.Indented);
                    File.WriteAllText(NOMBREARCHIVO3, jsonText);
                    WriteLine("Eliminado Exitosamente");
                }
                else
                {
                    WriteLine("Id de Embarque Incorrecto, Intente de nuevo");
                    EliminarEmbarque();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ListarEmbarque()
        {
            try
            {

                if (embarqueList != null)
                {
                    WriteLine("Embarque ya existente");
                    foreach (var embarque in embarqueList.embarqueList)
                    {
                        WriteLine($"ID: {embarque.Id}");
                        WriteLine($"Nombre: {embarque.Nombre}");
                        WriteLine($"Costo: { embarque.Costo}");
                        WriteLine($"Direccion: { embarque.Direccion}");
                        WriteLine($"Telefono: { embarque.Telefono}");
                        WriteLine($"Fecha de ingreso: { embarque.FechaIngreso}");
                        WriteLine($"Compañia: { embarque.Compañia}");
                        WriteLine($"Peso: { embarque.Peso}");
                        WriteLine($"Cantidad: { embarque.Cantidad}");
                        WriteLine("");
                    }
                    WriteLine(" Final");
                }
                else
                {
                    WriteLine("Archivo Vacio de Equipaje, Intente de nuevo");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BuscarEmbarque()
        {
            try
            {
                bool found = false;
                WriteLine("Ingrese el Id: ");
                var id = int.Parse(ReadLine());
                if (embarqueList != null)
                {
                    foreach (var embarque in embarqueList.embarqueList)
                    {
                        if (embarque.Id == id)
                        {
                            WriteLine($"ID: {embarque.Id}");
                            WriteLine($"Nombre: {embarque.Nombre}");
                            WriteLine($"Costo: { embarque.Costo}");
                            WriteLine($"Direccion: { embarque.Direccion}");
                            WriteLine($"Telefono: { embarque.Telefono}");
                            WriteLine($"Fecha de ingreso: { embarque.FechaIngreso}");
                            WriteLine($"Compañia: { embarque.Compañia}");
                            WriteLine($"Peso: { embarque.Peso}");
                            WriteLine($"Cantidad: { embarque.Cantidad}");                            
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
                    WriteLine("Archivo Vacio de Equipaje, Intente de nuevo");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void AgregarBoleto()
        {
            var boletoNew = new Boleto();
            try
            {
                WriteLine("Ingrese el Id");
                var id = int.Parse(ReadLine());
                if (id <= 100)
                {
                    var boletoBuscar = boletoList.Buscar(id);
                    if (boletoBuscar == null)
                    {
                        boletoNew.Id = id;
                        WriteLine("Nombre");
                        boletoNew.Nombre = ReadLine();
                        WriteLine("Costo");
                        boletoNew.Costo = decimal.Parse(ReadLine());
                        WriteLine("Tipo de boleto");
                        boletoNew.TipoBoleto = ReadLine();
                        WriteLine("Numero de boleto");
                        boletoNew.NumeroBoleto = int.Parse(ReadLine());
                        WriteLine("Fecha ");
                        boletoNew.Fecha = Date.Parse(ReadLine());
                        WriteLine("Aerolinea");
                        boletoNew.Aerolinea = ReadLine();
                        WriteLine("Ciudad de salida");
                        boletoNew.CiudadSalida = ReadLine();
                        WriteLine("Ciudad de llegada");
                        boletoNew.CiudadLlegada = ReadLine();
                        boletoList.Agregar(boletoNew);
                        jsonText = JsonConvert.SerializeObject(boletoList, Formatting.Indented);
                        File.WriteAllText(NOMBREARCHIVO4, jsonText);
                        WriteLine("Guardado exitosamente");
                    }
                    else
                    {
                        WriteLine("Id del embarque incorrecto, intentelo de nuevo");
                        AgregarBoleto();
                    }
                }
                else
                {
                    WriteLine("error, sobrepaso el limite a 100");
                    AgregarBoleto();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ActualizarBoleto()
        {
            try
            {

                WriteLine("Ingrese el Id");
                var id = int.Parse(ReadLine());
                var boletoBuscar = boletoList.Buscar(id);
                if (boletoBuscar != null)
                {
                    boletoBuscar.Id = id;
                    WriteLine("Nombre");
                    boletoBuscar.Nombre = ReadLine();
                    WriteLine("Costo");
                    boletoBuscar.Costo = decimal.Parse(ReadLine());
                    WriteLine("Tipo de boleto");
                    boletoBuscar.TipoBoleto = ReadLine();
                    WriteLine("Numero de boleto");
                    boletoBuscar.NumeroBoleto = int.Parse(ReadLine());
                    WriteLine("Fecha ");
                    boletoBuscar.Fecha = Date.Parse(ReadLine());
                    WriteLine("Aerolinea");
                    boletoBuscar.Aerolinea = ReadLine();
                    WriteLine("Ciudad de salida");
                    boletoBuscar.CiudadSalida = ReadLine();
                    WriteLine("Ciudad de llegada");
                    boletoBuscar.CiudadLlegada = ReadLine();
                    boletoList.Actualizar(boletoBuscar);
                    jsonText = JsonConvert.SerializeObject(boletoList, Formatting.Indented);
                    File.WriteAllText(NOMBREARCHIVO4, jsonText);
                    WriteLine("Actualizado Exitosamente");
                }
                else
                {
                    WriteLine("Id de equipaje Incorrecto, Intente de nuevo");
                    ActualizarBoleto();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void EliminarBoleto()
        {
            try
            {
                WriteLine("Ingrese el Id: ");
                var id = int.Parse(ReadLine());
                var boletoBuscar = boletoList.Buscar(id);
                if (boletoBuscar != null)
                {
                    boletoList.Eliminar(id);
                    jsonText = JsonConvert.SerializeObject(boletoList, Formatting.Indented);
                    File.WriteAllText(NOMBREARCHIVO4, jsonText);
                    WriteLine("Eliminado Exitosamente");
                }
                else
                {
                    WriteLine("Id de Embarque Incorrecto, Intente de nuevo");
                    EliminarBoleto();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ListarBoleto()
        {
            try
            {

                if (boletoList != null)
                {
                    WriteLine("Embarque ya existente");
                    foreach (var boleto in boletoList.boletoList)
                    {
                        WriteLine($"ID: {boleto.Id}");
                        WriteLine($"Nombre: {boleto.Nombre}");
                        WriteLine($"Costo: { boleto.Costo}");
                        WriteLine($"Tipo de boleto: { boleto.TipoBoleto}");
                        WriteLine($"Numero de boleto: { boleto.NumeroBoleto}");
                        WriteLine($"Fecha: { boleto.Fecha}");
                        WriteLine($"Aerolinea: { boleto.Aerolinea}");
                        WriteLine($"Ciudad de salida: { boleto.CiudadSalida}");
                        WriteLine($"Ciudad de llegada: { boleto.CiudadLlegada}");
                        WriteLine("");
                    }
                    WriteLine(" Final");
                }
                else
                {
                    WriteLine("Archivo Vacio de Equipaje, Intente de nuevo");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BuscarBoleto()
        {
            try
            {
                bool found = false;
                WriteLine("Ingrese el Id: ");
                var id = int.Parse(ReadLine());
                if (boletoList != null)
                {
                    foreach (var boleto in boletoList.boletoList)
                    {
                        if (boleto.Id == id)
                        {
                            WriteLine($"ID: {boleto.Id}");
                            WriteLine($"Nombre: {boleto.Nombre}");
                            WriteLine($"Costo: { boleto.Costo}");
                            WriteLine($"Tipo de boleto: { boleto.TipoBoleto}");
                            WriteLine($"Numero de boleto: { boleto.NumeroBoleto}");
                            WriteLine($"Fecha: { boleto.Fecha}");
                            WriteLine($"Aerolinea: { boleto.Aerolinea}");
                            WriteLine($"Ciudad de salida: { boleto.CiudadSalida}");
                            WriteLine($"Ciudad de llegada: { boleto.CiudadLlegada}");
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
                    WriteLine("Archivo Vacio de Equipaje, Intente de nuevo");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    
}
