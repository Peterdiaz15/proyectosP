using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFruteria.Pojos
{
	class VarVentas
	{
		public int ID { get; set; }
        //public string Fecha { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombres { get; set; }
		public double TotalProductos { get; set; }
		public double Precio { get; set; }
		public double TotalPagar { get; set; }
		public double Cantidad { get; set; }

		public VarVentas(int id, DateTime  fecha, string nombres, double totalProductos, double precio, double totalp, double cantidad)
		{
			this.ID = id;
			this.Fecha = fecha;
			this.Nombres = nombres;
			this.TotalProductos = totalProductos;
			this.Precio = precio;
			this.TotalPagar = totalp;
			this.Cantidad = cantidad;
		}

		public VarVentas() { }
	}
}
