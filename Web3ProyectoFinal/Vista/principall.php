<?php
session_start();
error_reporting(0);
$varsesion=$_SESSION['user'];
$entro=$_SESSION['entrar'];
if(($varsesion==null || $varsesion='')||($entro==null||$entro=='')){
    header("Location:principal.php");
   die();
}

?>
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
<header>
  <nav class="navbar navbar-expand-lg navbar-dark bg-rojo-c">
        <div class="row justify-content-between">
           <div class="col-4">
                    <a class="navbar-brand" href="#">
                      <div class="ContImagenes">
    		              <img src="img/mensaje.png" id="imgMensaje" class="imgTamanoLogo" alt="">
                          <img src="img/centro.png" id="imgCentro" class="imgTamanoLogo" alt="">
                          <img src="img/tenedor.png" id="imgTenedor" class="imgTamanoLogo" alt="">
                          <img src="img/cuchillo.png"  id="imgCuchillo" class="imgTamanoLogo" alt="">
                          <img src="img/cuchara.png" id="imgCuchara" class="imgTamanoLogo" alt="">
                      </div>
  		            </a>
                </div>
            <div class="col-4 ubicacionTexto">
                <h3 class="textUser">Bienvenido: <?php echo $_SESSION['user'] ?></h3>
             </div>
          </div>  
        </nav>
</header> 
 
<!--Pagina Principal-->    
<div class="fondoImagen" style="background-image: url('img/fondo3.png'); background-repeat: no-repeat;background-size: cover;">
    <form method='post' action='menu.php'>
        <div class="container">
            <div class="row justify-content-md-center">
                <div class="col-md-auto mg-top">
                    <label id="ciudad">Ciudad:</label>
                    <select id="inputState" name="cmbCiudad">
                        <option selected value="2">Uriangato</option>
                        <option value="1">Moroleón</option>
                    </select>
                    <button type="submit" id="btnCiudad" class="btn btn-danger btn-rojo">Aceptar</button>
                </div>
             
            </div>
        </div>        
        </form>
    </div>
     <!-- Pie de pagina  -->
   <footer>
        <div class="divPiePagina">
            <div class="row">
                <div class="col-sm">
                    <ul class="LisImagenes">
                        <li>
                            <div class="row ">
                                <div class="col-sm">
            	                   <a href="">
            		                  <div id="divTwitter">
            			                 <img src="img/icotwitter.png" class="imgPP">
            		                  </div>
            	                   </a>
                                </div>
                            </div>
                        </li> 
                        <li>
                            <div class="row ">
                                <div class="col-sm">
            	                   <a href="">
            		                  <div id="divFacebook">
            			                 <img src="img/facebook-xxl.png" class="imgPP">
            		                  </div>
            	                   </a>
                                </div>
                            </div>
                        </li>
                        <li>
                            <div class="row ">
                                <div class="col-sm">
            	                   <a href="">
            		                  <div id="divGoogle">
            			                 <img src="img/google-plus-xl.png" class="imgPP">
            		                  </div>
            	                   </a>
                                </div>
                            </div>
                        </li> 
                        <li>
                            <div class="row ">
                                <div class="col-sm">
            	                   <a href="">
            		                  <div id="divIn">
            			                 <img src="img/linkedin-xxl.png" class="imgPP">
            		                  </div>
            	                   </a>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
                <div class="col-sm">
                    <div class="divCiudadesPie">
                        <h3>Ciudades</h3>
                        <ul>
                            <li>Uriangato</li>
                            <li>Moroleon</li>
                        </ul>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="divNegociosPie">
                        <h3>Negocios</h3>
                        <ul>
                            <li>PANOS'S Pizza</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
        <script src="js/jquery-3.2.1.min.js" ></script>
        <script src="js/popper.min.js" ></script>
        <script src="js/bootstrap.min.js" ></script>
        <script src="js/funcion.js" ></script>
        <script src="js/index.js" ></script>
</body>
    
</html>