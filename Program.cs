using System;

namespace POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Creación de objeto de tipo Circulo. Variable/objeto de tipo circulo
            Circulo elCirculo; 

            //Iniciación de variable/objeto de tipo Circulo. Instanciar una clase.
            //Instanciación. Ejemplarización. Creación de ejemplar de clase.
            elCirculo = new Circulo(); 

            //solicitar al usuario que ingrese el radio por la consola
            Console.WriteLine("Ingrese el radio para hallar el area");

            //leer el dato que el usuario ingreso por consola
            double radio2 = double.Parse(Console.ReadLine()); 

            //Imprime el valor devuelto por ek metodo areaCirculo de la clase Circulo
            Console.WriteLine("Area del circulo: " +elCirculo.areaCirculo(radio2));
                    
        }

    }
    class Circulo
    {
        //Propiedad de la clase Circulo. Campo de clase.
        const double PI = Math.PI; 
        
        //método de clase.
        //¿Qué pueden hacer los objetos de tipo circulo?
        public double areaCirculo (double radio) 
        {
            double resultado = PI * (Math.Pow(radio, 2));

            return resultado;
        }


    }
}
