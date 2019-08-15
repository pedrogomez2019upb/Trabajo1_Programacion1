//******************************************************************************
//-- ADAPTACION GETTERS SETTERS Y LISTA
//******************************************************************************
//Programa General
using System;
using System.Collections.Generic;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Damos un mensaje de bienvenida
            Console.WriteLine("Hola! Bienvenido al programa del listado de empleados de la empresa iFastCO.");
            Console.WriteLine("____________________________________________________________________________");

            //Primero creamos emp1
            Empleado emp1 = new Empleado();
            //Creamos el id
            emp1.id = 1;
            //Después establecemos el nombre
            emp1.nombre = "Pedro";
            //Establecemos el apellido
            emp1.apellido = "Perez";
            //Establecemos el sueldo
            emp1.sueldo = 1000000;
            //Establecemos el genero
            emp1.genero = "M";
            //Imprimimos los valores para cada uno
            Console.WriteLine("\t\nEmpleado:"+emp1.id+"\tNombre: " + emp1.nombre + "\tApellido: " + emp1.apellido+"\tSueldo: "+emp1.sueldo+"\tGenero: "+emp1.genero);
            //Repetimos el proceso para cada uno de los empleados necesarios
            Empleado emp2 = new Empleado();
            emp2.id = 2;
            emp2.nombre = "Luisa";
            emp2.apellido = "Prada";
            emp2.sueldo = 1500000;
            emp2.genero = "F";
            Console.WriteLine("\t\nEmpleado:" + emp2.id + "\tNombre: " + emp2.nombre + "\tApellido: " + emp2.apellido + "\tSueldo: " + emp2.sueldo+"\tGenero: "+emp2.genero);
            Empleado emp3 = new Empleado();
            emp3.id = 3;
            emp3.nombre = "Ernesto";
            emp3.apellido = "Cespedes";
            emp3.sueldo = 2300000;
            emp3.genero = "M";
            Console.WriteLine("\t\nEmpleado:" + emp3.id + "\tNombre: " + emp3.nombre + "\tApellido: " + emp3.apellido + "\tSueldo: " + emp3.sueldo+"\tGenero: "+emp3.genero);
            Console.WriteLine("\nGracias por utilizar este programa");
        }
    }
}
//Desarrollado por Pedro Felipe Gomez Bonilla / ID:000396221



