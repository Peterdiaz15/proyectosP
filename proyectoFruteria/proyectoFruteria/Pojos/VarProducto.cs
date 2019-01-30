using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFruteria.Pojos
{
    class VarProducto
    {
        private int pidProductos;
        private string pnombreCompleto;
        private double pprecioAdquirido;
        private double pprecioVendido;
        private double pcantidad;
        public DateTime pfechaAdquirido;
        private string pnombreCategoria;

        public int idProductos
        {
            get { return pidProductos; }
            set { pidProductos = value; }
        }
        public string nombreCompleto
        {
            get { return pnombreCompleto; }
            set { pnombreCompleto = value; }
        }

        public double precioAdquirido
        {
            get { return pprecioAdquirido; }
            set { pprecioAdquirido = value; }
        }

        public double precioVendido
        {
            get { return pprecioVendido; }
            set { pprecioVendido = value; }
        }
        public double cantidad
        {
            get { return pcantidad; }
            set { pcantidad = value; }
        }
        public DateTime fechaAdquirido
        {
            get { return pfechaAdquirido; }
            set { pfechaAdquirido = value; }
        }
        public string nombrecategoria
        {
            get { return pnombreCategoria; }
            set { pnombreCategoria = value; }
        }
    }
}
