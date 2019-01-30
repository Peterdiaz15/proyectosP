<html>
<head>
	<meta charset="utf-8">
	<title></title>
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/font-awesome.min.css">
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <!-- Modal Login -->
<div class="modal fade" id="loginModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h2 class="tituloModal" >Gluzzer</h2>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <!--<span aria-hidden="true">&times;</span>-->
        </button>
      </div>
      <div class="modal-body">
            <div class="container margen">
	           <a href="#" class="btn btn-primary btn-azul" id="btnIniciarFaceboock">
                   <div class="row">
                        <div class="col-sm-2"><i class="fa fa-facebook" id="fb"> </i></div>
                        <div class="col-sm-10"><p id="text">Iniciar sesión con Facebook</p></div>
                    </div>      
                </a>
            </div> 
            <div class="container margen">   
                <a href="#" class="btn btn-danger btn-rojoG" id="btnIniciarGoogle">
                    <div class="row">
                        <div class="col-sm-2"><i class="fa fa-google-plus" id="g"></i></div>
                        <div class="col-sm-10"><span id="text">Iniciar sesión con Google +</span></div>
                    </div>     
                </a>
            </div>
        </div>
         <div class="modal-footer">
             <div class="container margen">   
                <a href="#" class="btn btn btn-outline-danger btn-gris" id="btnIniciarSesion" data-toggle="modal" data-target="#ModalLoginUs" >
                    <div class="row">
                        <div class="col-sm-12"><span id="text">Iniciar sesión</span></div>
                    </div>     
                </a>
            </div>
            <div class="container margen">   
                <a href="#" class="btn btn btn-outline-danger btn-gris" id="btnRegistrar" data-toggle="modal" data-target="#ModalRegistro">
                    <div class="row">
                        <div class="col-sm-12"><span id="text">Registrate</span></div>
                    </div>     
                </a>
            </div>
      </div>
    </div>
  </div>
</div>
    
<!-- Modal Registrar usuario -->
<div class="modal fade" id="ModalRegistro" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
        <form method="post" id="formularioUsuario">
      <div class="modal-header">
        <h5 class="tituloModal" >Registro</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div> 
      <div class="modal-body">
       <div id="respUsuario"></div>
            <div class="form-row">
                <div class="form-group col-md-6 ">
                    <label for="inputEmail4">Correo</label>
                    <input type="email" class="form-control is-valid" id="txtRegCorreo" name="txtRegCorreo" placeholder="ejemplo@gmail.com" required pattern="^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$" maxlength="50">
                </div>
                <div class="form-group col-md-6">
                    <label for="inputPassword4">Contraseña</label>
                    <input type="password" class="form-control is-valid" id="txtRegPassword" name="txtRegPassword" placeholder="Contraseña" required pattern="[A-Za-z0-9!?-]{8,12}" maxlength="30">
                </div>
            </div>
            <div class="form-group">
                <label for="inputAddress">Nombre</label>
                <input type="text" class="form-control is-valid col" id="txtRegNombre" name="txtRegNombre" placeholder="" required pattern="[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð ,.'-]{2,48}" maxlength="30">
                <label for="inputAddress">Apellidos</label>
                <input type="text" class="form-control is-valid col" id="txtRegApellidos" name="txtRegApellidos" placeholder="" required pattern="[[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð ,.'-]{2,64}" maxlength="64">
                <label for="inputAddress2">Numero de Telefono</label>
                <input type="text" class="form-control is-valid col" id="txtRegTelefono"
                 name="txtRegTelefono"placeholder="(445)1111111" required pattern="[0-9_-]{1,15}" maxlength="15">
                <label for="select" >Ciudad</label>
                <select class="form-control is-valid" id="select" name="select">
                    <option selected value="Uriangato">Uriangato</option>
                    <option value="Moroleon">Moroleón</option>
                </select>
            </div>
      </div>
      <div class="modal-footer mod-centrar">
          <input type="button" class="btn btn-primary btn-lg" id="btnRegAceptar" value="Aceptar"/>
        <button type="submit" class="btn btn-danger btn-lg" data-dismiss="modal" id="btnRegCancelar">Cancelar</button>
      </div>
    </form>          
    </div>
  </div>
</div> 
    
 <!-- Modal Login usuario -->
<div class="modal fade" id="ModalLoginUs" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
    <form method="post" id="formularioLoginUsuario">
      <div class="modal-header">
        <h5 class="tituloModal" >Login</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
             <div class="form-group">
                <label for="inputAddress">Nombre usuario</label>
                <input type="text" class="form-control is-valid col" id="txtUsuario" name="txtUsuario" placeholder="ejemplo">
                <label for="inputAddress">Contraseña</label>
                <input type="password" class="form-control is-valid col" id="txtPassword" name="txtPassword" placeholder="Contraseña">
            </div>
        <div id="respLoginUsuario"></div>
      </div>
      <div class="modal-footer mod-centrar">
          <input type="button" class="btn btn-primary btn-lg" id="btnIniAceptar" value="Aceptar"/>
        <button type="submit" class="btn btn-danger btn-lg" data-dismiss="modal" id="btnIniCancelar">Cancelar</button>
      </div>
          
    </form> 
    </div>
  </div>
</div>    
    
<!--Pagina Principal-->    
<div class="fondoImagen" style="background-image: url('img/fondo3.png'); background-repeat: no-repeat;background-size: cover;">
        <div class="container">
            <div class="row justify-content-md-center">
                <div class="col-md-auto mg-top">
                    <label id="ciudad">Ciudad:</label>
                    <select id="inputState">
                        <option selected>Uriangato</option>
                        <option>Moroleón</option>
                    </select>
                    <button type="submit" class="btn btn-danger btn-rojo">Aceptar</button>
                </div>
            </div>
        </div>        
  
    </div>
   
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
        <script src="js/jquery-3.2.1.min.js" ></script>
        <script src="js/popper.min.js" ></script>
        <script src="js/bootstrap.min.js" ></script>
        <script src="js/funcion.js" ></script>
        <script src="js/index.js" ></script>
        <script type="js/validar.js"></script>
</body>
    
</html>