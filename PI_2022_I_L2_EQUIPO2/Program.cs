using Microsoft.OData.Edm;
using PI_2022_I_L2_EQUIPO2.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_2022_I_L2_EQUIPO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date fecha1 = new Date(2000, 01, 01);
            Empleados empleado1 = new Empleados("", 1, 1, "", 1, 1, "", "");
            Equipaje equipaje1 = new Equipaje("", 1,1,1, "", 1, 1, "", "");
            Mantenimiento mantenimiento1 = new Mantenimiento("", 1,fecha1, 1,1, "", "", "");
            Migracion migracion1 = new Migracion("", 1, 1, 1, 1,fecha1,fecha1,"","","");
            Boleto boleto1 = new Boleto("", 1, 1, "", 1,fecha1, "", "", "");
            Embarque embarque1 = new Embarque("", 1, 1, "", 1, fecha1, "", 1, 1);
            var opcion = "1";
            do
            {
                WriteLine("Seleccione una opcion \n1 - Empleados \n2 - Boletos \n3 - Embarque \n4 - Equipaje \n5 - Mantenimiento\n6 - Migracion");
                opcion = ReadLine();
                switch (opcion)
                {
                    case "1":
                        WriteLine("Seleccione una opcion \n1 - Agregar \n2 - Listar \n3 - Buscar");
                        int opcion1 = int.Parse(ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                empleado1.Agregar();
                                break;
                            case 2:
                                empleado1.listar();
                                break;
                            case 3:
                                WriteLine("Seleccione una opcion \n1.Nombre \n2.Id \n3.Salario \n4.Genero \n5.NumeroContrato \n6.Edad \n7.Cargo \n8.TipoContrato");
                                empleado1.Buscar();
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
                                boleto1.Agregar();
                                break;

                            case 2:
                                boleto1.listar();
                                
                                break;
                            case 3:
                                WriteLine("Seleccione una opcion \n1.Nombre \n2.Id \n3.Costo \n4.TipoBoleto \n5.NumeroBoleto \n6.Fecha \n7.Aerolinea \n8.CiudadSalida \n9.CiudadLlegada");
                                boleto1.Buscar();
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
                                embarque1.Agregar();
                                break;
                            case 2:
                                embarque1.listar();
                                break;
                            case 3:
                                WriteLine("Seleccione una opcion \n1.Nombre \n2.Id \n3.Costo \n4.Direccion \n5.Telefono \n6.FechaIngreso \n7.Compañia \n8.Peso \n9.Cantidad");
                                embarque1.Buscar();
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
                                equipaje1.Agregar();
                                break;
                            case 2:
                                equipaje1.listar();
                                break;
                            case 3:
                                WriteLine("Seleccione una opcion \n1.Nombre \n2.Id \n3.Hora \n4.TipoEquipaje \n5.CantidadMaletas \n6.Peso \n7.Aerolinea \n8.ClaseBoleto");
                                equipaje1.Buscar();
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
                                mantenimiento1.Agregar();
                                break;
                            case 2:
                                mantenimiento1.listar();
                                break;
                            case 3:
                                WriteLine("Seleccione una opcion \n1.Nombre \n2.Id \n3.Fecha \n4.NumeroSerie \n5.Costo \n6.Material \n7.Empresa \n8.Problema");
                                mantenimiento1.Buscar();
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
                                migracion1.Agregar();
                                break;
                            case 2:
                                migracion1.listar();
                                break;
                            case 3:
                                WriteLine("Seleccione una opcion \n1.Nombre \n2.Id \n3.NumeroPasaporte \n4.NumeroBoleto \n5.CantidadEquipaje \n6.FechaIda \n7.FechaRegreso \n8.MotivoViaje \n9.CiudadSalida \n10.CiudadLLegada");
                                migracion1.Buscar();
                                
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
       
    }
}
