using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_H_P_1.Class.Equipo
{
     class Baston : Arma
    {
        float poderMagico;
        public Baston (string name, int durabilidad, float pesoBase, float powerMagic)
            : base( name, durabilidad, pesoBase )
        {
            poderMagico = powerMagic;
        }

        public override float calcAtaque ()
        {
            return 5f + (poderMagico * 3);
        }
    }
}
