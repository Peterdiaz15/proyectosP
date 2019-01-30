using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFruteria.Datos
{
	class DAOventas
	{
		Conexion cn = new Conexion();
		public List<Pojos.VarVentas> llenar()
		{
			List<Pojos.VarVentas> lstProd = new List<Pojos.VarVentas>();
			MySqlDataReader dr;

			MySqlCommand cm = new MySqlCommand("select idVenta,fecha,nombres,totalProducto,precio,totalPagar,cantidad" +
				" from ventas", cn.Conectar());

			dr = cm.ExecuteReader();
			while (dr.Read())
			{
				Pojos.VarVentas objVentas = new Pojos.VarVentas();
				objVentas.ID = dr.GetInt32("idVenta");
				objVentas.Fecha = dr.GetDateTime("fecha");
				/*objVentas.Nombres = dr.GetString("nombres");
				objVentas.TotalProductos = dr.GetDouble("totalProducto");
				objVentas.Precio = dr.GetDouble("precio");
				objVentas.TotalPagar = dr.GetDouble("totalPagar");
				objVentas.Cantidad = dr.GetInt32("cantidad");*/
				lstProd.Add(objVentas);
			}
			cn.Cerrar();
			return lstProd;
		}

		public void AgregarVenta(Pojos.VarVentas objValores)
		{
			string sql;
			MySqlCommand cm;
			cm = new MySqlCommand();
			cm.Parameters.AddWithValue("@idventa", objValores.ID);
			cm.Parameters.AddWithValue("@fecha", objValores.Fecha);
			cm.Parameters.AddWithValue("@totalPagar", objValores.TotalPagar);
			sql = "INSERT INTO ventas(idVenta,fecha,totalPagar)VALUES(@idventa,@fecha,@totalPagar);";
			cm.CommandText = sql;
			cm.CommandType = CommandType.Text;
			cm.Connection = cn.Conectar();
			cm.ExecuteNonQuery();
			cn.Cerrar();
		}
		public int buscarId()
		{
			int id = 0;
			try
			{
				MySqlCommand cm = new MySqlCommand("SELECT Max(idVenta) as venta FROM ventas", cn.Conectar());
				MySqlDataReader dr;
				dr = cm.ExecuteReader();
				while (dr.Read())
				{
					id = dr.GetInt32("venta");
					return id;
				}
			}
			catch (Exception e)
			{
				return 0;
			}
			cn.Cerrar();

			return id;
		}
        public double totalDia(DateTime fecha)
        {
            Pojos.VarVentas objVenta = new Pojos.VarVentas();
            try
            {
                string sql;
                MySqlCommand cm;
                MySqlDataReader dr;

                cm = new MySqlCommand();
                sql = "select sum(totalPagar) as total from ventas where fecha ='" + fecha.Year+"/"+fecha.Month+"/"+fecha.Day+"'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cn.Conectar();
                cm.ExecuteNonQuery();


                dr = cm.ExecuteReader();


                while (dr.Read())
                {
                    objVenta.TotalPagar = dr.GetDouble("total");

                }
            }
            catch (Exception e)
            {
            }
            cn.Cerrar();
            return objVenta.TotalPagar;

        }

        /*public void AgregarPro(Pojos.VarVentas objVentas)
		{

			string sql;
			MySqlCommand cm;

			cm = new MySqlCommand();
			cm.Parameters.AddWithValue("@fecha", objVentas.Fecha);
			cm.Parameters.AddWithValue("@nombres", objVentas.Nombres);
			cm.Parameters.AddWithValue("@totalpro", objVentas.TotalProductos);
			cm.Parameters.AddWithValue("@precio", objVentas.Precio);
			cm.Parameters.AddWithValue("@totalpa", objVentas.TotalPagar);
			cm.Parameters.AddWithValue("@cantidad", objVentas.Cantidad);
			sql = "INSERT INTO ventas(fecha,nombres,totalProducto,precio,totalPagar,cantidad)VALUES(@fecha,@nombres,@totalpro," +
				"@precio,@totalpa,@cantidad)";
			cm.CommandText = sql;
			cm.CommandType = CommandType.Text;
			cm.Connection = cn.Conectar();
			cm.ExecuteNonQuery();
			cn.Cerrar();
		}*/
    }
}
