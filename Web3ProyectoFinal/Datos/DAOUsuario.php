<?php
require_once 'conexion.php'; /*importa Conexion.php*/
require_once '../Modelo/VarUsuario.php'; /*importa el modelo */
class DAOusuario
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

    public function buscar($nombre,$password){

        try
        { 
            $this->conectar();
            
            $registro = null; /*Se declara una variable  que almacenará el registro obtenido de la BD*/
            $clave=0;
            
            $sentenciaSQL = $this->conexion->prepare("SELECT nombre, contrasena FROM users WHERE nombre=? and contrasena=?"); /*Se arma la sentencia sql para seleccionar todos los registros de la base de datos*/
            $sentenciaSQL->execute([$nombre,$password]);/*Se ejecuta la sentencia sql, retorna un cursor con todos los elementos*/
            
            /*Obtiene los datos*/
            foreach($sentenciaSQL->fetchAll(PDO::FETCH_OBJ) as $fila)
            {
            $registro = new VarUsuario();
            $registro->nombre = $fila->nombre;
            $registro->contrasena = $fila->contrasena;
            $clave= 1;
           }
            return $clave;
        }
        catch(Exception $e){
            echo $e->getMessage();
            return null;
        }finally{
            Conexion::cerrarConexion();
        }
    }  
    //Agrega un nuevo Usuario de acuerdo al objeto recibido como parámetro
    public function agregar(VarUsuario $obj)
    {
        $clave=0;
        try 
        {
            $sql = "INSERT INTO users
                        (Correo,
                        Contrasena,
                        Nombre,
                        Apellidos,
                        Telefono,
                        Ciudad)
                        VALUES
                        (?,?,?,?,?,?)";
            var_dump($sql);
            $this->conectar();
            $this->conexion->prepare($sql)
                 ->execute(
                array($obj->correo,
                        $obj->contrasena,
                        $obj->nombre,
                        $obj->apellidos,
                        $obj->telefono,
                        $obj->ciudad));
            $clave=$this->conexion->lastInsertId();
            var_dump($clave);
            return $clave;
        } catch (Exception $e){
            //echo $e->getMessage();
            return $clave;
        }finally{
            Conexion::cerrarConexion();
        }
    }
}
?>