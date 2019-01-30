 <?php

    //Asegura que los datos requeridos cumplan con las mismas
    //validaciones que en el cliente para asegurar que vienen correctos
    function validar(){
        $textoValidacion="";
        
        if (!isset($_POST["txtRegCorreo"]) || strlen(trim($_POST["txtRegCorreo"]))<10 || strlen(trim($_POST["txtRegCorreo"]))>30)
            $textoValidacion.="<li>El correo debe ser entre 10 y 30 caracteres</li>";

        if (!isset($_POST["txtRegPassword"]) || strlen(trim($_POST["txtRegPassword"]))<8 || strlen(trim($_POST["txtRegPassword"]))>15)
            $textoValidacion.="<li>La contraseña debe tener entre 8 y 15 caracteres</li>";
        if (!isset($_POST["txtRegNombre"]) || strlen(trim($_POST["txtRegNombre"]))<2 ||
            strlen(trim($_POST["txtRegNombre"]))>10)
            $textoValidacion .="<li>El nombre debe tener entre 2 y 10 caracteres</li>";

        if (!isset($_POST["txtRegApellidos"]) || strlen(trim($_POST["txtRegApellidos"]))<2 || strlen(trim($_POST["txtRegApellidos"]))>30)
            $textoValidacion.="<li>Los apellidos debe ser entre 10 y 30 caracteres</li>";
        
        if (!isset($_POST["txtRegTelefono"]) || strlen(trim($_POST["txtRegTelefono"]))<10 || strlen(trim($_POST["txtRegTelefono"]))>30)
            $textoValidacion.="<li>El telefono debe ser entre 10 y 30 caracteres</li>";
        
        if ($textoValidacion){
            return "<ul>".$textoValidacion."</ul>";
        }

        return "";

    }
            //Importar el contenido del dao para usarlo
            require_once('../datos/DAOUsuario.php');
  
            $operacion="";
            $registro=null;
            $resultado=false;
      
  //La función empty nos ayuda a verificar si una variable esta
  //vacía (sin elementos o sin datos)

  //Se verifica si la variables no está vacía (implica que se dió 
  //click a guardar y se recibieron los datos de las cajas de texto

        if (!empty($_POST)) {
        $validacion=validar();
        
            $registro = new VarUsuario();
            $registro->correo=trim($_POST['txtRegCorreo']);;
            $registro->contrasena=trim($_POST['txtRegPassword']);
            $registro->nombre=trim($_POST['txtRegNombre']);
            $registro->apellidos=trim($_POST['txtRegApellidos']);
            $registro->telefono=trim($_POST['txtRegTelefono']);
            $registro->ciudad=$_POST['select'];

          if ($validacion==""){
            $resultado=(new DAOusuario())->agregar($registro);
            }else{
    ?>
        <div class="alert alert-warning" role="alert">
            <strong>La operación no puede ser realizada, se encontraron los siguientes detalles:</strong>
              <?= $validacion ?> 
        </div>
    <?php
            }
        }else{        
             $operacion="Agregar";        
        }
  
        if($resultado){
    ?>
         <script type="text/javascript">
            $(document).ready(function(){
                $('#ModalRegistro').modal('hide');
                $('#ModalLoginUs').modal('show');
            });
        </script>

    <?php
       
            
        }
    ?> 