using System;

namespace AppExerciciosFixacaoPoo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area() 
        {
            double area;
            area = (Altura * Largura);
            return area;
        }

        public double Perimetro() 
        {
            double perimetro;
            perimetro = 2 * (Altura + Largura);
            return perimetro;
        
        }

        public double Diagonal()
        {
            double diagonal;
            diagonal = Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
            return diagonal;
        }

    }
}
