<?php
$db = mysqli_connect("localhost", "adminUnity", "admin", "pruebasunity");
if ($db->connect_errno) {
    echo "Fallo al conectar a MySQL: (" . $db->connect_errno . ") " . $db->connect_error;
}
?>