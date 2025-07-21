using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Solucion_H_P_1.Class.Equipo
{
    class Arma
    {
        protected string nameArma;
        protected int durabilidad;
        protected float pesoBase;


        public Arma (string name, int durability, float peso)
        {
            nameArma = name;
            durabilidad = durability;
            pesoBase = peso;
        }

        // Propiedades para acceder a los atributos
        public string Nombre { get => nameArma; set => nameArma = value; }
        public int Durabilidad { get => durabilidad; set => durabilidad = value; }
        public float PesoBase { get => pesoBase; set => pesoBase = value; }

        public virtual float calcAtaque ()
        {
            return 10f;
        }
    }
}
