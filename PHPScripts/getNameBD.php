<?php
//Incluimos el archivo para conectar
include ("includes/conexion.php");

$sql = "SELECT nombre, apellido FROM jugador";
$result = $db->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = mysqli_fetch_row($result)) {
        echo $row[0]. "  " . $row[1]. "\n";
    }
} else {
    echo "0 results";
}
?>
