using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Agenda
    {

        public static Agenda Lista;

        public static Agenda Listado()
        {
            if (Lista == null) Lista = new Agenda();

            return Lista;
        }



        public Agenda()
        {
            listaPersonales = new List<Personal>();

            listaFinancieras = new List<Financiera>();
        }

        public List<Financiera> listaFinancieras { get; set; }

        public List<Personal> listaPersonales { get; set; }


    }
}

