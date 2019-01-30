<?php  

 $connect = mysqli_connect("localhost", "root", "root", "gluzzer");  
 //$query = "SELECT gender, count(*) as number FROM tbl_employee GROUP BY gender";  
 //$query = "SELECT nombre, count(*) as visitas FROM entidad GROUP BY nombre";
   $query = "select visitas, nombre from entidad ";

 $result = mysqli_query($connect, $query);  
 ?>  
 <!DOCTYPE html>  
 <html>  
      <head>  
            <link rel="stylesheet" href="css/styleCharts.css" media="all">
            <link rel="stylesheet" href="css/bootstrap.min.css">
             <link rel="stylesheet" href="css/font-awesome.min.css">

            <div ><img id="logo" src="img/logo.png"  > </div>

            
            <h2 id="gluzzer">GLUZZER</h2>
            <button type="submit" class="btn btn-info btn-lg"  id="btnRegCancelar" class="imprimir"  P&aacute;gina" onclick="window.print();" >Imprimir</button>

           <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>  
           <script type="text/javascript">  

           google.charts.load('current', {'packages':['corechart']});  
           google.charts.setOnLoadCallback(drawChart);  

          //$bus=$_POST['id'];
        

           function drawChart()  

           {  
                var data = google.visualization.arrayToDataTable([  
                          ['Restaurante', 'Visitas'],  
                          <?php  
                          while($row = mysqli_fetch_array($result))  
                          {  
                              echo "['".$row["nombre"]."', ".$row["visitas"]."]," ;   
                          }  
                          ?>  
                     ]);  
                var options = {  
                      title: 'GRAFICA DE LOS RESTAURANTES MAS VISITADOS', titleTextStyle: {color: '#161271'},  
                      //is3D:true,  
                      pieHole: 0.4  
                     };  
                var chart = new google.visualization.ColumnChart(document.getElementById('columnchart_values'));  
                chart.draw(data, options);  
           }  
           </script>  
      </head>  
      <body>  
           <br /><br />  
           <div style="width:900px;">  
                <h3 align="center" id="Titulo"> Grafica de barras de los restaurantes más visitados en Gluzzer</h3>  
                <br />  
                <div id="columnchart_values" style="width: 900px; height: 500px;"></div>  
           </div>  
      </body>  

        <script src="js/jquery-3.2.1.min.js" ></script>
        <script src="js/popper.min.js" ></script>
        <script src="js/bootstrap.min.js" ></script>
 </html>  