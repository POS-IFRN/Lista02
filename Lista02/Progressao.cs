using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02
{
    abstract class Progressao
    {
        private double primeiroElemento;
        private double razao;

        protected double PrimeiroElemento
        {
            get
            {
                return primeiroElemento;
            }

            set
            {
                primeiroElemento = value;
            }
        }

        protected double Razao
        {
            get
            {
                return razao;
            }

            set
            {
                razao = value;
            }
        }

        public abstract double[] GetElementos(int n);

        public abstract double GetElemento(int n);

        public abstract double GetSoma(int n);
    }
}
