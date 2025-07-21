using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_H_P_1.Class.Roles
{
    class Mago : Personaje
    {
        int mana;
        public int GetSetMana { get => mana; set => mana = value; }
        public Mago (string name, int lvl, int pvs, int strength, int resist)
            : base( name, lvl, pvs, strength )
        // ': base' es para recibir los valores heredados de la clase Personajes 
        {
            mana = resist;
        }

        public override int Atacar ()
        {
            if ( mana > 50 )
            { return  fuerza * 3 ; }
            else
            { return  fuerza * 1 ; }
        }
    }
}
