<?php 

include_once('connect_user_db.php');

$email = $_GET['email'];
$daily_calorie_intake = $_GET['daily_calorie_intake'];
$total_calorie_intake = $_GET['total_calorie_intake'];
$calorie_intake_days = $_GET['calorie_intake_days'];

$result = mysqli_query($con,"UPDATE user_data SET daily_calorie_intake='$daily_calorie_intake', total_calorie_intake='$total_calorie_intake', calorie_intake_days='$calorie_intake_days' WHERE email='$email';");
echo "Data Updated";
?>