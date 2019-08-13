//Clase empleado
using System;
namespace Programa1
{
    //Dejamos publico la clase Empleado
    public class Empleado
    {
        //Creamos un string de nombre "nombre"
        public String nombre;
        //Despues una con "Apellido"
        public String apellido;
        //Creamos un int publico llamada "id" para la identificacion de cada uno de los empleados
        public int id;
        //Un String para el género
        public String genero;
        //Un string para los dias trabajados
        public int diasTrabajados;
        //Finalmente creamos un int para el "sueldo"
        public int sueldo;

    }

    public Empleado(string nombre,string apellido, string id,string genero , int sueldo , int diasTrabajados)
        {
        this.id = id;
        this.nombre = nombre;
        this.apellido = apellido;
        this.genero = genero;
        this.sueldo = sueldo;
        this.diasTrabajados = diasTrabajados;
}
    public int getId {
        return id;
    }
    public string getNombre
    {
        return nombre;
    }
    public string getApellido
    {
        return apellido;
    }
    public string getGenero
    {
        return genero;
    }
    public int getSueldo
    {
        return sueldo;
    }
    public int getDiasTrab
    {
        return diasTrabajados;
    }

    public float calcularSueldo()
    {
        float sueldoAPagar = 0;
        sueldoAPagar = sueldo * diasTrabajados 
    }
}
//Desarrollado por Pedro Felipe Gomez Bonilla / ID:000396221