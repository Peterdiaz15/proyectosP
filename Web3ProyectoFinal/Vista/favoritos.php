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
<!-- Div 2 cartas  -->
	<div class="jumbotron jumbotron-fluid bg-white">
  		<div class="container">
  			<div class="card-deck">
  				  <?php
                require_once('../datos/DAOCartas.php');
                   $operacion="";
                   $lista = (new DAOCartas())->obtenerTodos();
                  foreach($lista as $registro){
                  echo "<form method='post' action='info.php'>".
                       "<div class='card-body'>".
                        "<div class='contenedor'>".
                            "<div class='carta'>".
                                "<div class='lado frente'>".
                                    "<input type='hidden' name='img' value='$registro->url_logo'/><img class='tamCarta' src=$registro->url_logo>".
                                    "<img class='esquinario' src='img/ic_esquinaroja.png'>".
                                    "<input type='hidden' name='id' value='$registro->id'/>".
                                "</div>".
                                "<div class='lado atras'>".
                                    "<div class='form-fav'>
                                        <p class='favorito' >
                                           <div class='heart'></div>
                                        </p>
                                     </div>".
                                   "<div class='container'>".
                                        "<div class='row'>".
                                            "<div class='col-md-12'>". 
                                                "<h3><input type='hidden' name='nombreE' value='$registro->nombre'/>$registro->nombre</h3>".
                                            "</div>".
                                            "<div class='col-md-12'>".
                                               "<input type='hidden' name='direccion' value='$registro->direccion'/><h6>$registro->descripcion</h6>".
                                            "</div>".
                                            "<div class='col-md-6 ml-md-auto'>".
                                                "<input type='submit' class='btn btn-link' id='btnVerMas' value='Ver mas..' />".
                                            "</div>".
                                        "</div>".
                                    "</div>".
                                "</div>".
                            "</div>".
                       "</div>".
                    "</div>".
  				"</form>";
                   }                              
                ?> 
			</div>
 	 	</div>
 	 </div>
    
<!-- jQuery first, then Popper.js, then Bootstrap JS -->
        <script src="js/jquery-3.2.1.min.js" ></script>
        <script src="js/popper.min.js" ></script>
        <script src="js/bootstrap.min.js" ></script>
        <script src="js/index.js" ></script>
</body>
</html>