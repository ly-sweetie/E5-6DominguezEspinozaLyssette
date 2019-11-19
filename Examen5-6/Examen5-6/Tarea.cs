using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen5_6
{
    class Tarea
    {

        //Intanciacion de tarea
        public string Usuario { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Fecha { get; set; }

        public string Status { get; set; }

        public string Hora { get; set; }

        //Para el update del status
        public int IndexRow { get; set; }
    }
}
