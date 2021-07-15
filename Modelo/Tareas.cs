using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Tareas
    {
        public DateTime ingreso { set; get; }

        public string nombre { set; get; }
        

        public DateTime vencimiento { set; get; }

        public bool pendiente { set; get; }


    }
}
