using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aparatos.Clases
{
    class Electrodomestico
    {
        bool On;
        int tension;

        public Electrodomestico ()
        {
            On = false;
            tension = 220;
        }

        public void Encendido ()
        {
            On = true;
        }
        public void Apagado ()
        {
            On = false;
        }

        public bool OnEncedido ()
        {
            return On;
        }

        public void SetTension (int tensiones)
        {
            tension = tensiones;
        }
        public int GetTension ()
        {
            return tension;
        }
    }
}
