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
<?php
    /*$v2 = $_POST['cmbCiudad'];
    echo $v2;*/
    ?>
<!DOCTYPE html>
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
    
       
    <a href="#" class="scrollup">Scroll</a>
<!-- Encabezado  -->
    <header>
        <nav class="navbar navbar-expand-lg navbar-dark "  style="background-image: url('img/fondo3.png');  ">
            <div class="row">
                <div class="col-sm">
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
                <div class="col-8">
                    <div >
                        <h1 class="titulo">GLUZZER</h1>
                    </div>
                </div>
            </div>  
        </nav>
        <nav class="navbar navbar-expand-lg navbar-dark bg-rojo">
 		     <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    		      <span class="navbar-toggler-icon"></span>
  		    </button>

  		    <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <div class="mx-auto d-block my-lg-1">
    		      <ul class="navbar-nav mr-auto">
      			       <li class="nav-item active">
                           <a class="nav-link navbar-brand primary-text-color" id="navBuscar" href="#"><i class="fa fa-search fa-2x"></i></a>
      			       </li>
                        <li class="nav-item">
        			         <a class="nav-link navbar-brand" id="navFavoritos" href="#"><i class="fa fa-heart fa-2x"></i></a>
      			       </li>
      			       <li class="nav-item">
        			         <a class="nav-link navbar-brand" id="navTag" href="#"><i class="fa fa-tag fa-2x"></i></a>
      			       </li>
                      <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle navbar-brand" href="#" id="navUser" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><i class="fa fa-user fa-2x"></i></a>
                            <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                                <a class="dropdown-item" href="#"><i class="fa fa-map-marker nav-item-tam"> Cambiar ciudad</i></a>
                            <div class="dropdown-divider"></div>
                                <a class="dropdown-item" href="#"><i class="fa fa-power-off nav-item-tam"> Salir</i></a>
                            </div>
                        </li>
    		          </ul>
    		      </div>
                  <div class="col col-lg-2 textUser">
                    <?php echo $_SESSION['user'] ?>
                </div>        
            </div>
            
	   </nav>
    </header>
    
<!-- Cuerpo  -->    
<section class="main">
    <div id="cuerpo">
        <?php
        require_once('buscar.php');
        ?>
    </div>
</section>
    
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
                        <h3>Restaurantes</h3>
                        <ul>
                            <li>PANOS'S Pizza</li>
                        </ul>

                    </div>
                </div>
                <div class="col-sm">
                    <div class="divNegociosPie">
                        <h3>Reportes</h3>
                        <ul>
                            <button type="button" class="btn btn-danger btn-lg"  id="btnRegCancelar" value="Ir a la página"
                       onclick="pag=window.open('grafica.php?recordID=<?php echo $row_activar_preregistro['idsolicitud']; ?>','pag');"
                            >+ Visitados</button>

                            <br>
                            <br>
                             <button type="submit" class="btn btn-danger btn-lg"  id="btnRegCancelar"
                              value="Ir a la página"
                              onclick="pag2=window.open('grafica2.php?recordID=<?php echo $row_activar_preregistro['idsolicitud']; ?>','pag2');"

                             >+ Calificados</button>


                        </ul>

                    </div>
            </div>
        </div>
    </footer>
    
<!-- jQuery first, then Popper.js, then Bootstrap JS -->
        <script src="js/jquery-3.2.1.min.js" ></script>
        <script src="js/popper.min.js" ></script>
        <script src="js/bootstrap.min.js" ></script>
        <script src="js/scroll.js"></script>
        <script src="js/index.js" ></script>
</body>
</html>