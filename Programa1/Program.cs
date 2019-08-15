//******************************************************************************
//-- ADAPTACION GETTERS SETTERS Y LISTA
//******************************************************************************
//----Programa General----
//Primero nos toca cargar las librerias necesarias para el desarrollo del programa.
using System;
//Este va a ser importante para la creacion de las listas
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Damos un mensaje de bienvenida
            Console.WriteLine("Hola! Bienvenido al programa del listado de empleados de la empresa iFastCO.");
            Console.WriteLine("____________________________________________________________________________");
            //******************************************************************************
            //-- CREACION DE EMPLEADOS
            //******************************************************************************
            //Aqui vamos a crear los objetos correspondietes a cada uno de los empleados
            //******************************************************************************
            //-- LABORATORIO : EMPLEADA 1 PATRICIA BARRIGA
            //******************************************************************************
            Empleado emp1 = new Empleado(1, "Patricia", "Barriga", "F", 1500000, 20);
            Console.WriteLine(emp1);
            //Creamos el empleado 2.
            Empleado emp2 = new Empleado();
            //Creamos el id
            emp2.id = 2;
            //Después establecemos el nombre
            emp2.nombre = "Pedro";
            //Establecemos el apellido
            emp2.apellido = "Perez";
            //Establecemos el sueldo
            emp2.sueldo = 1000000;
            //Establecemos el genero
            emp2.genero = "M";
            //Establecemos dias trabajados
            emp2.diasTrabajados = 15;
            //Imprimimos los valores para cada uno
            Console.WriteLine("\t\nEmpleado:"+emp2.id+"\tNombre: " + emp2.nombre + "\tApellido: " + emp2.apellido+"\tSueldo: "+emp2.sueldo+"\tGenero: "+emp2.genero);
            //Repetimos el proceso para cada uno de los empleados necesarios
            Empleado emp3 = new Empleado();
            emp3.id = 3;
            emp3.nombre = "Luisa";
            emp3.apellido = "Prada";
            emp3.sueldo = 1500000;
            emp3.genero = "F";
            emp3.diasTrabajados = 10;
            Console.WriteLine("\t\nEmpleado:" + emp3.id + "\tNombre: " + emp3.nombre + "\tApellido: " + emp3.apellido + "\tSueldo: " + emp3.sueldo+"\tGenero: "+emp3.genero);
            Empleado emp4 = new Empleado();
            emp4.id = 4;
            emp4.nombre = "Ernesto";
            emp4.apellido = "Cespedes";
            emp4.sueldo = 2300000;
            emp4.genero = "M";
            emp3.diasTrabajados = 9;
            Console.WriteLine("\t\nEmpleado:" + emp4.id + "\tNombre: " + emp4.nombre + "\tApellido: " + emp4.apellido + "\tSueldo: " + emp4.sueldo+"\tGenero: "+emp4.genero);

            //******************************************************************************
            //-- GENERACIÓN DE SUELDO POR EMPLEADO
            //******************************************************************************
            //Como anteriormente creamos una funcion para calcular el sueldo de cada empleado, lo
            //vamos a aplicar mediante cada uno. Al empleado 1 le vamos a poner 20 dias trabjados,
            //10 dias al segundo empleado y al tercero 30 dias
            double sueldo1 = emp1.calcularSueldo(emp1.diasTrabajados);
            double sueldo2 = emp2.calcularSueldo(emp2.diasTrabajados);
            double sueldo3 = emp3.calcularSueldo(emp3.diasTrabajados);
            double sueldo4 = emp4.calcularSueldo(emp4.diasTrabajados);
            //******************************************************************************
            //-- CREACION DE LISTA PARA LOS EMPLEADOS
            //******************************************************************************
            //Para crear la lista que contenga a los empleados simplemente utilizamos List<clase> nombrelista = new List<clase>();
            List<Empleado> listaEmpleados = new List<Empleado>();
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("Inicio de lista");
            Console.WriteLine("____________________________________________________________________________");
            //******************************************************************************
            //-- IMPRIMIR LISTA INICIAL
            //******************************************************************************
            //Imprimimos los valores iniciales de la lista
            Console.WriteLine("\nAl momento de crear el listado , esta tiene la siguiente capacidad: {0}", listaEmpleados.Capacity);
            //******************************************************************************
            //-- IMPLEMENTAR A LOS EMPLEADOS
            //******************************************************************************
            //Para agregar a los empleados simplemente utilizamos:
            //lista.Add(objeto);
            listaEmpleados.Add(emp2);
            listaEmpleados.Add(emp3);
            listaEmpleados.Add(emp4);
            listaEmpleados.Insert(0, emp1);
            //******************************************************************************
            //-- IMPRIMIR LISTA FINAL
            //******************************************************************************
            //Vamos a imprimir la lista
            Console.WriteLine("\nDespues de agregar a los empleados, la capacidad de esta lista es de: {0} empleados", listaEmpleados.Capacity);
            //Nos despedidos del usuario
            Console.WriteLine("\nGracias por utilizar este programa");
            listaEmpleados.ForEach(Console.WriteLine);

        }
    }
}
//Desarrollado por Pedro Felipe Gomez Bonilla / ID:000396221
/*
Empleado emp1 = new Empleado();
emp1.id = 1;
            emp1.nombre = "Patricia";
            emp1.apellido = "Barriga";
            emp1.sueldo = 1500000;
            emp1.genero = "F";
            emp1.diasTrabajados = 25;
            Console.WriteLine("\t\nEmpleado:" + emp1.id + "\tNombre: " + emp1.nombre + "\tApellido: " + emp1.apellido + "\tSueldo: " + emp1.sueldo + "\t\tGenero: " + emp1.genero);
            */


