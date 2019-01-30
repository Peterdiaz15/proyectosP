function validar(){
var nombre, correo, password,apellido,expresiones;
correo.getElementById("txtRegCorreo").value;    
nombre.getElementById("txtRegNombre").value;     
password.getElementById("txtRegPassword").value; 
apellido.getElementById("txtRegApellidos").value;  
expresiones = /\w+@+\w+\.+[a-z]/;    
    
if(nombre == "" || correo==""|| password=="" || apellido==""){
    alert("Todos los campos son obligatorios");
    return false;
}else if(nombre.length>30){
    alert("Nombre demaciado largo");
    return false;
}else if(password.length<6){
    alert("Contraeña muy corta");
    return false;
}else if(apellido.length>50){
    alert("Nombre de la calle demaciada larga");
    return false;
}else if(!correo.test(correo)){
    alert("Correo no valido");
    return false; 
}  


}