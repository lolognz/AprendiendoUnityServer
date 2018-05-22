<?php
/*
Recoge los datos que se envian desde Unity y los almacena en una variable
Representa los datos mediante la variable
*/
$name = $_GET['name'];
echo 'nombre recibido: ' .$name;
?>
<html>
    <head>
        <title>Conexión a la Base de Datos</title>
    </head>
<body>
	<br/>
 	<a href="index.php">Inicio</a> 
 	<br/>
 	<a href="getName.php">Get Name</a>
</body>
</html>