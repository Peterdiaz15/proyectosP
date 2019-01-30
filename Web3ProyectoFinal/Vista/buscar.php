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
    <link rel="stylesheet" href="css/styleH.css">
</head>
<body>
  <!-- Div 1 Formulario de buscar -->
        
<div class="jumbotron jumbotron-fluid bg-white">
  		<div class="container ">
            <form method="post" id="formulario">
                <div class="container">
                    <div class="row">
                        <div class="col-sm">
                            <div class="form-group">
                                <input type="text" class="" id="txtbuscar" name="buscar" placeholder="¿Que estas buscando?">
                                <input type="button" id="btn-buscar" class="btn btn-primary btn-Buscar"  value="Buscar" />
                            </div>
                        </div>
                        <!--<div class="col-sm">
                            <div class="form-group form-check">
                                <input type="checkbox" class="form-check-input checkTamano" id="BusquedaAv">
                                <label class="form-check-label">Busqueda Avanzada</label>
                            </div>
                        </div>-->
                    </div>
                </div>
               <!-- <div class="form-group form-check ocultar-check">
                    <div class="container">
                        <div class="row">
                            <div class="col-sm">
                                <input type="checkbox" name="ConWifi" value="SI" class="form-check-input checkTamano" id="wifi">
                                <label class="form-check-label">Wifi</label>
                            </div>
                            <div class="col-sm">
                                <input type="checkbox" name="ConAlcohol" value="SI"  class="form-check-input checkTamano" id="Alcohol">
                                <label class="form-check-label">Alcohol</label>
                            </div>
                            <div class="col-sm">
                                <input type="checkbox" class="form-check-input checkTamano" id="tv">
                                <label class="form-check-label">TV</label>
                            </div>
                            <div class="col-sm">
                                <input type="checkbox" class="form-check-input checkTamano" id="ServicioDomicilio">
                                <label class="form-check-label">Servicio a domicilio</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm">
                                <input type="checkbox" class="form-check-input checkTamano" id="Reserva">
                                <label class="form-check-label">Reservas</label>
                            </div>
                            <div class="col-sm">
                                <input type="checkbox" class="form-check-input checkTamano" id="ParaLLevar">
                                <label class="form-check-label">Para llevar</label>
                            </div>
                            <div class="col-sm">
                                <input type="checkbox" class="form-check-input checkTamano" id="Tarjeta">
                                <label class="form-check-label">Tarjeta</label>
                            </div>
                            <div class="col-sm">
                                <input type="checkbox" class="form-check-input checkTamano" id="Estacionamiento">
                                <label class="form-check-label">Estacionamiento</label>
                            </div>
                        </div>
                    </div>
                </div>-->
            </form>
 	 	</div>
	</div>

<!-- Div 2 cartas  -->
<div class="jumbotron jumbotron-fluid bg-white">
  		<div class="container">
  			<div class="card-deck" id='resp'>
                <?php
                require_once('funcionBuscar.php');
                ?>
			</div>
 	 	</div>
 	 </div>
    
    
<!-- jQuery first, then Popper.js, then Bootstrap JS -->
        <script src="js/jquery-3.2.1.min.js" ></script>
        <script src="js/popper.min.js" ></script>
        <script src="js/bootstrap.min.js" ></script>
        <script src="js/index.js" ></script>
	   <script src="js/app.js"></script>
</body>
</html>