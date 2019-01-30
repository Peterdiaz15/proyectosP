<?php
     require_once('../datos/DAOCartas.php');
         if (!empty($_POST['buscar'])) {
                $bus=$_POST['buscar'];
                $lista = (new DAOCartas())->buscar($bus);
            foreach($lista as $registro){
                echo "<form method='post' action='info.php'>".
                       "<div class='card-body'>".
                        "<div class='contenedor'>".
                            "<div class='carta'>".
                                "<div class='lado frente'>".
                                    "<img class='tamCarta' src=$registro->url_logo>".
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
                                                "<h3>$registro->nombre</h3>".
                                            "</div>".
                                            "<div class='col-md-12'>".
                                               "<h6>$registro->descripcion</h6>".
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
                }else{ 
                    //$ciudad= $_POST['cmbCiudad'];
                   $lista = (new DAOCartas())-> obtenerTodos();
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
                }
                ?> 