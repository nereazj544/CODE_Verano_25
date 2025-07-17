using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poli_1.Class
{
    class Restaurante : Negocio
    {
        int cubiertos;
        int horaApertura;
        int minutosAp;
        int horaCerrar;
        int minutosCerr;

        public Restaurante ()
        { cubiertos = 0; horaApertura = 0; }


        public void SetHoraAper (int ha, int ma)
        { horaApertura = ha; minutosAp = ma; }
        public void SetHoraCR (int hc, int mc)
        { horaCerrar = hc; minutosCerr = mc; }

        public void SetCubiertos (int cubs)
        { cubiertos = cubs; }

        //Se declaran los metodos Get para obtener los valores de los atributos, como overrride
        public override void Mostrar ()
        {
            Console.WriteLine( "-------------------------" );
            Console.WriteLine( $"Datos del Restaurante" +
                $"\n\t- Propietario: {GetProp()}" +
                $"\n\t- Direccion: {GetDir()}" +
                $"\n\t- Telefono: {GetTlf()}" +
                $"\n\t- Numero de cubiertos: {cubiertos}" +
                $"\n\t- Hora de abrir: {horaApertura}"
                );
        }
    }
}
