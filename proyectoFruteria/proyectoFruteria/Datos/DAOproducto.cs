using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace proyectoFruteria.Datos
{
    class DAOproducto
    {
        Conexion cn = new Conexion();
        public List<Pojos.VarProducto> llenar()
        {
            List<Pojos.VarProducto> lstProd = new List<Pojos.VarProducto>();
            MySqlDataReader dr;

            MySqlCommand cm = new MySqlCommand("SELECT p.idProductos as Codigo, p.nombreCompleto as 'Nombre_Completo', p.precioAdquirido as " +
                "'Precio_Adquirido', p.precioVendido as 'Precio_de_Venta', p.cantidad as 'Cantidad', " +
                "p.fecha as 'Fecha',c.nombreCategoria as 'Categoria' FROM productos p " +
                "join categoria c on p.idCategoria = c.idCategoria;", cn.Conectar());
            
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Pojos.VarProducto objValores = new Pojos.VarProducto();
                objValores.idProductos =  dr.GetInt32("Codigo");
                objValores.nombreCompleto = dr.GetString("Nombre_Completo");
                objValores.precioAdquirido = dr.GetDouble("Precio_Adquirido");
                objValores.precioVendido = dr.GetDouble("Precio_de_Venta");
                objValores.cantidad = dr.GetDouble("Cantidad");
                objValores.nombrecategoria = dr.GetString("Categoria");
                objValores.fechaAdquirido = dr.GetDateTime("Fecha");

                lstProd.Add(objValores);
            }
            cn.Cerrar();
            return lstProd;
        }

        public List<Pojos.VarProducto> Buscar(string text)
        {
            List<Pojos.VarProducto> lstProd = new List<Pojos.VarProducto>();
            MySqlDataReader dr;

            MySqlCommand cm = new MySqlCommand("SELECT p.idProductos as Codigo, p.nombreCompleto as "+
                "'Nombre_Completo', p.precioAdquirido as'Precio_Adquirido', p.precioVendido as "+
                "'Precio_de_Venta', p.cantidad as 'Cantidad',p.fecha as 'Fecha', c.nombreCategoria as"+
                "'Categoria' FROM productos p join categoria c on p.idCategoria = c.idCategoria where "+
                "p.nombreCompleto like '%" + text + "%'  or "+
                "c.nombreCategoria like '%" + text + "%' ; ", cn.Conectar());

            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Pojos.VarProducto objValores = new Pojos.VarProducto();
                objValores.idProductos = dr.GetInt32("Codigo");
                objValores.nombreCompleto = dr.GetString("Nombre_Completo");
                objValores.precioAdquirido = dr.GetDouble("Precio_Adquirido");
                objValores.precioVendido = dr.GetDouble("Precio_de_Venta");
                objValores.cantidad = dr.GetDouble("Cantidad");
                objValores.nombrecategoria = dr.GetString("Categoria");
                objValores.fechaAdquirido = dr.GetDateTime("Fecha");

                lstProd.Add(objValores);
            }
            cn.Cerrar();
            return lstProd;
        }
        public void AgregarPro(Pojos.VarProducto objValores)
        {

            string sql;
            MySqlCommand cm;

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@nombre", objValores.nombreCompleto);
            cm.Parameters.AddWithValue("@precioAdquirido", objValores.precioAdquirido);
            cm.Parameters.AddWithValue("@precioVendido", objValores.precioVendido);
            cm.Parameters.AddWithValue("@cantidad", objValores.cantidad);
            cm.Parameters.AddWithValue("@categoria", objValores.nombrecategoria);
            cm.Parameters.AddWithValue("@fecha",objValores.fechaAdquirido);
            sql = "INSERT INTO productos(nombreCompleto,precioAdquirido,precioVendido,cantidad,idCategoria,fecha)VALUES(@nombre,@precioAdquirido,"+
                "@precioVendido,@cantidad,@categoria,@fecha);";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cn.Conectar();
            cm.ExecuteNonQuery();
            cn.Cerrar();
        }
        public void EliminarPro(Pojos.VarProducto objValores)
        {
            string sql;
            MySqlCommand cm;

            cm = new MySqlCommand();
            sql = "DELETE FROM productos WHERE idProductos = '" + objValores.idProductos + "'";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cn.Conectar();
            cm.ExecuteNonQuery();
            cn.Cerrar();
        }
        public void EditarPro(Pojos.VarProducto objValores)
        {
            MySqlCommand cm = new MySqlCommand("EditarProducto", cn.Conectar());
            cm.Parameters.AddWithValue("@id", objValores.idProductos);
            cm.Parameters.AddWithValue("@nombre", objValores.nombreCompleto);
            cm.Parameters.AddWithValue("@precioA", objValores.precioAdquirido);
            cm.Parameters.AddWithValue("@precioV", objValores.precioVendido);
            cm.Parameters.AddWithValue("@cant", objValores.cantidad);
            cm.Parameters.AddWithValue("@idCat", objValores.nombrecategoria);
            cm.Parameters.AddWithValue("@fech", objValores.fechaAdquirido);
            cm.CommandType = CommandType.StoredProcedure;
            cm.ExecuteNonQuery();
            cn.Cerrar();
        }

        public DataTable DatosProductos()
        {
            DataTable dt = new DataTable();
            MySqlCommand cm = new MySqlCommand("select nombreCompleto from productos;", cn.Conectar());
            MySqlDataAdapter adap = new MySqlDataAdapter(cm);
            adap.Fill(dt);
            cn.Cerrar();
            return dt;
        }
        public bool buscarExistencia(string nombreProducto)
        {
            Pojos.VarProducto objValores = new Pojos.VarProducto();
            /*try
            {*/
                MySqlDataReader dr;
                MySqlCommand cm = new MySqlCommand("select nombreCompleto from productos where nombreCompleto='"+ nombreProducto + "';", cn.Conectar());
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    objValores.nombreCompleto = "nombreCompleto";
                    cn.Cerrar();
                    return true;
                }
            /*}
            catch (Exception e)
            {

            }*/
            cn.Cerrar();
            return false;
        }
        public double ProductoExistencia(double cant, string nombreProducto)
        {
            Pojos.VarProducto objValores = new Pojos.VarProducto();

            MySqlDataReader dr;
            MySqlCommand cm = new MySqlCommand("select (cantidad-" + cant + ") as cantidad from productos where nombreCompleto='"
                + nombreProducto + "';", cn.Conectar());
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                objValores.cantidad = dr.GetDouble("cantidad");

            }

            cn.Cerrar();

            return objValores.cantidad;
        }

        public double traerPrecio(String nombreProducto)
		{
			MasProductos objM = new MasProductos();
			string sql;
			MySqlCommand cm;
			MySqlDataReader dr;

			cm = new MySqlCommand();
			sql = "select precioVendido from productos where nombreCompleto ='" + nombreProducto + "'";
			cm.CommandText = sql;
			cm.CommandType = CommandType.Text;
			cm.Connection = cn.Conectar();
			cm.ExecuteNonQuery();


			dr = cm.ExecuteReader();

			Pojos.VarProducto objValores = new Pojos.VarProducto();
			while (dr.Read())
			{
				objValores.precioVendido = dr.GetDouble("precioVendido");

			}
			cn.Cerrar();
			return objValores.precioVendido;
		}
        public void descontar(double cantidad, int id)
        {
            Pojos.agregarProducto objValores = new Pojos.agregarProducto();
            
                string sql;
                MySqlCommand cm;

                cm = new MySqlCommand();
                sql = "update productos set cantidad = (cantidad-" + cantidad + ") where idProductos=" + id + "";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cn.Conectar();
                cm.ExecuteNonQuery();

            
            cn.Cerrar();

        }
        public Int32 traeridProducto(String nombreProducto)
		{
			string sql;
			MySqlCommand cm;
			MySqlDataReader dr;

			cm = new MySqlCommand();
			sql = "select idProductos from productos where nombreCompleto ='" + nombreProducto + "'";
			cm.CommandText = sql;
			cm.CommandType = CommandType.Text;
			cm.Connection = cn.Conectar();
			cm.ExecuteNonQuery();


			dr = cm.ExecuteReader();

			Pojos.VarProducto objValores = new Pojos.VarProducto();
			while (dr.Read())
			{
				objValores.idProductos = dr.GetInt32("idProductos");

			}
			cn.Cerrar();
			return objValores.idProductos;
		}
	}
}
