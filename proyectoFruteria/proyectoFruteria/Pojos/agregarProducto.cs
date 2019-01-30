using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFruteria.Pojos
{
	class agregarProducto
	{
		public int idVenta { get; set; }
		public int idProductos { get; set; }
		public String Nombres { get; set; }
		public double Total { get; set; }
		public double Precio { get; set; }
		public double Cantidad { get; set; }


		public agregarProducto(int idventa,int idproductos,String nombres,double total,double precio, double cantidad)
		{
			this.idVenta = idventa;
			this.idProductos = idproductos;
			this.Nombres = nombres;
			this.Total = total;
			this.Precio = precio;
			this.Cantidad = cantidad;

		}


		public agregarProducto() { }
	}
}

