using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racionales.Model
{
    class Racional
    {

        private double a;
        private double b;
        

        public Racional(double a, double b) {
        this.a = a;
        this.b = b;

    }
        public double getA()
        {
            return a;
        }

        public void setA(double a)
        {
            this.a = a;
        }

        public double getB()
        {
            return b;
        }

        public void setB(double b)
        {
            if (b == 0)
            {
                throw new Exception("Forbidden value");
            }
            this.b = b;
        }
        public Racional multiplicar (Racional r)
        {
            double a = this.a * r.getA();
            double b = this.b * r.getB();
            return new Racional (a, b) ;
        }
        public Racional dividir (Racional r)
        {
            double a = this.a * r.getB();
            double b = this.b * r.getA();
            return new Racional(a, b);
        }
    }
}
