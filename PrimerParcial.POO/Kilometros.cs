using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.POO
{
    public class Kilometros
    {
        private float distancia;
        public float GetDistancia()
        {
            return distancia;
        }
        public Kilometros(float distancia)
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
        public Kilometros()
        {
            distancia = 100;
        }
        public static implicit operator float(Kilometros k)
        {
            return k.GetDistancia();
        }

        //public static explicit operator Kilometros(Millas m)
        //{
        //    float distanciaKilometros = m.GetDistancia() / 0.621371f;
        //    return new Kilometros(distanciaKilometros);
        //}
        public static bool operator ==(Kilometros k1, Kilometros k2)
        {
            return k1.GetDistancia() == k2.GetDistancia();
        }
        public static bool operator !=(Kilometros k1, Kilometros k2)
        {
            return !(k1 == k2);
        }

        public static float operator +(Kilometros k1, Kilometros k2)
        {
            return k1.GetDistancia() + k2.GetDistancia();
        }
        public static float operator -(Kilometros k1, Kilometros k2)
        {
            return k1.GetDistancia() - k2.GetDistancia();
        }
        public static float operator *(Kilometros k1, Kilometros k2)
        {
            return k1.GetDistancia() * k2.GetDistancia();
        }

        public static explicit operator Kilometros(Millas m)
        {
            float distanciaKilometros = m.GetDistancia() / 0.621371f;
            return new Kilometros(distanciaKilometros);
        
        }

        public static float operator /(Kilometros k1, Kilometros k2)
        {
            return k1.GetDistancia() / k2.GetDistancia();
        }
        public static bool operator <(Kilometros k1, Kilometros k2)
        {
            return k1.GetDistancia() < k2.GetDistancia();
        }

        public static bool operator >(Kilometros k1, Kilometros k2)
        {
            return k1.GetDistancia() > k2.GetDistancia();
        }
        public static bool operator <= (Kilometros k1, Kilometros k2)
        {
            return k1.GetDistancia() <= k2.GetDistancia();
        }
        public static bool operator >=(Kilometros k1, Kilometros k2)
        {
            return k1.GetDistancia() >= k2.GetDistancia();
        }

        public static implicit operator Kilometros(float v)
        {
            return new Kilometros(v);
        }
    }
}
