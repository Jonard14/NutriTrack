<?php 

include_once('connect_user_db.php');


$email = $_GET['email'];
$first_name =  $_GET['first_name'];
$last_name =  $_GET['last_name'];
$birthday =  $_GET['birthday'];
$gender =  $_GET['gender'];
$height =  $_GET['height'];
$weight =  $_GET['weight'];
$bmi =  $_GET['bmi'];
$password =  $_GET['password'];

$result = mysqli_query($con,"INSERT INTO user_data (email, first_name, last_name, birthday, gender, height, weight, bmi) VALUES ('$email', '$first_name', '$last_name', '$birthday', '$gender', '$height', '$weight', '$bmi')");
$result = mysqli_query($con,"UPDATE user_data SET daily_calorie_intake='0', total_calorie_intake='0', calorie_intake_days='0' WHERE email='$email'");
$result = mysqli_query($con,"INSERT INTO login VALUES ('$email', MD5('$password'))");

echo "Data Inserted";
?>
