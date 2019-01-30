using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFruteria.Pojos
{
	class MostrarProducto
	{
		
		public String Nombres { get; set; }
		public double Cantidad { get; set; }
		public double Precio { get; set; }
		public double Total { get; set; }



		public MostrarProducto(String nombres, double cantidad, double precio, double total)
		{
		
			this.Nombres = nombres;
			this.Total = total;
			this.Precio = precio;
			this.Cantidad = cantidad;

		}


		public MostrarProducto() { }
	}
}
