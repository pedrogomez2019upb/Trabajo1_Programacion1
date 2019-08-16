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
            //Añadimos a la empleada 1 con el metodo de la funcion 
            Empleado emp1 = new Empleado(1, "Patricia", "Barriga", "F", 1500000, 20);
            Console.WriteLine(emp1);
            //El siguiente metodo se hace de una vez por cada valor
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
            double totalSueldo = ((sueldo1 + sueldo2 + sueldo3 + sueldo4));
            double promedioDias = ((emp1.diasTrabajados + emp2.diasTrabajados + emp3.diasTrabajados + emp4.diasTrabajados) / 4);
            //******************************************************************************
            //-- CREACION DE LISTA PARA LOS EMPLEADOS
            //******************************************************************************
            //Para crear la lista que contenga a los empleados simplemente utilizamos List<clase> nombrelista = new List<clase>();
            List<Empleado> listaEmpleados = new List<Empleado>();
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("Inicio de lista");
            Console.WriteLine("____________________________________________________________________________");
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
            //-- IMPRIMIR LISTAS 
            //******************************************************************************
            //Vamos a imprimir la lista
            Console.WriteLine("----------Lista Normal----------");
            listaEmpleados.ForEach(Console.WriteLine);
            //******************************************************************************
            //-- CREANDO VECTORES DE OBJETOS
            //******************************************************************************
            //Primero creamos el listado tipo vector
            
            Console.WriteLine("----------Lista Vectores----------");
            Empleado[] trabajadores = new Empleado[4];
            trabajadores[0] = emp1;
            trabajadores[1] = emp2;
            trabajadores[2] = emp3;
            trabajadores[3] = emp4;
            //Se intenta imprimir pero el vector deja errores
            
            for (int i = 0; i < trabajadores.Length; i++)
            {
                Console.WriteLine(trabajadores[i]);
            }
            
                //******************************************************************************
                //-- FINAL LISTAS 
                //******************************************************************************
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("Final Lista");
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("\nCantidad de empleados: {0} empleados", listaEmpleados.Capacity);
            Console.WriteLine("\nAcumulado sueldo total:{0:C2} COP", totalSueldo);
            Console.WriteLine("\nPromedio de dias trabajados:{0} dias", promedioDias);
            //Nos despedidos del usuario
            Console.WriteLine("\nGracias por utilizar este programa");
            
            
        }
    }
}
//Desarrollado por Pedro Felipe Gomez Bonilla / ID:000396221


