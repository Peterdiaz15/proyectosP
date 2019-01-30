using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFruteria.Pojos
{
    class VarCategoria
    {
        private int pcodigo;
        private string pnombre;

        public int CODIGO
        {
            get { return pcodigo; }
            set { pcodigo = value; }
        }
        public string NOMBRE
        {
            get { return pnombre; }
            set { pnombre = value; }
        }
    }
}
