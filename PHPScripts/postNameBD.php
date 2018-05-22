<?php
//Incluimos el archivo para conectar
include ("includes/conexion.php");

//Cogemos el valor de las variables que nos envía Unity
$name = $_GET['nombre'];
$surname = $_GET['apellido'];

//Mostramos el valor por la consola
echo 'nombre recibido: ' .$name;
echo 'apellido recibido: ' .$surname;

//Insertamos valores en la base de datos
$stmt = $db->prepare("INSERT INTO jugador(nombre, apellido) VALUES(:field1, :field2)");
$stmt->execute(array(':field1' => $name, ':field2' => $surname));

//Para comprobar la introducción desde la página a modo LOG, mostramos los datos de la BD
foreach($db->query('SELECT * FROM jugador') as $row){
	echo $row['nombre'].' '.$row['apellido'].' ';
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
 	<a href="getNameBD.php">Get Name</a>
</body>
</html>