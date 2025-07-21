using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_H_P_1.Class.Equipo
{
     class Arco : Arma
    {

        float tension;
        public Arco (string name, int durabilidad, float pesoBase, float strain)
    : base( name, durabilidad, pesoBase )
        {
            tension = strain;
        }

        public virtual float calcAtaque ()
        {
            return 8f + (tension * 1.5f);
        }
    }
}
