using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02
{
    class ProgressaoGeometrica : Progressao
    {
        public override double GetElemento(int n)
        {
            if (n < 0)
                throw new ArgumentException("Digite um número positivo e inteiro!");
            return PrimeiroElemento * Convert.ToInt16(Math.Pow(Razao, n - 1));
        }

        public override double[] GetElementos(int n)
        {
            double[] elementos = new double[n];

            if (n <= 0)
                throw new ArgumentException("O número de elementos não pode ser menor ou igual a 0!");
            for (int i = 0; i < n; i++) elementos[i - 1] = PrimeiroElemento * Convert.ToInt16(Math.Pow(Razao, i - 1));
            return elementos;
        }

        public override double GetSoma(int n)
        {
            return PrimeiroElemento * (Convert.ToInt16(Math.Pow(Razao, n)) - 1) / (Razao - 1);
        }

        public ProgressaoGeometrica(double pelemento, double razao)
        {
            PrimeiroElemento = pelemento;
            Razao = razao;
        }





    }
}
