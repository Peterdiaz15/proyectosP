using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFruteria.Datos
{
	class DAOVentaProducto
	{
		Conexion cn = new Conexion();
		
		public List<Pojos.MostrarProducto> llenar(int id)
		{
			List<Pojos.MostrarProducto> lstProd = new List<Pojos.MostrarProducto>();
			MySqlDataReader dr;

			MySqlCommand cm = new MySqlCommand("select nombres,cantidad,precio,total" +
				" from venta_Producto where idVentaP =" + id, cn.Conectar());
			dr = cm.ExecuteReader();
			while (dr.Read())
			{
				Pojos.MostrarProducto objAp = new Pojos.MostrarProducto();
				objAp.Nombres = dr.GetString("nombres");
				objAp.Cantidad = dr.GetDouble("cantidad");
				objAp.Precio = dr.GetDouble("precio");
				objAp.Total = dr.GetDouble("total");
				lstProd.Add(objAp);
			}
			cn.Cerrar();
			return lstProd;
		}
        public void AgregarPro(Pojos.agregarProducto objValores)
		{

			string sql;
			MySqlCommand cm;

			cm = new MySqlCommand();
			cm.Parameters.AddWithValue("@idVentaP", objValores.idVenta);
			cm.Parameters.AddWithValue("@idProductos", objValores.idProductos);
			cm.Parameters.AddWithValue("@nombres", objValores.Nombres);
			cm.Parameters.AddWithValue("@total", objValores.Total);
			cm.Parameters.AddWithValue("@precio", objValores.Precio);
			cm.Parameters.AddWithValue("@cantidad", objValores.Cantidad);
			sql = "INSERT INTO venta_Producto(idVentaP,idProductos,nombres,total,precio,cantidad)VALUES(@idVentaP,@idProductos," +
				"@nombres,@total,@precio,@cantidad);";
			cm.CommandText = sql;
			cm.CommandType = CommandType.Text;
			cm.Connection = cn.Conectar();
			cm.ExecuteNonQuery();
			cn.Cerrar();
		}

        public void EliminarPro(Pojos.agregarProducto objValores)
        {
            string sql;
            MySqlCommand cm;

            cm = new MySqlCommand();
            sql = "delete from venta_producto where idVentaP="+objValores.idVenta+ " and nombres='" + objValores.Nombres+"';";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cn.Conectar();
            cm.ExecuteNonQuery();
            cn.Cerrar();
        }

        public void EliminarTodo(Pojos.agregarProducto objValores)
        {
            string sql;
            MySqlCommand cm;

            cm = new MySqlCommand();
            sql = "delete from venta_producto where idVentaP=" + objValores.idVenta + ";";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cn.Conectar();
            cm.ExecuteNonQuery();
            cn.Cerrar();
        }
        public double CambiarCantidad(int idventa, string nombreProducto)
        {
            Pojos.agregarProducto objValores = new Pojos.agregarProducto();
            try
            {
                MySqlDataReader dr;
                MySqlCommand cm = new MySqlCommand("select cantidad from venta_producto where nombres='" + nombreProducto
                    + "' and idVentaP=" + idventa + ";", cn.Conectar());
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    objValores.Cantidad = dr.GetDouble("cantidad");
                    cn.Cerrar();
                    return objValores.Cantidad;
                } 
            }
            catch (Exception e)
            {

            }
            cn.Cerrar();
            return -1;
        }
        

        
        public void EditarPro(Pojos.agregarProducto objValores)
        {
            string sql;
            MySqlCommand cm;

            cm = new MySqlCommand();
            sql = "UPDATE venta_producto SET cantidad = "+objValores.Cantidad+
                ", total = "+objValores.Total+", precio = "+objValores.Precio+" WHERE idVentaP = "
                +objValores.idVenta +" and nombres = '"+objValores.Nombres+"';";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cn.Conectar();
            cm.ExecuteNonQuery();
            cn.Cerrar();
        }
        
        public double traerTotal(int idventa)
		{
            Pojos.agregarProducto objValores = new Pojos.agregarProducto();
            try
            {
                string sql;
                MySqlCommand cm;
                MySqlDataReader dr;

                cm = new MySqlCommand();
                sql = "select sum(total) as total from venta_Producto where idVentaP =" + idventa + "";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cn.Conectar();
                cm.ExecuteNonQuery();


                dr = cm.ExecuteReader();


                while (dr.Read())
                {
                    objValores.Total = dr.GetDouble("total");

                }
            }
            catch (Exception e)
            {
            }
            cn.Cerrar();
			return objValores.Total;
		}
       

    }
}
