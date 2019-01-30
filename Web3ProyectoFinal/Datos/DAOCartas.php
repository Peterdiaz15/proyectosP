<?php
    require_once 'conexion.php'; /*importa Conexion.php*/
require_once '../Modelo/VarCartas.php'; /*importa el modelo */
class DAOCartas
{
    
    private $conexion; /*Crea una variable conexion*/
        
    private function conectar(){
        try{
            $this->conexion = Conexion::abrirConexion(); /*inicializa la variable conexion, llamando el metodo abrirConexion(); de la clase Conexion por medio de una instancia*/
        }
        catch(Exception $e)
        {
            die($e->getMessage()); /*Si la conexion no se establece se cortara el flujo enviando un mensaje con el error*/
        }
    }

    /*Metodo que obtiene todos los alumnos de la base de datos, retorna una lista de objetos */
    public function obtenerTodos()
    {
        try
        {
            $this->conectar();
            
            $lista = array(); /*Se declara una variable de tipo  arreglo que almacenará los registros obtenidos de la BD*/

            $sentenciaSQL = $this->conexion->prepare("SELECT _idEntidad,nombre ,descripcion,url_logo,direccion FROM entidad"); /*Se arma la sentencia sql para seleccionar todos los registros de la base de datos*/
            
            $sentenciaSQL->execute();/*Se ejecuta la sentencia sql, retorna un cursor con todos los elementos*/
            
            /*Se recorre el cursor para obtener los datos*/
            foreach($sentenciaSQL->fetchAll(PDO::FETCH_OBJ) as $fila)
            {
                $obj = new VarCartas();
                $obj->id = $fila->_idEntidad;
                $obj->nombre = $fila->nombre;
                $obj->descripcion = $fila->descripcion;
                $obj->url_logo= $fila->url_logo;
                $obj->direccion= $fila->direccion;

                $lista[] = $obj;
            }
            
            return $lista;
        }
        catch(Exception $e){
            echo $e->getMessage();
            return null;
        }finally{
            Conexion::cerrarConexion();
        }
    }
    /*Metodo que obtiene todos los alumnos de la base de datos, retorna una lista de objetos */
    public function obtenerPorCiudad($ciudad)
    {
        try
        {
            $this->conectar();
            
            $lista = array(); /*Se declara una variable de tipo  arreglo que almacenará los registros obtenidos de la BD*/

            $sentenciaSQL = $this->conexion->prepare("SELECT _idEntidad,nombre ,descripcion,url_logo,direccion FROM entidad where _idCiudad = ? "); /*Se arma la sentencia sql para seleccionar todos los registros de la base de datos*/
            
            $sentenciaSQL->execute([$ciudad]);/*Se ejecuta la sentencia sql, retorna un cursor con todos los elementos*/
            
            /*Se recorre el cursor para obtener los datos*/
            foreach($sentenciaSQL->fetchAll(PDO::FETCH_OBJ) as $fila)
            {
                $obj = new VarCartas();
                $obj->id = $fila->_idEntidad;
                $obj->nombre = $fila->nombre;
                $obj->descripcion = $fila->descripcion;
                $obj->url_logo= $fila->url_logo;
                $obj->direccion= $fila->direccion;

                $lista[] = $obj;
            }
            
            return $lista;
        }
        catch(Exception $e){
            echo $e->getMessage();
            return null;
        }finally{
            Conexion::cerrarConexion();
        }
    }
    /*Metodo que obtiene todos los alumnos de la base de datos, retorna una lista de objetos */
    public function buscar($bus)
    {
        try
        {
            $this->conectar();
            
            $lista = array(); /*Se declara una variable de tipo  arreglo que almacenará los registros obtenidos de la BD*/
            
             $sentenciaSQL = $this->conexion->prepare("SELECT _idEntidad,nombre ,descripcion,url_logo,direccion FROM entidad where 
            LOWER(nombre) like ? or LOWER(descripcion) like ?"); /*Se arma la sentencia sql para seleccionar todos los registros de la base de datos*/
            
            $sentenciaSQL->execute(["%$bus%","%$bus%"]);/*Se ejecuta la sentencia sql, retorna un cursor con todos los elementos*/
            
            /*Se recorre el cursor para obtener los datos*/
            foreach($sentenciaSQL->fetchAll(PDO::FETCH_OBJ) as $fila)
            {
                $obj = new VarCartas();
                $obj->id = $fila->_idEntidad;
                $obj->nombre = $fila->nombre;
                $obj->descripcion = $fila->descripcion;
                $obj->url_logo= $fila->url_logo;
                $obj->direccion= $fila->direccion;

                $lista[] = $obj;
            }
            
            return $lista;
        }
        catch(Exception $e){
            echo $e->getMessage();
            return null;
        }finally{
            Conexion::cerrarConexion();
        }
    }
    
    
}
?>