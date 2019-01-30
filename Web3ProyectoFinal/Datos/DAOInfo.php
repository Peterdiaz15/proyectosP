<?php
require_once 'conexion.php'; /*importa Conexion.php*/
require_once '../Modelo/VarInfo.php'; /*importa el modelo */
class DAOInfo
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
     public function ActualizarInfoVerMas($id){

         try
        {
            $this->conectar();
            
             $sentenciaSQL = $this->conexion->prepare("UPDATE entidad SET visitas = visitas + 1  where _idEntidad = ?"); /*Se arma la sentencia sql para seleccionar todos los registros de la base de datos*/
            
            echo "ID".$id;
            $sentenciaSQL->execute([$id]);/*Se ejecuta la sentencia sql, retorna un cursor con todos los elementos*/
            return true;
        }
        catch(Exception $e){
            echo $e->getMessage();
            return false;
        }finally{
            Conexion::cerrarConexion();
        }

    }

    public function buscarInfo($id){

         try
        {
            $this->conectar();
            
            $lista = array(); /*Se declara una variable de tipo  arreglo que almacenará los registros obtenidos de la BD*/
            
             $sentenciaSQL = $this->conexion->prepare("SELECT e._idEntidad, e.nombre ,e.url_logo, e.direccion,p.nombre,p.precio 
            FROM entidad AS e INNER JOIN productos AS p ON e._idEntidad = p.id_Entidad where e._idEntidad=?"); /*Se arma la sentencia sql para seleccionar todos los registros de la base de datos*/
            
            $sentenciaSQL->execute([$id]);/*Se ejecuta la sentencia sql, retorna un cursor con todos los elementos*/
            
            /*Se recorre el cursor para obtener los datos*/
            foreach($sentenciaSQL->fetchAll(PDO::FETCH_OBJ) as $fila)
            {
                $obj = new VarInfo();
                $obj->id = $fila->_idEntidad;
                $obj->nombreEntidad = $fila->nombre;
                $obj->imagen= $fila->url_logo;
                $obj->direccion = $fila->direccion;
                $obj->nombreProducto= $fila->nombre;
                $obj->precio= $fila->precio;

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



 public function ActualizarCalificaciones($id ,$calificacion){
         try
        {
            $this->conectar();
            
             $sentenciaSQL = $this->conexion->prepare("UPDATE entidad SET calificacion = calificacion + $calificacion where _idEntidad = ?"); /*Se arma la sentencia sql para seleccionar todos los registros de la base de datos*/
            
            echo "ID".$id;
            $sentenciaSQL->execute([$id]);/*Se ejecuta la sentencia sql, retorna un cursor con todos los elementos*/
            return true;
        }
        catch(Exception $e){
            echo $e->getMessage();
            return false;
        }finally{
            Conexion::cerrarConexion();
        }

    }
}

?>