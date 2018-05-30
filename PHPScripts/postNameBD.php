<?php
//Incluimos el archivo para conectar
include ("includes/conexion.php");

//Cogemos el valor de las variables que nos envía Unity
$name = isset($_GET['nombre']) ? $_GET['nombre'] : '';
$surname = isset($_GET['apellido']) ? $_GET['apellido'] : '';

//Mostramos el valor por la consola
echo 'nombre recibido: ' .$name;
echo 'apellido recibido: ' .$surname;

//Insertamos valores en la base de datos
$stmt = "INSERT INTO jugador(nombre,apellido) VALUES('$name','$surname')";
if (mysqli_query($db, $stmt)) {
    echo "New record created successfully";
} else {
    echo "Error: " . $stmt . "<br>" . mysqli_error($db);
}

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