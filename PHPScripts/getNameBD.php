<?php
//Incluimos el archivo para conectar
include ("includes/conexion.php");

$nombre = $_GET['nombre'];

//Para mostrar los resultados...
foreach($db->query("SELECT nombre, apellido FROM jugador WHERE nombre = 'nombre'") as $row){
	echo $row['nombre'].' '.$row['apellido']; //etc
}
?>
<html>
    <head>
        <title>Conexión a la Base de Datos</title>
    </head>
<body>
	<br/>
 	<a href="index.php">Inicio</a> 
 	<br/>
 	<a href="postNameBD.php">Post Name</a>
</body>
</html>