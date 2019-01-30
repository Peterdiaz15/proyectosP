<?php
    /*$v2 = $_POST['id'];
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
    <link rel="stylesheet" href="css/styleInfo.css">
    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="css/styleH.css">
</head>
<body>
 <!-- Encabezado  -->
    <header>
        <nav class="navbar navbar-expand-lg navbar-dark "  style="background-image: url('img/fondo3.png');  ">
            <div class="row">
                <div class="col-sm">
                    <a class="navbar-brand" href="#">
    		          <img src="img/logo.png" class="imgTamanoLogo" alt="">
  		            </a>
                </div>
                <div class="col-8">
                    <div >
                        <h1 class="titulo">GLUZZER</h1>
                    </div>
                </div>
            </div>  
        </nav>
        
    </header>
    
    <section class="main">
<!-- Div  -->
	<div class="jumbotron jumbotron-fluid bg-white" id="principal">
        
        
        <?php
     require_once('../datos/DAOInfo.php');
    

                $resultado = false;
                $bus=$_POST['id'];

                $lista = (new DAOInfo())->buscarInfo($bus);
                $resultado = (new DAOInfo())->ActualizarInfoVerMas($bus);
                

                $nombreE=$_POST['nombreE'];
                $img=$_POST['img'];
                $direccion=$_POST['direccion'];
                echo "<div class='container'>".
                        "<div class='row justify-content-md-center'>".
                            "<div class='col-md-auto'>".
                                "<img src='$img' id='imgLogo'>".
                            "</div>".
                            "<div class='col col col-lg-1'>
                                <div class='heart'></div>
                              </div>".
                        "</div>".
                        "<div class='row justify-content-md-center'>
                            <div class='col-md-auto'>
                                <h3 id='nombre'>$nombreE</h3>
                            </div>
                        </div>".
                        "<div class='row justify-content-md-center'>
                            <div class='col-md-auto'>
                                <h3 id='direccion'>$direccion</h3>
                            </div>
                        </div>".
                         " <div class='row justify-content-md-center'>
                                <div class='col-md-auto'>
                                    <i class='fa fa-wifi'></i>
                                    <i class='fa fa-bed'></i>    
                                    <i class='fa fa-parking'></i>
                                    <i class='fa fa-tv'></i>
                                    <i class='fa fa-cc-mastercard'></i> 
                                </div>
                            </div>".
                        "<div class='row'>
                            <div class='col'>

                             <form method='post' id='formEs'>
                             <input type='hidden' name='id' value='$bus'/>
                                <p class='clasificacion' >
                                    <input id='radio1' name='estrella1' value='5' type='radio'><label for='radio1' class='es'>★</label>
                                    <input id='radio2' name='estrella2' value='4' type='radio'><label for='radio2' class='es'>★</label>
                                    <input id='radio3' name='estrella3' value='3' type='radio'><label for='radio3' class='es'>★</label>
                                    <input id='radio4' name='estrella4' value='2' type='radio'><label for='radio4' class='es'>★</label>
                                    <input id='radio5' name='estrella5' value='1' type='radio'><label for='radio5' class='es'>★</label>

                                </p>

                            </form>

                            <div id= 'cont'>   </div>

                            </div>
                        </div>".
                    "</div>";
                
                    echo "<div id='menu' class='container'>
                                <div class='row justify-content-md-center'>
                                    <div class='col-md-auto'>
                                        <h2>Menú</h2> 
                                    </div>
                                </div>
                                <div class='row'>
                                    <div class='col'>
                                        <h3>Plato</h3>
                                    </div>
                                    <div class='col'>
                                        <h3>Precio</h3>
                                    </div>
                                </div>";
                    foreach($lista as $registro){
                        echo "<div class='row'>
                                <div class='col'>
                                    <li> $registro->nombreProducto..........</li>
                                </div>
                                <div class='col'>
                                    <h4>$ $registro->precio</h4>
                                </div>
                            </div>";
                   }
                    echo  "</div>";
                
                ?> 
 	 	</div>
</section>
   <!-- Pie de Pagina  -->
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
        <script src="js/index.js" ></script>
        <script src="js/app.js"></script>
</body>
</html>