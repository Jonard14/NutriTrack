<?php 

include_once('connect_user_db.php');


$email = $_GET['email'];
$time_log =  $_GET['time_log'];
$calorie_count =  $_GET['calorie_count'];
$sugar_count =  $_GET['sugar_count'];
$protein_count =  $_GET['protein_count'];
$fats_count =  $_GET['fats_count'];
$cholesterol_count =  $_GET['cholesterol_count'];
$carbohydrates_count =  $_GET['carbohydrates_count'];
$sodium_count =  $_GET['sodium_count'];

$result = mysqli_query($con,"INSERT INTO tracker_log VALUES ('$email', '$time_log', '$calorie_count', 
															'$sugar_count','$protein_count','$fats_count',
															'$cholesterol_count','$carbohydrates_count',
															'$sodium_count')");

echo "Tracker Log Inserted";
?>
