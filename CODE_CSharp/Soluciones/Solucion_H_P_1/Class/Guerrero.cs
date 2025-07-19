using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_H_P_1.Class
{
     class Guerrero : Personaje
    {
        int resistencia;
        public int GetSetRes { get => resistencia; set => resistencia = value; }
        public Guerrero (string name, int lvl, int pvs, int strength, int resist)
            : base( name, lvl, pvs, strength ) 
            //: base es para recibir los valores heredados de la clase Personajes 
        {
            resistencia = resist;
        }

        public override int Atacar ()
        {
            return (fuerza * 2) + resistencia;
        }
        
    }
}
