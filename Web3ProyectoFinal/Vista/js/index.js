$(document).ready(function(){
    
/*----- cambiar la seleccion del navegador----------- */
    // elementos de la lista
  var menues = $("nav li"); 

  // manejador de click sobre todos los elementos
  menues.click(function() {
     // eliminamos active de todos los elementos
     menues.removeClass("active");
     // activamos el elemento clicado.
     $(this).addClass("active");
  });
    
 /*----- Oculta los Checks cundo inicia la pagina----------- */   
    $('.ocultar-check').hide();
    
/*------funcion para cambiar de ventana-------------------*/
    $("#navFavoritos").click(function(event){
             $("#cuerpo").load('favoritos.php');  
    });
    $("#navBuscar").click(function(event){
              $("#cuerpo").load('buscar.php');  
    });   
    
/*--------------funcion  de Buscar ------------------*/
    $('#btn-buscar').click(function(){
		var url= "../Vista/funcionBuscar.php";
		$.ajax({                        
		   type: "POST",                 
		   url: url,                    
		   data: $("#formulario").serialize(),
		   success: function(data)            
		   {
			 $('#resp').html(data);           
		   }
		 });
	  });
    
/*--------------funcion Registrar usuario ------------------*/
    $('#btnRegAceptar').click(function(){
		var url= "../Vista/registroUsuario.php";
		$.ajax({                        
		   type: "POST",                 
		   url: url,                    
		   data: $("#formularioUsuario").serialize(),
		   success: function(data)            
		   {
			 $('#respUsuario').html(data);           
		   }
		 });
	  });
    
    /*--------------funcion logear usuario ------------------*/
    $('#btnIniAceptar').click(function(){
		var url= "../Vista/LoginUsuario.php";
		$.ajax({                        
		   type: "POST",                 
		   url: url,                    
		   data: $("#formularioLoginUsuario").serialize(),
		   success: function(data)            
		   {
			 $('#respLoginUsuario').html(data);           
		   }
		 });
	  });

 /*ESTRELLA UNA*/   
    $('#radio1').click(function(){
		var url= "../Vista/calificacion.php";
		$.ajax({                        
		   type: "POST",                 
		  url: url,                    
		   data: $("#formEs").serialize(),
		   success: function(data)            
		   {
			 $('#cont').html(data);           
		   }
		 });
	  });

/*ESTRELLA DOS*/   
    $('#radio2').click(function(){
		var url= "../Vista/calificacion.php";
		$.ajax({                        
		   type: "POST",                 
		  url: url,                    
		   data: $("#formEs").serialize(),
		   success: function(data)            
		   {
			 $('#cont').html(data);           
		   }
		 });
	  }); 


 /*ESTRELLA TRES*/   
    $('#radio3').click(function(){
		var url= "../Vista/calificacion.php";
		$.ajax({                        
		   type: "POST",                 
		  url: url,                    
		   data: $("#formEs").serialize(),
		   success: function(data)            
		   {
			 $('#cont').html(data);           
		   }
		 });
	  });

/*ESTRELLA CUATRO*/   
    $('#radio1').click(function(){
		var url= "../Vista/calificacion.php";
		$.ajax({                        
		   type: "POST",                 
		  url: url,                    
		   data: $("#formEs").serialize(),
		   success: function(data)            
		   {
			 $('#cont').html(data);           
		   }
		 });
	  });


 /*ESTRELLA CINCO*/   
    $('#radio1').click(function(){
		var url= "../Vista/calificacion.php";
		$.ajax({                        
		   type: "POST",                 
		  url: url,                    
		   data: $("#formEs").serialize(),
		   success: function(data)            
		   {
			 $('#cont').html(data);           
		   }
		 });
	  });
    
/*--------------Busqueda avanzada ------------------   
    $("#BusquedaAv").on( "click", function() {
        
        if( $('#BusquedaAv').prop('checked') ) {
            $('.ocultar-check').show(); //muestro mediante clase
        }else{
            $('.ocultar-check').hide();
        }});*/
    

});