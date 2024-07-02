<?php

include_once('connect_user_db.php');

$email = $_GET['email'];
$password =  $_GET['password'];

$query = "UPDATE login SET password=MD5('$password') WHERE email='$email'";
$result = mysqli_query($con,$query);
echo $result;
?>