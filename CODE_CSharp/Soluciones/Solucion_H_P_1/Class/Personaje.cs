using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_H_P_1.Class
{
    class Personaje
    {
        protected string nombre;
        protected int nivel;
        protected int pv; //Puntos de Vida
        protected int fuerza; //Fuerza * 2

    


        public Personaje ()
        { }

        public Personaje (string name, int lvl, int pv, int strength)
        {
            nombre = name;
            nivel = lvl;
            this.pv = pv;
            fuerza = strength;
        }

        //Atributos con Get y Set
        public string GetNombre ()
        { return nombre; }
        public void SetNombre (string nm)
        { nombre = nm; }

        public int GetNivel ()
        { return nivel; }
        public void SetNivel (int lvl)
        { nivel = lvl; }

        public int GetPV ()
        { return pv; }
        public void SetPV (int pvs)
        { pv = pvs; }

        public int GetFuerza ()
        { return fuerza; }
        public void SetFuerza (int strength)
        { fuerza = strength; }


        //Metodo atacar
        public virtual int Atacar ()
        {
            return fuerza * 2;
        }

        /*
         *  // Propiedades _ Otra forma de definir las propiedades de una forma más corta y más limpia
                 public string Nombre { get => nombre; set => nombre = value; }
                public int Nivel { get => nivel; set => nivel = value; }
                public int PV { get => pv; set => pv = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        */
    }
}
