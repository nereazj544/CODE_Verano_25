using Poli_1.Class;

class Program
{
    static void Main ()
    {
        List<Negocio> ng = new List<Negocio>();

        Restaurante r = new Restaurante();
        r.SetTlf("93284920330248239");
        r.SetDir("Calle de la comida");
        r.SetProp("No se");
        r.SetHoraAper(10, 30);
        r.SetHoraCR(22, 30);
        r.SetCubiertos(100);
        
        //Añadimos el Restaurante a la lista de negocios
        ng.Add(r);

        Negocio ngc = new Negocio();
        ngc.SetProp("Takeshi Kurai");
        ngc.SetDir("Calle Kurai");
        ngc.SetTlf("123456789");
        //Añadimos el Negocio a la lista de negocios
        ng.Add(ngc);

        Hotel h = new Hotel();
        h.SetNumHab( 25 );
        h.SetNumEstrellas( 4 );
        h.SetTlf("987654321");
        h.SetDir("Calle del Hotel");
        h.SetProp("Hotel Nose");

        //Añadimos el Hotel a la lista de negocios
        ng.Add(h);


        foreach ( Negocio n in ng )
        {
            n.Mostrar();
        }

    }
}
