using System;
using System.Globalization;
using System.Xml;

namespace poo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CambioDeMoneda converDolar_A_peso = new CambioDeMoneda();
            CambioDeMoneda converPeso_A_Dolar = new CambioDeMoneda();
            
            DateTime fecha = new DateTime(2024, 4, 17);
            Console.WriteLine("Conversión de dólar a peso RD hoy " +fecha.ToString("dd/MM/yyyy"));

            Console.WriteLine("Si desea convertir de peso a dólar ingrese 'P'\nSi desea convertir de dólar a peso ingrese 'D'");
            string op = Console.ReadLine().ToLower();

            if (op == "p")
            {
                Console.WriteLine("Ingrese la cantidad que desea convertir");
                double pesoRD = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{pesoRD} pesos dominicanos son {converPeso_A_Dolar.pesoAdolar(pesoRD)} dólares");
                
            }
            else if (op == "d") 
            {
                Console.WriteLine("Ingrese la cantidad que desea convertir");
                double dolar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{dolar} dolares son {+converDolar_A_peso.dolarApeso(dolar)} pesos dominicanos");
            }         
                        
        }
        
    }
    class CambioDeMoneda
    {
        private double precioDolar = 58.94;
        private double precioPeso = 0.017;
        
        public double dolarApeso(double peso)
        {
            double resultado = precioDolar * peso;
            resultado = Math.Round(resultado, 3);
            return resultado;

        }
        public double pesoAdolar(double peso)
        {
            double resultado = peso / precioDolar;
            resultado = Math.Round(resultado, 3);
            return resultado;
        }
    }
}
