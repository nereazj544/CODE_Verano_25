using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_H_P_1.Class
{
    internal class Arquero : Personaje
    {
        int precision;
        public int GetSetPrec { get => precision; set => precision = value; }
        public Arquero (string name, int lvl, int pvs, int strength, int resist)
            : base( name, lvl, pvs, strength )
        // ': base' es para recibir los valores heredados de la clase Personajes 
        {
            precision = resist;
        }

        public override int Atacar ()
        {
            return ( fuerza * 2 ) + ( precision / 2 );
        }
    }
}
