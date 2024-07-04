<?php 

include_once('connect_user_db.php');


$email = $_GET['email'];
$types = $_GET['types'];

$result = mysqli_query($con,"INSERT INTO `illnesses` VALUES ('$email', '$types');");

echo "Data Inserted";
?>