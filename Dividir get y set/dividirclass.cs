using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dividir_get_y_set
{
    internal class dividirclass
    {
        //se ponen en privado los tipos de datos
        private double N1;
        private double N2;

        //nos permite proteger o crear límites de acceso a las variables y métodos de una clase,
        //controlando con ello el comportamiento fuera y dentro de la misma clase
        public double N11 { get => N1; set => N1 = value; }
        public double N21 { get => N2; set => N2 = value; }

        //metodo, accion, lo que hace.
        public double divicion()
        {
            return (N1 / N2);
        }
    }
}
