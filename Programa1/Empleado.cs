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
    class Empleado
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
        //Un String para dias trabajados
        public int diasTrabajados;
        //Finalmente creamos un int para el "sueldo"
        public int sueldo;


        //******************************************************************************
        //-- CONTADOR PARA CANTIDAD DE EMPLEADOS
        //******************************************************************************
        //Para poder contar la cantidad de empleados, vamos a crear que cada vez que
        //añademos un empleado por la variable id , este la agregue a un contador
        //llamado "cantidadEmpleados".
        public Empleado()
        {
            cantidadEmpleados++;
            //Hacemos que este reciba el valor de id a cantidadEmpleados
            this.id = cantidadEmpleados;
        }
        //******************************************************************************
        //-- ESTABLECIENDO CADA VARIABLE
        //******************************************************************************
        //En C# es necesario establecer cada variable que valor recibe .
        //Para ello utilizamos this.varialbe = variable. con cada variable que creamos.
        public Empleado(int id, string nombre, string apellido, String genero, int sueldo, int diasTrabajados)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
            this.sueldo = sueldo;
            this.diasTrabajados = diasTrabajados;
        }
        //******************************************************************************
        //-- CREANDO SETTERS
        //******************************************************************************
        //Los setters son importantes para declarar las variables utilizadas.
        //Para ello , usamos setVarible para eso

        public void setId(int id)
        {
            this.id = id;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(String apellido)
        {
            this.apellido = apellido;
        }
        public void setGenero(String genero)
        {
            this.genero = genero;
        }
        public void setSueldo(int sueldo)
        {
            this.sueldo = sueldo;
        }
        public void setDiasTrabajados(int diasTrabajados)
        {
            this.diasTrabajados = diasTrabajados;
        }
        //******************************************************************************
        //-- CREANDO GETTERS
        //******************************************************************************
        //Utilizamos los getters para obtener un retorno.
        //Para crer uno se hace un comando silimar al de los setters, solamente
        //que le vamos a cambiar set a get y adentro de ello le decimos que
        //retorne el resultado.
        public int getId()
        {
            return this.id;
        }
        public String getNombre()
        {
            return this.nombre;
        }
        public String getApellido()
        {
            return this.apellido;
        }
        public String getGenero()
        {
            return this.genero;
        }
        public int getSueldo()
        {
            return this.sueldo;
        }
        public int getDiasTrabajados()
        {
            return this.diasTrabajados;
        }
        //******************************************************************************
        //-- CREANDO VARIABLE PARA CALCULAR SUELDO
        //******************************************************************************
        //Para ello creamos calcularSueldo con la propiedad del camello y
        //decimos que el sueldototal es el sueldo por los dias trabajados
        //dividido en 30
        public double calcularSueldo(int dias)
        {
            return (this.sueldo * dias / 30);
        }

        //******************************************************************************
        //-- CREANDO TOSTRING
        //******************************************************************************
        //Habia error con tostring
        /*public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t\t}",
                                 getId(),
                                 getNombre(),
                                 getGenero(),
                                 getSueldo(),
                                 getDiasTrabajados());
        }
        */
        //******************************************************************************
        //-- CREANDO FUNCION PARA CAPTURAR DATOS MEDIANTE READLINE
        //******************************************************************************
        //Primero creamos el nombre de la funcion
        public void capturarDatos()
        {
            //Creamos el mensaje
            Console.Write("ID: ");
            //Obtenemos los datos y los convertimos si vemos que es necesario.
            this.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nombre: ");
            this.nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            this.apellido = Console.ReadLine();
        }
    
    }
}
//Desarrollado por Pedro Felipe Gomez Bonilla / ID:000396221
