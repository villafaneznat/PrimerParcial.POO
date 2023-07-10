using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.POO
{
    public class Millas
    {
        private float distancia;
        public float GetDistancia()
        {
            return distancia;
        }
        public Millas(float distancia)
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
        public Millas()
        {
            distancia = 100;
        }
        public static implicit operator float(Millas m)
        {
            return m.GetDistancia();
        }

        public static explicit operator Millas(Kilometros k)
        {
            float distanciaMillas = k.GetDistancia() * 0.621371f;
            return new Millas(distanciaMillas);
        }
        public static bool operator ==(Millas m1, Millas m2)
        {
            return m1.GetDistancia() == m2.GetDistancia();
        }
        public static bool operator !=(Millas m1, Millas m2)
        {
            return !(m1 == m2);
        }

        public static float operator +(Millas m1, Millas m2)
        {
            return m1.GetDistancia() + m2.GetDistancia();
        }
        public static float operator -(Millas m1, Millas m2)
        {
            return m1.GetDistancia() - m2.GetDistancia();
        }
        public static float operator *(Millas m1, Millas m2)
        {
            return m1.GetDistancia() * m2.GetDistancia();
        }
        public static float operator /(Millas m1, Millas m2)
        {
            return m1.GetDistancia() / m2.GetDistancia();
        }
        public static bool operator <(Millas m1, Millas m2)
        {
            return m1.GetDistancia() < m2.GetDistancia();
        }

        public static bool operator >(Millas m1, Millas m2)
        {
            return m1.GetDistancia() > m2.GetDistancia();
        }
        public static bool operator <=(Millas m1, Millas m2)
        {
            return m1.GetDistancia() <= m2.GetDistancia();
        }
        public static bool operator >=(Millas m1, Millas m2)
        {
            return m1.GetDistancia() >= m2.GetDistancia();
        }


    }
}
