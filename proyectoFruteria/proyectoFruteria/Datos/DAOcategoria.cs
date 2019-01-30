using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoFruteria.Datos
{
    class DAOcategoria
    {
        Conexion cn = new Conexion();
        public List<Pojos.VarCategoria> LlenarCategoria()
        {
            List<Pojos.VarCategoria> lstProd = new List<Pojos.VarCategoria>();
            MySqlDataReader dr;
            MySqlCommand cm = new MySqlCommand("select c.nombreCategoria as CATEGORIA, c. idCategoria as ID from categoria c;", cn.Conectar());
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Pojos.VarCategoria objValores = new Pojos.VarCategoria();

                objValores.NOMBRE = dr.GetString("CATEGORIA");
                objValores.CODIGO = dr.GetInt32("ID");
                lstProd.Add(objValores);
            }
            cn.Cerrar();
            return lstProd;
        }
    }
}
