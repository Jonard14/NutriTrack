<?php 

include_once('connects.php');

$email = $_GET['email'];
$first_name =  $_GET['firstname'];
$last_name =  $_GET['lastname'];
$age =  $_GET['age'];
$height =  $_GET['height'];
$weight =  $_GET['weight'];
$bmi =  $_GET['bmi'];

$result = mysqli_query($con,"INSERT INTO user_data (email, first_name, last_name, age, height, wght, bmi) VALUES ('$email', '$first_name', '$last_name', '$age', '$height', '$weight', '$bmi')");
echo "Data Inserted";
?>