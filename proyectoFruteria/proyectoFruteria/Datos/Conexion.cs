using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using proyectoFruteria.Properties;
using System.Configuration;


namespace proyectoFruteria.Datos
{
    class Conexion
    {
        private MySqlConnection cnConexion = new MySqlConnection();
        public static string ObtenerString()
        {
            return Settings.Default.ConnectionString;
        }
        public MySqlConnection Conectar()
        {
            string strCadenaConexion;
           // strCadenaConexion = "SERVER=" + "127.0.0.1" + ";PORT=3306" + ";DATABASE=" + "fruteria" + ";UID=" + "root" + ";PWD=" + "root;"+ "SslMode=none";
            strCadenaConexion = ObtenerString();
           cnConexion.ConnectionString = strCadenaConexion;
            cnConexion.Open();

            return cnConexion;
        }
        public void Cerrar()
        {
            cnConexion.Close();
        }
    }
}
