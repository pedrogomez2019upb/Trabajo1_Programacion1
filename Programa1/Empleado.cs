//******************************************************************************
//-- ADAPTACION GETTERS SETTERS Y LISTA
//******************************************************************************
//Clase empleado
//Primero nos toca cargar las librerias necesarias para el desarrollo del programa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//El espacio de trabajo es igual al nombre de la carpeta , osea "Programa1"
namespace Programa1
{
    //Dejamos publico la clase Empleado
    public class Empleado
    {
        //******************************************************************************
        //-- CREACION DE LA CANTIDAD DE EMPLEADOS
        //******************************************************************************
        //Para crear el numero de empleados , debemos empezar haciendo
        //una variable estatica privada para el programa interno y
        //otra que le haga retorno a esta misma
        private static int cantidadEmpleados;
        public static int CantidadEmpleados
        {
            get { return Empleado.cantidadEmpleados; }
        }
        //******************************************************************************
        //-- CREACION DE ATRIBUTOS
        //******************************************************************************
        //Nosotros para poder empezar a trabajar, nos toca crear los
        //atributos necesarios y con ello establecerlos.
        //Primero creamos un string de nombre "nombre"
        public String nombre;
        //Despues una con "Apellido"
        public String apellido;
        //Creamos un int publico llamada "id" para la identificacion de cada uno de los empleados
        public int id;
        //Un String para el género
        public String genero;
        //Finalmente creamos un int para el "sueldo"
        public int sueldo;

    }
    //******************************************************************************
    //-- CONTADOR 
    //******************************************************************************
    public Empleado(int id, string nombre, string apellido, char genero, int sueldo, int diasTrabajados)
{
    numero
    this.id = id;
    this.nombre = nombre;
    this.apellido = apellido;
    this.genero = genero;
    this.sueldo = sueldo;
    this.diasTrabajados = diasTrabajados;
}
    public Empleado() { numeroEmpleados++;this.id = numeroEmpleados; }


}
//Desarrollado por Pedro Felipe Gomez Bonilla / ID:000396221
