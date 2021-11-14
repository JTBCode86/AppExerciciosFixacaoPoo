using System;
using System.Globalization;

namespace AppExerciciosFixacaoPoo
{
    /// <summary>
    /// Exercicios - Fixação - POO - Classes
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            string[] vet = Console.ReadLine().Split(" ");

            retangulo.Altura = double.Parse(vet[0]);
            retangulo.Largura = double.Parse(vet[1]);
            
            double area = retangulo.Area();
            double perimetro = retangulo.Perimetro();
            double diagonal = retangulo.Diagonal();
            
            Console.Clear();
            Console.WriteLine("AREA = {0}",area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = {0}",perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = {0}",diagonal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
