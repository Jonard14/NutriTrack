<?php 

include_once('connects.php');

$email = $_GET['email'];
$password =  $_GET['password'];


$result = mysqli_query($con,"INSERT INTO user_login VALUES ('$email', '$password')");
echo "Data Inserted";
?>