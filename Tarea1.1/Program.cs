using System;
using System.Collections.Generic;
namespace Tarea1._1
{
class Persona
    {
        //atributos
        private string nombre;//Campo
        private int edad;
             
        //Encapsulamiento
        public string NOMBRE//propiedad
        {
        //get lee y regresa
        get
        {
            return nombre; 
        }
        //set para modificar
        set
        {
            nombre = value;
        }
    }
        //constructor
public Persona(string nombre, int e)//parametros o argumentos
    {
        this.nombre = nombre;
        edad = e;

    }
    public void Imprime()
    {
        Console.WriteLine("Nombre: {0}",nombre);

    }
    public void Imprime(int veces)
    {
        for(int i=0; i<=veces; i++)
        {
            Imprime();
        }
    }

public static  Persona operator + (Persona a, Persona b)//static por que el encargado de regresar es la clase y no los objetos
{
    return new Persona (a.nombre + b.nombre, a.edad + b.edad);
}




}
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Bere",21);
            List<Persona> personas = new List<Persona>();//otro objeto
            personas.Add(p);
            personas.Add(new Persona("Jim",32));
            p.Imprime(3);
            personas[1].Imprime();
            //Console.WriteLine("Hola mun!");
        }
    }
}
