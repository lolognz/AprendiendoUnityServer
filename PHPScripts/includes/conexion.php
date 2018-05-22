<?php
$db = new PDO('mysql:host=localhost; dbname=pruebasunity; charset=utf8', 'adminUnity', 'admin');
$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
$db->setAttribute(PDO::ATTR_EMULATE_PREPARES, false);
?>