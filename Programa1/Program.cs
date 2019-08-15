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
            //******************************************************************************
            //-- GENERACIÓN DE SUELDO POR EMPLEADO
            //******************************************************************************
            //Como anteriormente creamos una funcion para calcular el sueldo de cada empleado, lo
            //vamos a aplicar mediante cada uno. Al empleado 1 le vamos a poner 20 dias trabjados,
            //10 dias al segundo empleado y al tercero 30 dias
            double sueldo1 = emp1.calcularSueldo(20);
            double sueldo2 = emp2.calcularSueldo(10);
            double sueldo3 = emp3.calcularSueldo(30);
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
            listaEmpleados.Add(emp1);
            Console.WriteLine("\nGracias por utilizar este programa");
            //******************************************************************************
            //-- IMPLEMENTAR A LOS EMPLEADOS
            //******************************************************************************
            //Para agregar a los empleados simplemente utilizamos:
            //lista.Add(objeto);
            listaEmpleados.Add(emp1);
            listaEmpleados.Add(emp2);
            listaEmpleados.Add(emp3);
            //******************************************************************************
            //-- IMPRIMIR LISTA FINAL
            //******************************************************************************
            //Vamos a imprimir la lista
            Console.WriteLine("\n La capacidad de esta lista es de: {0} empleados", listaEmpleados.Capacity);

        }
    }
}
//Desarrollado por Pedro Felipe Gomez Bonilla / ID:000396221



