using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_H_P_1.Class.Equipo
{
    class Espada : Arma
    {

        float longitud;
        public Espada (string name, int durabilidad, float pesoBase, float _length)
            : base( name, durabilidad, pesoBase )
        {
            longitud = _length;
        }

        public override float calcAtaque ()
        {
            return 10f + (longitud *2f) ;
        }

    }
}
