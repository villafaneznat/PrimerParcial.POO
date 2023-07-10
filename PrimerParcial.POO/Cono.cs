using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.POO
{
    public class Cono
    {
        private double altura;
        private double radio;
        private double generatriz;
        private double volumen;
        private double area;


        public Cono(double altura, double radio)
        {
            if (altura <= 0 || radio <= 0)
            {
                throw new ArgumentException("La altura o el radio ingresado no son validos");

            }
            else
            {
                this.altura = altura;
                this.radio = radio;
                generatriz = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(radio, 2));
                area = Math.PI * radio * (radio + generatriz);
                volumen = (Math.PI * Math.Pow(radio, 2) * altura) / 3;
            }
        }
        public double GetAltura()
        {
            return altura;
        }

        public double GetRadio()
        {
            return radio;
        }
        public double GetGeneratriz()
        {
            return generatriz;
        }
        public double GetVolumen()
        {
            return volumen;
        }
        public double GetArea()
        {
            return area;
        }
        public override string ToString()
        {
            var info = "----INFORMACION DE CONO----" +
                $"Area:{GetArea()}\n" +
                $"Volumen: {GetVolumen()}\n" +
                $"Radio: {GetRadio()}\n" +
                $"Genertriz:{GetGeneratriz()}\n" +
                $"Altura: {GetAltura()}\n" +
                $"";
            return info;
        }



    }
}
