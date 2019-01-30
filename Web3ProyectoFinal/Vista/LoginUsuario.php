<?php
//la pagina se llamo a si misma?
//se verifica en la funcion isset
require_once('../datos/DAOUsuario.php');

$mostrar_error=false;

if(isset($_POST["txtUsuario"])&& isset($_POST["txtPassword"])){
   //Almacenar la variable de sesion
    session_start();
    $_SESSION["user"]=$_POST["txtUsuario"];
    $_SESSION["password"]=$_POST["txtPassword"];
    $_SESSION["entrar"]="";
    //es una llamada a si misma
    //verifica los datos
    $result= (new DAOUsuario())->buscar($_POST["txtUsuario"],$_POST["txtPassword"]);
    
    //echo $resultado;
    if ($result==1) {     
        
        $_SESSION["entrar"]="entro";
        //Aqui se redirecciona a otra pagina
        echo "<script>location.href='principall.php'</script>";    
    } else { 
            $mostrar_error=true;
        }
}

?>

<?php
                    if($mostrar_error){
                echo "<div class='alert alert-danger' role='alert'>Error: Usuario o Contrasenas Incorrectos</div>";    
                    }
    
                ?>