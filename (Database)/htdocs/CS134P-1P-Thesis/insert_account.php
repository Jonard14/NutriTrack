<?php 

include_once('connects.php');


$email = $_GET['email'];
$first_name =  $_GET['first_name'];
$last_name =  $_GET['last_name'];
$age =  $_GET['age'];
$height =  $_GET['height'];
$weight =  $_GET['weight'];
$bmi =  $_GET['bmi'];

$password =  $_GET['password'];

$result = mysqli_query($con,"INSERT INTO user_data (email, first_name, last_name, age, height, weight, bmi) VALUES ('$email', '$first_name', '$last_name', '$age', '$height', '$weight', '$bmi')");
$result = mysqli_query($con,"INSERT INTO login VALUES ('$email', MD5('$password'))");

echo "Data Inserted";
?>