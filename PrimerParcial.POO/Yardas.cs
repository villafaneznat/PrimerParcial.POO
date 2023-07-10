using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.POO
{
    public class Yardas
    {
        private float distancia;
        public float GetDistancia()
        {
            return distancia;
        }
        public Yardas(float distancia)
        {
            if (distancia <= 0)
            {
                throw new ArgumentException("Distancia no valida");
            }
            else
            {
                this.distancia = distancia;
            }
        }
        public Yardas()
        {
            distancia = 100;
        }
        public static implicit operator float(Yardas y)
        {
            return y.GetDistancia();
        }

        public static explicit operator Yardas(Kilometros k)
        {
            float distanciaYardas = k.GetDistancia() * 1093.61f;
            return new Yardas(distanciaYardas);
        }
        public static bool operator ==(Yardas y1, Yardas y2)
        {
            return y1.GetDistancia() == y2.GetDistancia();
        }
        public static bool operator !=(Yardas y1, Yardas y2)
        {
            return !(y1 == y2);
        }

        public static float operator +(Yardas y1, Yardas y2)
        {
            return y1.GetDistancia() + y2.GetDistancia();
        }
        public static float operator -(Yardas y1, Yardas y2)
        {
            return y1.GetDistancia() - y2.GetDistancia();
        }
        public static float operator *(Yardas y1, Yardas y2)
        {
            return y1.GetDistancia() * y2.GetDistancia();
        }
        public static float operator /(Yardas y1, Yardas y2)
        {
            return y1.GetDistancia() / y2.GetDistancia();
        }
        public static bool operator <(Yardas y1, Yardas y2)
        {
            return y1.GetDistancia() < y2.GetDistancia();
        }

        public static bool operator >(Yardas y1, Yardas y2)
        {
            return y1.GetDistancia() > y2.GetDistancia();
        }
        public static bool operator <=(Yardas y1, Yardas y2)
        {
            return y1.GetDistancia() <= y2.GetDistancia();
        }
        public static bool operator >=(Yardas y1, Yardas y2)
        {
            return y1.GetDistancia() >= y2.GetDistancia();
        }

    }
}
