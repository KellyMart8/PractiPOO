using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOOO
{
    public class Contenedora    //para usarlo en otras clases es public
    {
        class Anidada
        {
            public void EscribrirMensaje()
            {
                Console.WriteLine("Anidad.EscribirMensaje");
            }
        }

        public void Acceder()
        {
            Anidada anidada = new Anidada();
            anidada.EscribrirMensaje(); 
        }
    }
}
