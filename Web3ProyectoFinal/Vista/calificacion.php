
<?php

if (!empty($_POST['estrella1'])) {
    require_once('../datos/DAOInfo.php');
                $resul = false;
                $bus=$_POST['estrella1'];
                $id=$_POST['id'];
                $result = (new DAOInfo())->ActualizarCalificaciones($id, $bus);
                

 //echo "ID".$id."Calificacion".$bus;
}


elseif (!empty($_POST['estrella2'])) {
     require_once('../datos/DAOInfo.php');
                $resul = false;
                $bus=$_POST['estrella2'];
                 $id=$_POST['id'];
                $result = (new DAOInfo())->ActualizarCalificaciones($id, $bus);
                
}

elseif (!empty($_POST['estrella3'])) {
     require_once('../datos/DAOInfo.php');
                $resul = false;
                $bus=$_POST['estrella3'];  
                 $id=$_POST['id'];
                $result = (new DAOInfo())->ActualizarCalificaciones($id,$bus);
                
}

elseif (!empty($_POST['estrella4'])) {
     require_once('../datos/DAOInfo.php');
                $resul = false;
                $bus=$_POST['estrella4'];
                $id=$_POST['id'];
                $result = (new DAOInfo())->ActualizarCalificaciones($id,$bus);
                
  

}

elseif (!empty($_POST['estrella5'])) {
     require_once('../datos/DAOInfo.php');
                $resul = false;
                $bus=$_POST['estrella5'];
                $id=$_POST['id'];
                $result = (new DAOInfo())->ActualizarCalificaciones($id,$bus);
                
  

}



?>
